using MetroFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClanChat
{
    public partial class ProgramMessageBox : Form
    {
        public ProgramMessageBox()
        {
            //Небольшой трюк, так как в Program.cs нельзя сделать this. для MetroMessageBox
            InitializeComponent();
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2)); //Центрируем на экране форму принудительно.
            TopMost = true; //Поверх окон
            MetroMessageBox.Show(this, "1. Скачайте ClanChat на офф.сайте, обновился сервер?\n2. Проверьте подключение к интернету.\n3. Проверьте не блокирует антивирус или фаервол.", "ClanChat: Нет подключения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }
}
