using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoR2_Mods_Manager
{
    public partial class MainForm : Form
    {
        //Получить версию сборки чтобы потом впихнуть в заголовок окна
        readonly static System.Reflection.Assembly assemblyBlock = System.Reflection.Assembly.GetExecutingAssembly();
        readonly static FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assemblyBlock.Location);
        readonly static string ProjectVersion = fvi.FileVersion;

        // Класс для чтения/редактирования INI-файлов
        public class INIManager // INI Манагер
        {
            //Конструктор, принимающий путь к INI-файлу
            public INIManager(string aPath)
            {
                path = aPath;
            }

            //Конструктор без аргументов (путь к INI-файлу нужно будет задать отдельно)
            public INIManager() : this("") { }

            //Возвращает значение из INI-файла (по указанным секции и ключу) 
            public string GetPrivateString(string aSection, string aKey)
            {
                //Для получения значения
                StringBuilder buffer = new StringBuilder(SIZE);

                //Получить значение в buffer
                GetPrivateString(aSection, aKey, null, buffer, SIZE, path);

                //Вернуть полученное значение
                return buffer.ToString();
            }

            //Пишет значение в INI-файл (по указанным секции и ключу) 
            public void WritePrivateString(string aSection, string aKey, string aValue)
            {
                //Записать значение в INI-файл
                WritePrivateString(aSection, aKey, aValue, path);
            }

            //Возвращает или устанавливает путь к INI файлу
            public string Path { get { return path; } set { path = value; } }

            //Поля класса
            private const int SIZE = 1024; //Максимальный размер (для чтения значения из файла)
            private string path = null; //Для хранения пути к INI-файлу

            //Импорт функции GetPrivateProfileString (для чтения значений) из библиотеки kernel32.dll
            [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
            private static extern int GetPrivateString(string section, string key, string def, StringBuilder buffer, int size, string path);

            //Импорт функции WritePrivateProfileString (для записи значений) из библиотеки kernel32.dll
            [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
            private static extern int WritePrivateString(string section, string key, string str, string path);
        }
        // end ini
        public string endPath;
        readonly static string slfpth = Directory.GetCurrentDirectory();
        public string ConfigPath = Path.Combine(slfpth + @"\install-config.ini");
        static readonly INIManager configini = new INIManager(slfpth + @"\install-config.ini");
        string GameFolderPath = configini.GetPrivateString("Options", "GameFolderPath");
        public MainForm()
        {
            string CurrentExeName = Process.GetCurrentProcess().MainModule.ModuleName; // Получаем имя модуля (текущее, ехе файла)
            CurrentExeName = CurrentExeName.Substring(0, CurrentExeName.Length - 4); // Обрезаем строку (.exe), с конца, на 4 символа
            if (Process.GetProcessesByName(CurrentExeName).Length > 1) // Проверяем, не запущена ли прога с таким же именем модуля
            {
                MessageBox.Show(
                    "Кажется программа уже запущена ◑﹏◐",
                    "RoR2-Mods_Manager : Программа уже запущена",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                this.Close();
            }
            else
            {
                InitializeComponent();
                StartWork();
            }
        }// Инициализация формы (Придать форму форме xD)
        
        void MainForm_Load(object sender, EventArgs e)
        {
            StartWork();

            // Установить заголовок окна
            DockTitle.Text = "Менеджер установки модов Risk of Rain 2" + " " + "v" + ProjectVersion;
            
            // Проверки
            if ( File.Exists( Path.Combine( slfpth + @"\RoR2-Install-Mods.bat" ) ) != true) //Без установщика в папке программа не запустится
            {
                MessageBox.Show("\"RoR2-Install-Mods.bat\"" + " - " + "not found!",
                "RoR2-Mods_Manager : Установщик не найден.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

                this.Close();
            }
            if ( File.Exists( Path.Combine( slfpth + @"\install-config.ini" ) ) ) // Если конфиг существует
            {
                //Кнопки статуса и удаления модов будут показаны
                ToggleStatusVis.Visible = true;
                DeleteConfig.Visible = true;
                // Поднять из конфига видимость статуса
                string statVisibility = configini.GetPrivateString("Options", "StatusVisible");
                // Проверка значения видимости статуса из конфига и соотнесение с программой
                if (statVisibility == "True") { StatusPanel.Visible = true; }
                if (statVisibility == "False") { StatusPanel.Visible = false; }
                
                //Проверка чекбокса закрытия менеджера ( CloseMgrWhenRun )
                string CloseMgrWhenRun = configini.GetPrivateString("Options", "CloseMgrWhenRun");
                if (CloseMgrWhenRun == "True")  { CloseWhenRun.Checked = true;  }
                if (CloseMgrWhenRun == "False") { CloseWhenRun.Checked = false; }

                //Если есть путь к папке игры в конфиге
                if (GameFolderPath.Contains(@"\Risk of Rain 2\")) 
                {
                    GameFolderBrowser.SelectedPath = GameFolderPath;
                    PathField.Text = GameFolderPath;
                    DeleteConfig.Visible = true;
                    DeleteConfig.Enabled = true;

                }
                    ShowReadSuccNotify(); // Показать сообщение об успешной загрузке конфига
            }

            // Если игра запущена до менеджера
            if (Process.GetProcessesByName("Risk of Rain 2").Length > 0)
            {
                MessageBox.Show("Кажется игра запущена . . . \nПросьба, во избежание ошибок с установкой / удалением модов - закрыть игру \n(кнопочка для этого есть в менеджере)",
                "RoR2-Mods-Manager : Кажется игра запущена =/",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                LaunchGame.Enabled = false;
                CloseGame.Visible = true;
            }

            // Коренные Проверки
            CheckInstaller();
            CheckPathField();

            //Запустить цикличную проверку
            Cycle();
        } // Событие при загрузке формы

        // Блулька с помощью которой можно приостанавливать общий цикл

        #pragma warning disable IDE0044 // Добавить модификатор только для чтения
        bool cycleIsWorking = true;
        #pragma warning restore IDE0044 // Добавить модификатор только для чтения

        async void Cycle()
        {
            while (cycleIsWorking)
            {
                // Тело цикла
                CheckInstaller();
                CheckPathField();

                if (Process.GetProcessesByName("Risk of Rain 2").Length > 0)
                {
                    CloseGame.Visible = true;
                    CloseGame.Enabled = true;
                    LaunchGame.Enabled = false;
                    CloseGame.Text = "Закрыть игру";

                    DeleteModsButton.Enabled = false;
                    LaunchInstall.Enabled = false;
                }
                if (Process.GetProcessesByName("Risk of Rain 2").Length <= 0) // Если игра не запущена
                {
                    CloseGame.Visible = false;
                    CloseGame.Enabled = false;
                    CloseGame.Text = "Игра не запущена";
                }

                //Задержка
                await Task.Delay(3000);
            }
        } // Общая Цикличная ассинхронная функция

        void LaunchInstall_Click(object sender, EventArgs e)
        {
            LaunchInstall.Enabled = false;
            if (File.Exists(Path.Combine(slfpth + @"\RoR2-Install-Mods.bat")))
            {
                if (Process.GetProcessesByName("Risk of Rain 2").Length > 0)
                {
                    MessageBox.Show(
                        "Игра уже запущена! \nЗакройте её прежде чем устанавливать / удалять моды.",
                        "RoR2-Mods_Manager : Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CloseGame.Visible = true;
                    CloseGame.Enabled = true;
                    CloseGame.Text = "Закрыть игру";
                }
                else
                {
                //Запустить установку
                Process.Start(Path.Combine(slfpth + @"\RoR2-Install-Mods.bat"));
                    // Принуд. Задержка кнопки установки цикла чтобы нельзя было сразу перезапустить установку

#pragma warning disable IDE0059 // ("Не")нужное присваивание значения
                    bool timerIsOff = false;
#pragma warning restore IDE0059 // ("Не")нужное присваивание значения

                    asyncProc();
                    asyncIntCycle();
                    async void asyncProc()
                    {
                        await Task.Delay(3000);
                        timerIsOff = true;
                    }

                    //Спамить выключением кнопки пока
                    async void asyncIntCycle()
                    {
                        //Спамить пока таймер выше, не пройдёт
                        while (!timerIsOff)
                        {
                            LaunchInstall.Enabled = false;
                            await Task.Delay(100);
                        }
                    }
                // Проверить чекер, закрыть игру или нет
                if (CloseWhenRun.Checked == true)
                    {
                        StopWork();
                    }
                }
            }
        } // Запустить установку
        void LaunchGame_Click(object sender, EventArgs e)
        {
            void Cmd(string line)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Hidden
                }).WaitForExit();
            } //модуль cmd-шника

            GameFolderPath = configini.GetPrivateString("Options", "GameFolderPath");
            if (Process.GetProcessesByName("Risk of Rain 2").Length > 0)
            {
                MessageBox.Show(
                    "Упс... Игра уже запущена :)",
                    "RoR2-Mods_Manager : Игра уже запущена", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CloseGame.Visible = true;
                CloseGame.Enabled = true;
                CloseGame.Text = "Закрыть игру";
            } // предотвратить запуск копий игры
            else
            {
                if (GameFolderPath != null && GameFolderPath.Contains("Risk of Rain 2"))
                {
                  if (Process.GetProcessesByName("Risk of Rain 2").Length <= 0) // Опять проверка запущенной игры
                  {
                   //Process.Start(GameFolderPath + @"\Risk of Rain 2.exe");
                   Cmd($"start \"\" \"{GameFolderPath + @"Risk of Rain 2.exe"}\"");
                   LaunchGame.Enabled = false;
                        aspr();
                        async void aspr()
                        {
                            LaunchGame.Text = "Игра запущена (◠‿◠)";
                            await Task.Delay(2000);
                            LaunchGame.Text = "Запустить игру";
                        }
                    }
                   CloseGame.Visible = true;
                   CloseGame.Enabled = true;
                   CloseGame.Text = "Закрыть игру";
                  if (CloseWhenRun.Checked == true)
                  {
                   StopWork();
                  }
                }
                else
                {
                MessageBox.Show("Не удалось запустить игру", "RoR2-Mods_Manager : Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        } // Запустить игру
        void CloseGame_Click(object sender, EventArgs e)
        {
            void Cmd(string line)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Hidden
                }).WaitForExit();
            } //модуль cmd-шника

            if (Process.GetProcessesByName("Risk of Rain 2").Length <= 0)
            {
                MessageBox.Show(
                    "Игра не запущена ◑﹏◐", 
                    "RoR2-Mods_Manager : Упс . . .", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LaunchGame.Enabled = true;
                CloseGame.Enabled = false;
                CheckInstaller();
            }
            else
            {
                CheckInstaller();
                Cmd($"taskkill /F /pid \"Risk of Rain 2.exe\"");
                CloseGame.Enabled = false;
                CloseGame.Text = "Игра закрыта (◠‿◠)";
            }
        } // Закрыть игру
        void DeleteModsButton_Click(object sender, EventArgs e)
        {
            // Подтверждение удаления модов
            DialogResult result = MessageBox.Show(
            "Удалить моды?",
            "RoR2-Mods_Manager : Подтвердите действие",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                DeleteModsButton.Enabled = false;
                //Путь к папке не пуст И Файл бат делетера существует в папке с игрой
                if (GameFolderPath != null && File.Exists(Path.Combine(GameFolderPath + @"\RoR2-Mods-Deleter.bat")))
                {
                    //Запустить батник удаления модов
                    ProcessStartInfo startInfoDeleter = new ProcessStartInfo(Path.Combine(GameFolderPath + @"\RoR2-Mods-Deleter.bat"))
                    { WorkingDirectory = GameFolderPath };
                    Process.Start(startInfoDeleter);

                    // Если путь к папке не пуст И установщик есть в папке с менежиром
                    if (GameFolderPath != null &&
                         File.Exists(Path.Combine(slfpth + @"\RoR2-Install-Mods.bat")) &&
                         File.Exists(Path.Combine(slfpth + @"\install-config.ini"))
                       )
                    {

                    }
                    StatusChangeDontINS(); // Моды удалились, передаём в статус
                    if (CloseWhenRun.Checked == true)
                    {
                        StopWork();
                    }
                }

            } //Да
            else if (result == DialogResult.No)
            {
                // какое-то действие при нажатии на НЕТ
            } //Нет
        } // Удалить моды
        void DeleteConfig_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Удалить настройки программы?",
            "RoR2-Mods_Manager : Подтвердите действие",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                File.Delete(Path.Combine(slfpth + @"\install-config.ini"));
                DeleteConfig.Enabled = false;
                LaunchInstall.Enabled = false;
                PathField.Text = "";
                SavePathButton.Enabled = false;

                MessageBox.Show(
                "Настройки удалены",
                "RoR2-Mods_Manager : Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation //жёлтый треугольник с восклицанием
                ); // Выводим сообщение о завершении.

                if (CloseWhenRun.Checked == true)
                {
                    StopWork();
                }
                else { Application.Restart(); }
            } //Да
            else if (result == DialogResult.No)
            {
                // какое-то действие при нажатии на НЕТ
            } //Нет
        } // Подтверждение + Удалить конфиг + перезапуск формы
        void ExploreButton_Click(object sender, EventArgs e)
        {
            if (GameFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (GameFolderBrowser.SelectedPath != null)
                {
                    PathField.Text = GameFolderBrowser.SelectedPath + @"\";
                }
            }
            if (!PathField.Text.Contains(@"\Risk of Rain 2\"))
            {
                ShowErrorNotify();
            }
            CheckInstaller();
        } // Выбрать папку с игрой
        void SavePathButton_Click(object sender, EventArgs e) // Событие Сохранения пути из PathField в конфиг
        {
            configini.WritePrivateString("Options", "GameFolderPath", $"{PathField.Text}"); //Записать путь в ини
            configini.GetPrivateString("Options", "GameFolderPath");
            endPath = PathField.Text;
            GameFolderBrowser.SelectedPath = endPath;
            ShowNotify();
            LaunchInstall.Visible = true;
            LaunchInstall.Enabled = true;
            DeleteConfig.Visible = true;
            DeleteConfig.Enabled = true;
            LaunchGame.Visible = true;
            CheckInstaller();
            ToggleStatusVis.Visible = true;
            SavePathButton.Enabled = false;
        }
        void ToggleStatusVis_Click(object sender, EventArgs e)
        {
            DeleteConfig.Visible = true;
            bool statusIsVisible; // Булька видимости статус панели
            if (StatusPanel.Visible == true) { statusIsVisible = true; } else { statusIsVisible = false; }
            if (statusIsVisible == true)
            {
                //StatusPanel.Location = new Point(StatusPanel.Location.X, StatusPanel.Location.Y + 100);
                StatusPanel.Visible = false;
                configini.WritePrivateString("Options", "StatusVisible", "False");
            }
            else
            {
                //StatusPanel.Location = new Point(38 /*9*/, 237);
                StatusPanel.Visible = true;
                configini.WritePrivateString("Options", "StatusVisible", "True");
            }
            CheckInstaller();
        } // Переключить видимость статуса сборки + запись в конфиг
        private void OpenModsFolder_Click(object sender, EventArgs e)
        {
            void Cmd(string line)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c {line}",
                    WindowStyle = ProcessWindowStyle.Hidden
                }).WaitForExit();
            } //модуль cmd-шника
            Cmd($"start \"\" \"{slfpth + @"\Main_Mods_Setup\BepInEx\plugins"}\" ");
        } // Открыть папку с модами

        //
        // Методы вызова уведомлений
        //
        public async void ShowNotify()
        {
            NotifyPanel.Visible = true;
            NotifyText.Visible = true;
            await Task.Delay(2000); // подождать
            NotifyPanel.Visible = false;
            //Сброс видимости текстов после скрытия панели уведомления
            NotifyText.Visible = false;
        }
        public async void ShowErrorNotify()
        {
            NotifyText.Visible = false; //скрыть текст успеха
            NotifyErrorText.Visible = true;//показать текст ошибки
            NotifyPanel.Visible = true;//показать панель уведомлений
            await Task.Delay(2000); // подождать 2 сек
            NotifyPanel.Visible = false;
            //Сброс видимости текстов после скрытия панели уведомления
            NotifyErrorText.Visible = false;
            NotifyText.Visible = false;
        }
        public async void ShowReadSuccNotify()
        {
            await Task.Delay(300); //подождать полсек
            NotifyText.Visible = false; //скрыть текст успеха
            NotifyErrorText.Visible = false; //скрыть текст ошибки
            NotifyReadSuccText.Visible = true; //показать текст чтения конфига
            NotifyPanel.Visible = true; //отобразить панель уведомлений
            await Task.Delay(2000); // подождать 2 сек
            NotifyPanel.Visible = false; //скрыть панель уведомлений
            //Сброс видимости текстов после скрытия панели уведомления
            NotifyErrorText.Visible = false;
            NotifyReadSuccText.Visible = false;
            NotifyText.Visible = true;
        }
        //
        // end noti-callers
        //

        //
        // Кастом методы перетаскивания окна
        //
        Point LastPoint; // Переменная последней позиции окна
        private void DockPanel_MouseDown(object sender, MouseEventArgs e) // Перемещение окна за док панель
        {
            LastPoint = new Point(e.X, e.Y); //Запись координат курсора в переменную для перемещения окна за док панель
        }
        private void DockPanel_MouseMove(object sender, MouseEventArgs e) // Перемещение окна за док панель
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void DockTitle_MouseDown(object sender, MouseEventArgs e) // Перемещение окна за заголовок док панели
        {
            LastPoint = new Point(e.X, e.Y); //Запись координат курсора в переменную для перемещения окна за док панель
        }
        private void DockTitle_MouseMove(object sender, MouseEventArgs e) // Перемещение окна за заголовок док панели
        {
            if (e.Button == MouseButtons.Left) //Перемещение окна за док панель
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        //
        // end Win Dragging
        //

        //
        // Dock buttons
        //
        private void DockIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/2jJ3Qn4");
        } // Дискорд
        private void GitHubLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/N3M1X10/RoR2-Mods-Installer");
        } // Гитхаб
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            MinimizeForm();
        } // События нажатия на кнопку "Свернуть окно"
        private void QuitButton_Click(object sender, EventArgs e) // Событие нажатия на кнопку выхода
        {
            StopWork();
            //this.Close();
        }
        //
        // end dock butts
        //

        //
        // Прочие функции с небольшим кол-вом действий
        //
        void StatusChangeINS()
        {
            StatusTitle.Text = "Статус сборки:";
            StatusIndic.Text = "Моды установлены";
            StatusIndic.ForeColor = ColorTranslator.FromHtml("#00FF00"); // Цвет текста индика
            StatusPanel.Size = new Size(218, 27); // Размер статус панельки
        }
        void StatusChangeDontINS()
        {
            StatusTitle.Text = "Статус сборки:";
            StatusIndic.Text = "Моды не установлены";
            StatusIndic.ForeColor = ColorTranslator.FromHtml("#FF0000"); // Цвет текста индика
            StatusPanel.Size = new Size(235, 27); // Размер статус панельки
        }
        public void EnableSPB()
        {
            SavePathButton.Enabled = true;
            SavePathButton.Visible = true;
        } // Активировать кнопку записи пути
        public void DisableSPB()
        {
            SavePathButton.Enabled = false;
        } // Заблочить кнопку записи пути

        //
        // Checkers
        //
        public void CheckInstaller() // Проверки существования установщика и деинсталлятора
        {
            StatusChangeDontINS();
            //Проверка для показа кнопки установки
            if (File.Exists(Path.Combine(slfpth + @"\Delete Mods.lnk")) != true &&
                File.Exists(Path.Combine(slfpth + @"\RoR2-Install-Mods.bat")) == true &&
                GameFolderPath.Contains(@"\Risk of Rain 2\"))
            {
                LaunchInstall.Visible = true; LaunchInstall.Enabled = true; // Кнопка запуска установки показана и разблокирована
                StatusChangeDontINS();
            }
            if (File.Exists(Path.Combine(GameFolderPath + "RoR2-Mods-Deleter.bat")) &&
                File.Exists(Path.Combine(slfpth + @"\Delete Mods.lnk")) == true) // Наличие возможности удаления в папке с менеджером
            {
                DeleteModsButton.Visible = true; DeleteModsButton.Enabled = true; // Кнопка удаление модов показана разблокирована
                StatusChangeINS();
                LaunchGame.Enabled = true;
                LaunchInstall.Enabled = false;
            }
            else
            {
                DeleteModsButton.Enabled = false;
            }
            if (DeleteModsButton.Visible == true &
                DeleteModsButton.Enabled == true) // Если удалить моды можно, то установить нельзя 
            {
                LaunchInstall.Enabled = false;
            }
            //если запустить игру можно, то чекер тоже появляется
            CheckCWGR();
        }
        public void CheckPathField() // Проверить PathField
        {
            GameFolderPath = configini.GetPrivateString("Options", "GameFolderPath");
            if ( !GameFolderPath.Contains("Risk of Rain 2") )
            {
                LaunchGame.Visible = false;
            }
            else
            {
                LaunchGame.Enabled = true;
                LaunchGame.Visible = true;
            }
            if (PathField.Text == GameFolderPath & GameFolderPath != null)
            {
                SavePathButton.Text = "Этот путь уже записан";
                DisableSPB(); // Вырубить кнопку сохранения пути в случае совпадения
            }
            else { EnableSPB(); SavePathButton.Text = "Записать путь в конфиг"; }

            if (PathField.Text.Contains(@"\Risk of Rain 2\") & PathField.Text.Length >= 18 & SavePathButton.Text != "Этот путь уже записан") // На наличие определённого ключ-слова
            {
                EnableSPB();
                LaunchGame.Enabled = true;
            }
            else
            {
                DisableSPB();
                if (!PathField.Text.Contains(@"\Risk of Rain 2\"))
                {
                    SavePathButton.Text = "Некорректный путь";
                }
            }
            if (Directory.Exists(slfpth + @"\Main_Mods_Setup"))
            {
                OpenModsFolder.Visible = true;
                OpenModsFolder.Enabled = true;
            }
            //если запустить игру можно, то чекер тоже появляется
            CheckCWGR();
        }
        public void CheckCWGR()
        {
            if (LaunchGame.Enabled == true && LaunchGame.Visible == true)
            {
                CloseWhenRun.Visible = true;
            }
            else
            {
                CloseWhenRun.Visible = false;
            }
        }
        void PathField_TextChanged(object sender, EventArgs e) // Событие когда изменилось значение у PathField, он же текст бокс с путём к папке игры
        {
            CheckPathField();
            CheckInstaller();
        }
        void CloseWhenGameRun_CheckedChanged(object sender, EventArgs e)
        {
            if (CloseWhenRun.Checked == true)
            {
                configini.WritePrivateString("Options", "CloseMgrWhenRun", "True");
            }
            if (CloseWhenRun.Checked == false)
            {
                configini.WritePrivateString("Options", "CloseMgrWhenRun", "False");
            }
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            DockPanel.BackColor = ColorTranslator.FromHtml("#000000");
            DockIcon.BorderStyle = BorderStyle.None;
            GitHubLink.BorderStyle = BorderStyle.None;
        }
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            DockPanel.BackColor = ColorTranslator.FromHtml("#353535");
            DockIcon.BorderStyle = BorderStyle.FixedSingle;
            GitHubLink.BorderStyle = BorderStyle.FixedSingle;
            BackGroundPanel.Focus(); // Фокусить задник чтобы было красивее
        }
        //
        // end checkers 
        //

        //
        // Animations
        //
        readonly Timer timerStartForm = new Timer(); // Таймер увеличения непрозрачности окна
        bool StartWaitVal = false; //булька цикла у СтартВорк
        public void StartWork() // Событие плавного появления окна при запуске
        {
            AsyncProcessing();
            async void AsyncProcessing()
            {
                while (StartWaitVal == false)
                {
                    Opacity = 0; //Прозрачность окна
                    timerStartForm.Tick += new EventHandler((sender1, e1) =>
                    {
                        if ((Opacity += 0.05) == 0)
                            timerStartForm.Stop();
                    });
                    timerStartForm.Interval = 1;
                    timerStartForm.Start();
                    await Task.Delay(1000);
                    if (this.Opacity >= 1.0)
                    {
                        StartWaitVal = true;
                        timerStartForm.Dispose();
                        //QuitButton.Enabled = true;
                        //MinimizeButton.Enabled = true;
                    }
                }
            }
        }
        public void StopWork() // Событие плавного исчезновения окна и выключения программы
        {
            if (StartWaitVal == false)
            {
                StartWaitVal = true;
                timerStartForm.Stop();
                timerStartForm.Dispose();
                AsyncProcessing();
                //this.Close();
            }
            else
            {
            AsyncProcessing();
            }
            async void AsyncProcessing()
            {
                bool waitVal = false;
                while (waitVal == false)
                {
                    Opacity = 1; //Прозрачность окна
                    Timer timerStopForm = new Timer(); //Создание таймера
                    timerStopForm.Tick += new EventHandler((sender2, e2) =>
                    {
                        if ((Opacity -= 0.1) == 0)
                            timerStopForm.Stop();
                    });
                    timerStopForm.Interval = 1;
                    timerStopForm.Start();
                    await Task.Delay(500);
                    if (this.Opacity <= 0)
                    {
                        waitVal = true;
                        timerStopForm.Dispose();
                        this.Close();
                    }
                }
            }
        }
        public void MinimizeForm()
        {
            //Проверка, не идёт ли на данный момент запуск формы
            if (StartWaitVal == false)
            {
                StartWaitVal = true;
                timerStartForm.Stop();
                timerStartForm.Dispose();
                AsyncProcessing();
            }
            else
            {
                AsyncProcessing();
            }
            async void AsyncProcessing()
            {
                bool waitVal = false;
                while (waitVal == false)
                {
                    Opacity = 1; //Прозрачность окна
                    Timer timerMinimForm = new Timer(); //Создание таймера
                    timerMinimForm.Tick += new EventHandler((sender2, e2) =>
                    {
                        if ((Opacity -= 0.1) == 0)
                            timerMinimForm.Stop();
                    });
                    timerMinimForm.Interval = 1;
                    timerMinimForm.Start();
                    await Task.Delay(500);
                    if (this.Opacity <= 0)
                    {
                        waitVal = true;
                        timerMinimForm.Dispose();
                        this.WindowState = FormWindowState.Minimized;
                        Opacity = 1;
                    }
                }
            }
        }

        //
        // end anims
        //

    }
}
