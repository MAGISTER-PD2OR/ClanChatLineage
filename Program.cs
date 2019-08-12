using System;
using System.Windows.Forms;

namespace ClanChat
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName(Application.ProductName).Length > 1)
                {
                    //MessageBox.Show("Приложение уже запущено");
                    //return;
                }
                else
                {
                    Application.Run(new Form1());
                }
            }
            catch
            {
                Application.Run(new ProgramMessageBox()); //Небольшой трюк, так как в Program.cs нельзя сделать this. для MetroMessageBox
            }
        }
    }
}
