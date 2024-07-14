using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoR2_Mods_Manager
{
    public static class RunOnlyOneClass
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ShowWindow(int hwnd, int nCmdShow);

        //[DllImport("user32.dll", SetLastError = true)]
        //internal static extern int GetWindow(int hwnd, int nCmdShow);

        static Mutex _syncObject;
        static readonly string AppPath = Path.GetFileNameWithoutExtension(Application.ExecutablePath);

        /// <summary>
        /// Находит запущенную копию приложения и разворачивает окно
        /// </summary>
        /// <param name="achtotyhotel?">уникальное значение для каждой программы (можно имя)</param>
        /// <returns>true - если приложение было запущено</returns>
        public static bool ChekRunProgramm(string UniqueValue)
        {
            bool applicationRun = false;
            _syncObject = new Mutex(true, UniqueValue, out applicationRun);
            if (!applicationRun)
            {//восстановить/развернуть окно                              
                try
                {
                    Process[] procs = Process.GetProcessesByName(AppPath);
                    foreach (Process proc in procs)
                        if (proc.Id != Process.GetCurrentProcess().Id)
                        {
                            ShowWindow((int)proc.MainWindowHandle, 1);//нормально развернутое
                            //ShowWindow((int)proc.MainWindowHandle, 3);//максимально развернутое
                            SetForegroundWindow(proc.MainWindowHandle);

                            break;
                        }
                }
                catch { return false; }
            }
            return !applicationRun;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (RunOnlyOneClass.ChekRunProgramm("achtotyhotel?")) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
