namespace ClanChat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.comboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.checkBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.comboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(720, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(23, 63);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(742, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 23;
            this.comboBox2.Items.AddRange(new object[] {
            "600 мсек задержка для сообщения (БЫСТРО)",
            "700 мсек задержка для сообщения (БЫСТРО)",
            "800 мсек задержка для сообщения (СРЕДНЕ)",
            "900 мсек задержка для сообщения (СРЕДНЕ)",
            "1000 мсек задержка для сообщения (МЕДЛЕННО)",
            "1500 мсек задержка для сообщения (МЕДЛЕННО)",
            "2000 мсек задержка для сообщения (МЕДЛЕННО)",
            "2500 мсек задержка для сообщения (ОЧЕНЬ МЕДЛЕННО)",
            "2700 мсек задержка для сообщения (ОЧЕНЬ МЕДЛЕННО)",
            "2800 мсек задержка для сообщения (ОЧЕНЬ МЕДЛЕННО)",
            "2900 мсек задержка для сообщения (ОЧЕНЬ МЕДЛЕННО)"});
            this.comboBox2.Location = new System.Drawing.Point(23, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(740, 29);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.UseSelectable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "Общий чат - [_]",
            "Трейд чат - [+]",
            "Пати чат - [#]",
            "Клан чат - [@]",
            "Альянс чат - [$]"});
            this.comboBox1.Location = new System.Drawing.Point(23, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(740, 29);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Подсказка: [ Shift+Q ] - старт / стоп";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(220, 15);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Вкл/Выкл - Время в чат (пати/клан)";
            this.checkBox1.UseSelectable = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(603, 15);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Вкл/Выкл - Легитный анонс в чат (отключает опции задержки сообщений и время в чат" +
    " для пати/клана)";
            this.checkBox2.UseSelectable = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 246);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(387, 15);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Smartguard режим (включать только на серверах с этой защитой)";
            this.checkBox3.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Версия: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Онлайн: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Текущий процесс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "    ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 23;
            this.comboBox3.Location = new System.Drawing.Point(23, 315);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(420, 29);
            this.comboBox3.TabIndex = 24;
            this.comboBox3.UseSelectable = true;
            // 
            // button3
            // 
            this.button3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.button3.Location = new System.Drawing.Point(449, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 46);
            this.button3.TabIndex = 25;
            this.button3.Text = "ОБНОВИТЬ СПИСОК ПРОЦЕССОВ";
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(1, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "ClanChat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(786, 391);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroComboBox comboBox2;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroCheckBox checkBox1;
        private MetroFramework.Controls.MetroCheckBox checkBox2;
        private MetroFramework.Controls.MetroCheckBox checkBox3;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroComboBox comboBox3;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

