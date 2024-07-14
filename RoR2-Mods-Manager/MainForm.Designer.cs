namespace RoR2_Mods_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainContainer = new System.Windows.Forms.Panel();
            this.OpenModsFolder = new System.Windows.Forms.Button();
            this.CloseWhenRun = new System.Windows.Forms.CheckBox();
            this.NotifyPanel = new System.Windows.Forms.Panel();
            this.NotifyReadSuccText = new System.Windows.Forms.Label();
            this.NotifyText = new System.Windows.Forms.Label();
            this.NotifyErrorText = new System.Windows.Forms.Label();
            this.CloseGame = new System.Windows.Forms.Button();
            this.LaunchGame = new System.Windows.Forms.Button();
            this.DeleteConfig = new System.Windows.Forms.Button();
            this.DeleteModsButton = new System.Windows.Forms.Button();
            this.LaunchInstall = new System.Windows.Forms.Button();
            this.SavePathButton = new System.Windows.Forms.Button();
            this.TopMainPanel = new System.Windows.Forms.Panel();
            this.PathField = new System.Windows.Forms.TextBox();
            this.ExploreButton = new System.Windows.Forms.Button();
            this.TopLeftTitlePanel = new System.Windows.Forms.Panel();
            this.TopPanelTitleLabel = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusIndic = new System.Windows.Forms.Label();
            this.StatusTitle = new System.Windows.Forms.Label();
            this.ToggleStatusVis = new System.Windows.Forms.Button();
            this.GameFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DockPanel = new System.Windows.Forms.Panel();
            this.DockTitle = new System.Windows.Forms.Label();
            this.DockControlsPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.GitHubLink = new System.Windows.Forms.PictureBox();
            this.DockIcon = new System.Windows.Forms.PictureBox();
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainContainer.SuspendLayout();
            this.NotifyPanel.SuspendLayout();
            this.TopMainPanel.SuspendLayout();
            this.TopLeftTitlePanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.DockPanel.SuspendLayout();
            this.DockControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContainer.Controls.Add(this.OpenModsFolder);
            this.MainContainer.Controls.Add(this.CloseWhenRun);
            this.MainContainer.Controls.Add(this.NotifyPanel);
            this.MainContainer.Controls.Add(this.CloseGame);
            this.MainContainer.Controls.Add(this.LaunchGame);
            this.MainContainer.Controls.Add(this.DeleteConfig);
            this.MainContainer.Controls.Add(this.DeleteModsButton);
            this.MainContainer.Controls.Add(this.LaunchInstall);
            this.MainContainer.Controls.Add(this.SavePathButton);
            this.MainContainer.Controls.Add(this.TopMainPanel);
            this.MainContainer.Controls.Add(this.StatusPanel);
            this.MainContainer.Controls.Add(this.ToggleStatusVis);
            this.MainContainer.Location = new System.Drawing.Point(12, 44);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(593, 274);
            this.MainContainer.TabIndex = 0;
            // 
            // OpenModsFolder
            // 
            this.OpenModsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenModsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OpenModsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenModsFolder.Enabled = false;
            this.OpenModsFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OpenModsFolder.FlatAppearance.BorderSize = 0;
            this.OpenModsFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OpenModsFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenModsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenModsFolder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenModsFolder.ForeColor = System.Drawing.Color.White;
            this.OpenModsFolder.Location = new System.Drawing.Point(481, 65);
            this.OpenModsFolder.Name = "OpenModsFolder";
            this.OpenModsFolder.Size = new System.Drawing.Size(96, 40);
            this.OpenModsFolder.TabIndex = 11;
            this.OpenModsFolder.Text = "Открыть моды";
            this.OpenModsFolder.UseVisualStyleBackColor = false;
            this.OpenModsFolder.Click += new System.EventHandler(this.OpenModsFolder_Click);
            // 
            // CloseWhenRun
            // 
            this.CloseWhenRun.AutoSize = true;
            this.CloseWhenRun.Checked = true;
            this.CloseWhenRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloseWhenRun.ForeColor = System.Drawing.Color.White;
            this.CloseWhenRun.Location = new System.Drawing.Point(240, 108);
            this.CloseWhenRun.Name = "CloseWhenRun";
            this.CloseWhenRun.Size = new System.Drawing.Size(125, 17);
            this.CloseWhenRun.TabIndex = 10;
            this.CloseWhenRun.Text = "Закрыть менеджер";
            this.CloseWhenRun.UseVisualStyleBackColor = true;
            this.CloseWhenRun.Visible = false;
            this.CloseWhenRun.CheckedChanged += new System.EventHandler(this.CloseWhenGameRun_CheckedChanged);
            // 
            // NotifyPanel
            // 
            this.NotifyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotifyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotifyPanel.Controls.Add(this.NotifyReadSuccText);
            this.NotifyPanel.Controls.Add(this.NotifyText);
            this.NotifyPanel.Controls.Add(this.NotifyErrorText);
            this.NotifyPanel.Location = new System.Drawing.Point(307, 214);
            this.NotifyPanel.Name = "NotifyPanel";
            this.NotifyPanel.Size = new System.Drawing.Size(274, 50);
            this.NotifyPanel.TabIndex = 3;
            this.NotifyPanel.Visible = false;
            // 
            // NotifyReadSuccText
            // 
            this.NotifyReadSuccText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifyReadSuccText.AutoSize = true;
            this.NotifyReadSuccText.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.NotifyReadSuccText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.NotifyReadSuccText.Location = new System.Drawing.Point(44, 11);
            this.NotifyReadSuccText.Name = "NotifyReadSuccText";
            this.NotifyReadSuccText.Size = new System.Drawing.Size(184, 27);
            this.NotifyReadSuccText.TabIndex = 2;
            this.NotifyReadSuccText.Text = "Конфиг загружен!";
            this.NotifyReadSuccText.Visible = false;
            // 
            // NotifyText
            // 
            this.NotifyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifyText.AutoSize = true;
            this.NotifyText.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.NotifyText.ForeColor = System.Drawing.Color.Lime;
            this.NotifyText.Location = new System.Drawing.Point(36, 10);
            this.NotifyText.Name = "NotifyText";
            this.NotifyText.Size = new System.Drawing.Size(200, 27);
            this.NotifyText.TabIndex = 0;
            this.NotifyText.Text = "Записано в конфиг!";
            // 
            // NotifyErrorText
            // 
            this.NotifyErrorText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifyErrorText.AutoSize = true;
            this.NotifyErrorText.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.NotifyErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotifyErrorText.Location = new System.Drawing.Point(23, 10);
            this.NotifyErrorText.Name = "NotifyErrorText";
            this.NotifyErrorText.Size = new System.Drawing.Size(226, 27);
            this.NotifyErrorText.TabIndex = 1;
            this.NotifyErrorText.Text = "Указан неверный путь";
            this.NotifyErrorText.Visible = false;
            // 
            // CloseGame
            // 
            this.CloseGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CloseGame.FlatAppearance.BorderSize = 0;
            this.CloseGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CloseGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseGame.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseGame.ForeColor = System.Drawing.Color.Red;
            this.CloseGame.Location = new System.Drawing.Point(12, 109);
            this.CloseGame.Name = "CloseGame";
            this.CloseGame.Size = new System.Drawing.Size(210, 40);
            this.CloseGame.TabIndex = 7;
            this.CloseGame.Text = "Закрыть игру";
            this.CloseGame.UseVisualStyleBackColor = false;
            this.CloseGame.Visible = false;
            this.CloseGame.Click += new System.EventHandler(this.CloseGame_Click);
            // 
            // LaunchGame
            // 
            this.LaunchGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LaunchGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchGame.Enabled = false;
            this.LaunchGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LaunchGame.FlatAppearance.BorderSize = 0;
            this.LaunchGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.LaunchGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LaunchGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchGame.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchGame.ForeColor = System.Drawing.Color.Lime;
            this.LaunchGame.Location = new System.Drawing.Point(226, 65);
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.Size = new System.Drawing.Size(150, 40);
            this.LaunchGame.TabIndex = 6;
            this.LaunchGame.Text = "Запустить Игру";
            this.LaunchGame.UseVisualStyleBackColor = false;
            this.LaunchGame.Visible = false;
            this.LaunchGame.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // DeleteConfig
            // 
            this.DeleteConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DeleteConfig.FlatAppearance.BorderSize = 0;
            this.DeleteConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DeleteConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteConfig.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteConfig.ForeColor = System.Drawing.Color.Red;
            this.DeleteConfig.Location = new System.Drawing.Point(12, 65);
            this.DeleteConfig.Name = "DeleteConfig";
            this.DeleteConfig.Size = new System.Drawing.Size(103, 40);
            this.DeleteConfig.TabIndex = 5;
            this.DeleteConfig.Text = "Удалить конфиг";
            this.DeleteConfig.UseVisualStyleBackColor = false;
            this.DeleteConfig.Visible = false;
            this.DeleteConfig.Click += new System.EventHandler(this.DeleteConfig_Click);
            // 
            // DeleteModsButton
            // 
            this.DeleteModsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteModsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteModsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteModsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DeleteModsButton.FlatAppearance.BorderSize = 0;
            this.DeleteModsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DeleteModsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteModsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteModsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteModsButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteModsButton.Location = new System.Drawing.Point(119, 65);
            this.DeleteModsButton.Name = "DeleteModsButton";
            this.DeleteModsButton.Size = new System.Drawing.Size(103, 40);
            this.DeleteModsButton.TabIndex = 4;
            this.DeleteModsButton.Text = "Удалить моды";
            this.DeleteModsButton.UseVisualStyleBackColor = false;
            this.DeleteModsButton.Visible = false;
            this.DeleteModsButton.Click += new System.EventHandler(this.DeleteModsButton_Click);
            // 
            // LaunchInstall
            // 
            this.LaunchInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LaunchInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LaunchInstall.FlatAppearance.BorderSize = 0;
            this.LaunchInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.LaunchInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LaunchInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchInstall.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchInstall.ForeColor = System.Drawing.Color.Lime;
            this.LaunchInstall.Location = new System.Drawing.Point(380, 109);
            this.LaunchInstall.Name = "LaunchInstall";
            this.LaunchInstall.Size = new System.Drawing.Size(198, 40);
            this.LaunchInstall.TabIndex = 4;
            this.LaunchInstall.Text = "Запустить установку";
            this.LaunchInstall.UseVisualStyleBackColor = false;
            this.LaunchInstall.Visible = false;
            this.LaunchInstall.Click += new System.EventHandler(this.LaunchInstall_Click);
            // 
            // SavePathButton
            // 
            this.SavePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SavePathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePathButton.Enabled = false;
            this.SavePathButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SavePathButton.FlatAppearance.BorderSize = 0;
            this.SavePathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.SavePathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SavePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePathButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePathButton.ForeColor = System.Drawing.Color.Lime;
            this.SavePathButton.Location = new System.Drawing.Point(380, 65);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(97, 40);
            this.SavePathButton.TabIndex = 2;
            this.SavePathButton.Text = "Записать путь в конфиг";
            this.SavePathButton.UseVisualStyleBackColor = false;
            this.SavePathButton.Click += new System.EventHandler(this.SavePathButton_Click);
            // 
            // TopMainPanel
            // 
            this.TopMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TopMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopMainPanel.Controls.Add(this.PathField);
            this.TopMainPanel.Controls.Add(this.ExploreButton);
            this.TopMainPanel.Controls.Add(this.TopLeftTitlePanel);
            this.TopMainPanel.Location = new System.Drawing.Point(12, 12);
            this.TopMainPanel.Name = "TopMainPanel";
            this.TopMainPanel.Size = new System.Drawing.Size(566, 41);
            this.TopMainPanel.TabIndex = 0;
            // 
            // PathField
            // 
            this.PathField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PathField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathField.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathField.ForeColor = System.Drawing.Color.Gold;
            this.PathField.Location = new System.Drawing.Point(97, 0);
            this.PathField.Multiline = true;
            this.PathField.Name = "PathField";
            this.PathField.Size = new System.Drawing.Size(370, 39);
            this.PathField.TabIndex = 2;
            this.PathField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PathField.TextChanged += new System.EventHandler(this.PathField_TextChanged);
            // 
            // ExploreButton
            // 
            this.ExploreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ExploreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExploreButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExploreButton.FlatAppearance.BorderSize = 0;
            this.ExploreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.ExploreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExploreButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExploreButton.ForeColor = System.Drawing.Color.White;
            this.ExploreButton.Location = new System.Drawing.Point(467, 0);
            this.ExploreButton.Name = "ExploreButton";
            this.ExploreButton.Size = new System.Drawing.Size(97, 39);
            this.ExploreButton.TabIndex = 1;
            this.ExploreButton.Text = "Обзор";
            this.ExploreButton.UseVisualStyleBackColor = false;
            this.ExploreButton.Click += new System.EventHandler(this.ExploreButton_Click);
            // 
            // TopLeftTitlePanel
            // 
            this.TopLeftTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TopLeftTitlePanel.Controls.Add(this.TopPanelTitleLabel);
            this.TopLeftTitlePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopLeftTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftTitlePanel.Name = "TopLeftTitlePanel";
            this.TopLeftTitlePanel.Size = new System.Drawing.Size(97, 39);
            this.TopLeftTitlePanel.TabIndex = 0;
            // 
            // TopPanelTitleLabel
            // 
            this.TopPanelTitleLabel.AutoSize = true;
            this.TopPanelTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanelTitleLabel.ForeColor = System.Drawing.Color.White;
            this.TopPanelTitleLabel.Location = new System.Drawing.Point(6, 4);
            this.TopPanelTitleLabel.Name = "TopPanelTitleLabel";
            this.TopPanelTitleLabel.Size = new System.Drawing.Size(84, 30);
            this.TopPanelTitleLabel.TabIndex = 0;
            this.TopPanelTitleLabel.Text = "Путь к папке \r\nс игрой";
            this.TopPanelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusPanel.Controls.Add(this.StatusIndic);
            this.StatusPanel.Controls.Add(this.StatusTitle);
            this.StatusPanel.Location = new System.Drawing.Point(38, 237);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(235, 27);
            this.StatusPanel.TabIndex = 8;
            this.StatusPanel.Visible = false;
            // 
            // StatusIndic
            // 
            this.StatusIndic.AutoSize = true;
            this.StatusIndic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusIndic.ForeColor = System.Drawing.Color.White;
            this.StatusIndic.Location = new System.Drawing.Point(93, 4);
            this.StatusIndic.Name = "StatusIndic";
            this.StatusIndic.Size = new System.Drawing.Size(0, 15);
            this.StatusIndic.TabIndex = 1;
            // 
            // StatusTitle
            // 
            this.StatusTitle.AutoSize = true;
            this.StatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusTitle.ForeColor = System.Drawing.Color.White;
            this.StatusTitle.Location = new System.Drawing.Point(4, 3);
            this.StatusTitle.Name = "StatusTitle";
            this.StatusTitle.Size = new System.Drawing.Size(0, 15);
            this.StatusTitle.TabIndex = 0;
            // 
            // ToggleStatusVis
            // 
            this.ToggleStatusVis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToggleStatusVis.BackgroundImage = global::RoR2_Mods_Manager.Properties.Resources._3dots;
            this.ToggleStatusVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToggleStatusVis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleStatusVis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ToggleStatusVis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ToggleStatusVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleStatusVis.Location = new System.Drawing.Point(9, 237);
            this.ToggleStatusVis.Margin = new System.Windows.Forms.Padding(0);
            this.ToggleStatusVis.Name = "ToggleStatusVis";
            this.ToggleStatusVis.Size = new System.Drawing.Size(27, 27);
            this.ToggleStatusVis.TabIndex = 9;
            this.ToggleStatusVis.TabStop = false;
            this.toolTip1.SetToolTip(this.ToggleStatusVis, "Показать/Скрыть статус сборки");
            this.ToggleStatusVis.UseVisualStyleBackColor = false;
            this.ToggleStatusVis.Visible = false;
            this.ToggleStatusVis.Click += new System.EventHandler(this.ToggleStatusVis_Click);
            // 
            // GameFolderBrowser
            // 
            this.GameFolderBrowser.Description = "Выберите папку с игрой";
            // 
            // DockPanel
            // 
            this.DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DockPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DockPanel.Controls.Add(this.DockTitle);
            this.DockPanel.Controls.Add(this.DockControlsPanel);
            this.DockPanel.Controls.Add(this.GitHubLink);
            this.DockPanel.Controls.Add(this.DockIcon);
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DockPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.DockPanel.Location = new System.Drawing.Point(0, 0);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(617, 35);
            this.DockPanel.TabIndex = 1;
            this.DockPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DockPanel_MouseDown);
            this.DockPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DockPanel_MouseMove);
            // 
            // DockTitle
            // 
            this.DockTitle.AutoSize = true;
            this.DockTitle.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.DockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DockTitle.Location = new System.Drawing.Point(70, 7);
            this.DockTitle.Name = "DockTitle";
            this.DockTitle.Size = new System.Drawing.Size(288, 19);
            this.DockTitle.TabIndex = 4;
            this.DockTitle.Text = "Менеджер установки модов Risk of Rain 2";
            this.DockTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DockTitle_MouseDown);
            this.DockTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DockTitle_MouseMove);
            // 
            // DockControlsPanel
            // 
            this.DockControlsPanel.Controls.Add(this.MinimizeButton);
            this.DockControlsPanel.Controls.Add(this.QuitButton);
            this.DockControlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockControlsPanel.Location = new System.Drawing.Point(469, 0);
            this.DockControlsPanel.Name = "DockControlsPanel";
            this.DockControlsPanel.Size = new System.Drawing.Size(146, 33);
            this.DockControlsPanel.TabIndex = 5;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(0, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(73, 33);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(73, 0);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(73, 33);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // GitHubLink
            // 
            this.GitHubLink.BackgroundImage = global::RoR2_Mods_Manager.Properties.Resources.github;
            this.GitHubLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GitHubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHubLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.GitHubLink.InitialImage = null;
            this.GitHubLink.Location = new System.Drawing.Point(33, 0);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(33, 33);
            this.GitHubLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GitHubLink.TabIndex = 2;
            this.GitHubLink.TabStop = false;
            this.toolTip1.SetToolTip(this.GitHubLink, "Репозиторий на GitHub");
            this.GitHubLink.Click += new System.EventHandler(this.GitHubLink_Click);
            // 
            // DockIcon
            // 
            this.DockIcon.BackgroundImage = global::RoR2_Mods_Manager.Properties.Resources.Avatar142_128px;
            this.DockIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DockIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DockIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.DockIcon.Location = new System.Drawing.Point(0, 0);
            this.DockIcon.Name = "DockIcon";
            this.DockIcon.Size = new System.Drawing.Size(33, 33);
            this.DockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DockIcon.TabIndex = 1;
            this.DockIcon.TabStop = false;
            this.toolTip1.SetToolTip(this.DockIcon, "Discord Сообщество \"NECRO\"");
            this.DockIcon.Click += new System.EventHandler(this.DockIcon_Click);
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackGroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(617, 330);
            this.BackGroundPanel.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(617, 330);
            this.Controls.Add(this.DockPanel);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.BackGroundPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoR2-Mods - Manager";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.NotifyPanel.ResumeLayout(false);
            this.NotifyPanel.PerformLayout();
            this.TopMainPanel.ResumeLayout(false);
            this.TopMainPanel.PerformLayout();
            this.TopLeftTitlePanel.ResumeLayout(false);
            this.TopLeftTitlePanel.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.DockPanel.ResumeLayout(false);
            this.DockPanel.PerformLayout();
            this.DockControlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Panel TopMainPanel;
        private System.Windows.Forms.Button ExploreButton;
        private System.Windows.Forms.Panel TopLeftTitlePanel;
        private System.Windows.Forms.Label TopPanelTitleLabel;
        private System.Windows.Forms.TextBox PathField;
        private System.Windows.Forms.FolderBrowserDialog GameFolderBrowser;
        private System.Windows.Forms.Button SavePathButton;
        private System.Windows.Forms.Panel NotifyPanel;
        private System.Windows.Forms.Label NotifyText;
        private System.Windows.Forms.Panel DockPanel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.PictureBox DockIcon;
        private System.Windows.Forms.PictureBox GitHubLink;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label DockTitle;
        private System.Windows.Forms.Panel DockControlsPanel;
        private System.Windows.Forms.Label NotifyErrorText;
        private System.Windows.Forms.Label NotifyReadSuccText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button LaunchInstall;
        private System.Windows.Forms.Button DeleteModsButton;
        private System.Windows.Forms.Button DeleteConfig;
        private System.Windows.Forms.Button LaunchGame;
        private System.Windows.Forms.Button CloseGame;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusIndic;
        private System.Windows.Forms.Label StatusTitle;
        private System.Windows.Forms.Button ToggleStatusVis;
        private System.Windows.Forms.CheckBox CloseWhenRun;
        private System.Windows.Forms.Button OpenModsFolder;
    }
}

