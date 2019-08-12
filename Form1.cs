using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using GlobalHotkeys;
using MetroFramework;
using MetroFramework.Forms;

namespace ClanChat
{
    public partial class Form1 : MetroForm //Form
    {
        //Не трогать
        WebClient webpage = new WebClient(); //ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА
        public bool IsActive = false;
        string newVersion = "";//АПДЕЙТЕР

        //Настройки
        public string UrlDev = "http://localhost"; //Тут прописываем общий адресс сайта без / в конце.

        private GlobalHotkey ghk;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; //форсим индекс 0 для чата и убираем пустую строку
            comboBox2.SelectedIndex = 0; //форсим индекс 0 для таймера и убираем пустую строку
            this.MaximizeBox = false; //Отключаем кнопку увеличить в форме
            RegisterHotkey(); //Подгружаем хук на hotkey: Shift+Q
            LoadProcesses(); //Подгружаем список процессов и окон для combobox3.

            //----------------------------------------АПДЕЙТЕР
            TopMost = true; //Поверх окон
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2)); //Центрируем на экране форму принудительно.
            label5.Text = "Версия: " + Application.ProductVersion; //Выводим сразу версию ClanChat в label5.
            //----------------------------------------АПДЕЙТЕР

            //----------------------------------------ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА
            label4.Text = "Онлайн: " + webpage.DownloadString(UrlDev + "/index.php?action=add");
            timer3.Enabled = true;
            timer3.Interval = 600;
            //----------------------------------------ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА
        }

        // Find window special for smart guard
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        //----------------------------------------АПДЕЙТЕР
        //Create method to execute the update download
        public void DownloadUpdate()
        {
            //Declare new WebClient object
            WebClient wc = new WebClient();
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadFileAsync(new Uri(UrlDev + "/ClanChat.exe"), Application.StartupPath + "/ClanChat.exe.bak");
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Application.Exit();
        }

        //Create method to check for an update
        public void GetUpdate()
        {
            //Declare new WebClient object
            WebClient wc = new WebClient();
            string textFile = wc.DownloadString(UrlDev + "/AutoUpdaterVersion.txt");
            newVersion = textFile;

            //If there is a new version, call the DownloadUpdate method
            if (newVersion != Application.ProductVersion)
            {
                TopMost = true; //Поверх окон
                MetroMessageBox.Show(this, "Доступно обновление " + newVersion + ", ваша " + Application.ProductVersion + " устарела!\nНажмите ОК чтобы перезагрузить и обновить ClanChat.", "ClanChat: Обновление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DownloadUpdate();
            }
        }
        //----------------------------------------АПДЕЙТЕР

        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------------------------------АПДЕЙТЕР
            //Check for the update
            GetUpdate();
            //----------------------------------------АПДЕЙТЕР

            //-----------------------------------------------------------SMART GUARD
            //Запускаем таймер и ставим интервал.
            timer2.Enabled = true; //включаем второй таймер
            timer2.Interval = 500; //ставим 500 мсек
            //-----------------------------------------------------------SMART GUARD
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //------------RANDOM FORMULA
            if (checkBox2.Checked == true)
            {
                //true - legit
                Random rnd = new Random();
                int irnd = rnd.Next(1, 10);
                switch (irnd)
                {
                    case 0: timer1.Interval = 2500; break;
                    case 1: timer1.Interval = 2700; break;
                    case 2: timer1.Interval = 2800; break;
                    case 3: timer1.Interval = 2900; break;
                    case 4: timer1.Interval = 3000; break;
                    case 5: timer1.Interval = 3200; break;
                    case 6: timer1.Interval = 3300; break;
                    case 7: timer1.Interval = 3400; break;
                    case 8: timer1.Interval = 4000; break;
                    case 9: timer1.Interval = 4100; break;
                    case 10: timer1.Interval = 4200; break;
                }
            }
            else
            {
                //false
            }
            //------------RANDOM FORMULA
            DateTime dt = DateTime.Now; //Время если стоит checkbox в чат рядом к сообщению.
            //-------------------------------------------------------------------SMART GUARD
            if (checkBox3.Checked == true)
            {
                //--------------------------WITH SMART GUARD = TRUE CHECKBOX
                //Обычно после FindWindow заключаем в "Notepad++" например, но здесь заменили на comboBox3.Text
                IntPtr Guanopad = FindWindow(comboBox3.Text, null); //поиск по названию окна
                SetForegroundWindow(Guanopad);
                if (checkBox1.Checked == true)
                {
                    //true
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: SendKeys.Send("" + textBox1.Text); break;  //Общий
                        case 1: SendKeys.Send("+" + textBox1.Text); break; //+ Трейд
                        case 2: SendKeys.Send("#" + "[" + String.Format("{0:T}", dt) + "] " + textBox1.Text); break; //# Пати
                        case 3: SendKeys.Send("@" + "[" + String.Format("{0:T}", dt) + "] " + textBox1.Text); break; //@ Клан
                        case 4: SendKeys.Send("$" + textBox1.Text); break; //$ Альянс
                    }
                }
                else
                {
                    //false
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: SendKeys.Send("" + textBox1.Text); break;  //Общий
                        case 1: SendKeys.Send("+" + textBox1.Text); break; //+ Трейд
                        case 2: SendKeys.Send("#" + textBox1.Text); break; //# Пати
                        case 3: SendKeys.Send("@" + textBox1.Text); break; //@ Клан
                        case 4: SendKeys.Send("$" + textBox1.Text); break; //$ Альянс
                    }
                }
                SendKeys.Send("{Enter}");
                //--------------------------WITH SMART GUARD = TRUE CHECKBOX
            }
            else
            {
                //--------------------------WITHOUT SMART GUARD = FALSE CHECKBOX
                //Обычно после Start заключаем в "notepad++" например, но здесь заменили на comboBox3.Text
                Process p = Process.Start(comboBox3.Text); //поиск по процессу
                if (p != null)
                {
                    IntPtr h = p.MainWindowHandle;
                    SetForegroundWindow(h);
                    if (checkBox1.Checked == true)
                    {
                        //true
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0: SendKeys.Send("" + textBox1.Text); break;  //Общий
                            case 1: SendKeys.Send("+" + textBox1.Text); break; //+ Трейд
                            case 2: SendKeys.Send("#" + "[" + String.Format("{0:T}", dt) + "] " + textBox1.Text); break; //# Пати
                            case 3: SendKeys.Send("@" + "[" + String.Format("{0:T}", dt) + "] " + textBox1.Text); break; //@ Клан
                            case 4: SendKeys.Send("$" + textBox1.Text); break; //$ Альянс
                        }
                    }
                    else
                    {
                        //false
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0: SendKeys.Send("" + textBox1.Text); break;  //Общий
                            case 1: SendKeys.Send("+" + textBox1.Text); break; //+ Трейд
                            case 2: SendKeys.Send("#" + textBox1.Text); break; //# Пати
                            case 3: SendKeys.Send("@" + textBox1.Text); break; //@ Клан
                            case 4: SendKeys.Send("$" + textBox1.Text); break; //$ Альянс
                        }
                    }
                    SendKeys.Send("{Enter}");
                }
                //--------------------------WITHOUT SMART GUARD = FALSE CHECKBOX
            }
            //-------------------------------------------------------------------SMART GUARD
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                //true - legit
                checkBox1.Checked = false; //Принудительно отключаем чекбокс
                checkBox1.Enabled = false; //Принудительно отключаем чекбокс
                comboBox2.Enabled = false; //Принудательно отключаем комбо бокс
            }
            else
            {
                //false
                checkBox1.Enabled = true; //Принудительно отключаем чекбокс
                comboBox2.Enabled = true; //Принудательно отключаем комбо бокс
            }
        }

        //---------------------------------------------ЗДЕСЬ ОТДЕЛЬНЫЙ КОД ДЛЯ ХУКА HOTKEY
        protected override void WndProc(ref Message m)
        {
            var hotkeyInfo = HotkeyInfo.GetFromMessage(m);
            if (hotkeyInfo != null) HotkeyProc(hotkeyInfo);
            base.WndProc(ref m);
        }

        private void HotkeyProc(HotkeyInfo hotkeyInfo)
        {
            if (string.IsNullOrEmpty(label3.Text))
            {
                TopMost = true; //Поверх окон
                MetroMessageBox.Show(this, "Выбирайте процесс игры lineage или окно прежде чем начать.", "ClanChat: Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Отключение таймера на анонс в чат (TODO: добавить включение)
                IsActive = !IsActive;
                if (IsActive == true)
                {
                    timer1.Enabled = true;
                    //------------RANDOM FORMULA
                    if (checkBox2.Checked == true)
                    {
                        //true - legit
                        //Когда включен чекбокс легит из таймера вызываем рандомные интервалы.
                    }
                    else
                    {
                        //false
                        //Если выключен чекбокс на легит анонс, но вызываем по hotkey: Shift+Q тогда отправляем выбранный интервал в мсек из комбо бокса.
                        switch (comboBox2.SelectedIndex)
                        {
                            case 0: timer1.Interval = 600; break;
                            case 1: timer1.Interval = 700; break;
                            case 2: timer1.Interval = 800; break;
                            case 3: timer1.Interval = 900; break;
                            case 4: timer1.Interval = 1000; break;
                            case 5: timer1.Interval = 1500; break;
                            case 6: timer1.Interval = 2000; break;
                            case 7: timer1.Interval = 2500; break;
                            case 8: timer1.Interval = 2700; break;
                            case 9: timer1.Interval = 2800; break;
                            case 10: timer1.Interval = 2900; break;
                        }
                    }
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
        }

        //-----------------------------------------------------------SMART GUARD
        public string RandomTitleVsSmartGuard(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //Выводим рандомный титул окна проги и если выключено оригинальное название, запуск timer2 через FormLoad.
        //Запускаем второй таймер и гоняем титул.
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rndTitle = new Random(); //Дополнительно рандомизируем кол-во букв и цифр
            int irndTitle = rndTitle.Next(10, 40); //Задаем рандомайзер от 10 до 40
            if (checkBox3.Checked == true)
            {
                metroLabel1.Text = RandomTitleVsSmartGuard(irndTitle);
                //this.Text = RandomTitleVsSmartGuard(irndTitle);
                label3.Text = comboBox3.Text; //Отдельный label3 для проверки выбрано окно или нет.
                label2.Text = "Текущее окно:"; //WITH SMART GUARD
                button3.Text = "ОБНОВИТЬ СПИСОК ОКОН";
            }
            else
            {
                metroLabel1.Text = "ClanChat";
                //this.Text = "ClanChat - [версия "+ Application.ProductVersion + "] для Scryde";
                label3.Text = comboBox3.Text; //Отдельный label3 для проверки выбран процесс или нет.
                label2.Text = "Текущий процесс:"; //WITHOUT SMART GUARD
                button3.Text = "ОБНОВИТЬ СПИСОК ПРОЦЕССОВ";
            }
        }
        //-----------------------------------------------------------SMART GUARD

        private void RegisterHotkey()
        {
            if (ghk != null) ghk.Unregister();
            /*
             * Modifiers.NoMod;
             * Modifiers.Alt;
             * Modifiers.Ctrl;
             * Modifiers.Shift;
             * Modifiers.Win;
             */
            //there Q button
            var key = (Keys)Enum.Parse(typeof(Keys), "Q");//hotkeyTextBox.Text.ToUpper());
            var mod = Modifiers.Shift; //Modifiers.NoMod;
            try
            {
                ghk = new GlobalHotkey(mod, key, this, true);
            }
            catch (GlobalHotkeyException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //----------------------------------------АПДЕЙТЕР
            if (System.IO.File.Exists(Application.StartupPath + "/ClanChat.exe.bak"))
            {
                string app_name = Application.StartupPath + "\\" + Application.ProductName + ".exe";
                string bat_name = app_name + ".bat";

                string bat = "@echo off\n"
                    + ":loop\n"
                    + "del ClanChat.exe\n"
                    + "if Exist ClanChat.exe GOTO loop\n"
                    //+ "TIMEOUT 2\n"
                    + "ren ClanChat.exe.bak ClanChat.exe\n"
                    //+ "TIMEOUT 1\n"
                    + "start ClanChat.exe\n"
                    //+ "TIMEOUT 3\n"
                    + "del ClanChat.exe.bat\n";

                StreamWriter file = new StreamWriter(bat_name);
                file.Write(bat);
                file.Close();

                Process bat_call = new Process();
                bat_call.StartInfo.FileName = bat_name;
                bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                bat_call.StartInfo.UseShellExecute = true;
                bat_call.Start();
            }
            //----------------------------------------АПДЕЙТЕР

            timer1.Enabled = false; //Выгружаем первый таймер
            timer2.Enabled = false; //Выгружаем второй таймер

            //----------------------------------------ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА
            label4.Text = "Онлайн: " + webpage.DownloadString(UrlDev + "/index.php?action=take");
            timer3.Enabled = false;
            //----------------------------------------ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА

            ghk.Dispose(); //Выгружаем hotkey хук
        }

        //----------------------------------ВЫБИРАЕМ ПРОЦЕСС ИЛИ ОКНО
        private void LoadProcesses()
        {
            comboBox3.Items.Clear();
            Process[] MyProcess = Process.GetProcesses();
            
            if (checkBox3.Checked == true)
            {
                //WITHOUT SMART GUARD
                IntPtr hWnd;
                foreach (Process proc in MyProcess)
                {
                    if ((hWnd = proc.MainWindowHandle) != IntPtr.Zero)
                    {
                        comboBox3.Items.Add(proc.ProcessName);
                    }
                }
            }
            else
            {
                //WITH SMART GUARD
                for (int i = 0; i < MyProcess.Length; i++)
                {
                    comboBox3.Items.Add(MyProcess[i].ProcessName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //----------------------------------------ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА
            label4.Text = "Онлайн: " + webpage.DownloadString(UrlDev + "/users.txt");
            //----------------------------------------ТАЙМЕР ПРОВЕРКИ ОНЛАЙНА
        }

        //Для textBox1 - вывод подсказки
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите текст...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver; //Color.Black
            }
        }
        //Для textBox1 - вывод подсказки
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите текст...";
                textBox1.ForeColor = Color.Silver;
            }
        }
        //----------------------------------ВЫБИРАЕМ ПРОЦЕСС ИЛИ ОКНО
    }
}
