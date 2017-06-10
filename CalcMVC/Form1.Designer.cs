namespace CalcMVC
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
            this.HoursTextBox1 = new System.Windows.Forms.TextBox();
            this.MinutesTextBox1 = new System.Windows.Forms.TextBox();
            this.SecondsTextBox1 = new System.Windows.Forms.TextBox();
            this.HoursLabel1 = new System.Windows.Forms.Label();
            this.MinutesLabel1 = new System.Windows.Forms.Label();
            this.SecondsLabel1 = new System.Windows.Forms.Label();
            this.SecondLabel2 = new System.Windows.Forms.Label();
            this.MinutesLabel2 = new System.Windows.Forms.Label();
            this.HoursLabel2 = new System.Windows.Forms.Label();
            this.SecondsTextBox2 = new System.Windows.Forms.TextBox();
            this.MinutesTextBox2 = new System.Windows.Forms.TextBox();
            this.HoursTextBox2 = new System.Windows.Forms.TextBox();
            this.ActionsWithTime = new System.Windows.Forms.ComboBox();
            this.Equal = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выставитьТекущееВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoursTextBox1
            // 
            this.HoursTextBox1.Location = new System.Drawing.Point(78, 62);
            this.HoursTextBox1.Name = "HoursTextBox1";
            this.HoursTextBox1.Size = new System.Drawing.Size(100, 20);
            this.HoursTextBox1.TabIndex = 0;
            this.HoursTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBox1_KeyPress);
            // 
            // MinutesTextBox1
            // 
            this.MinutesTextBox1.Location = new System.Drawing.Point(78, 105);
            this.MinutesTextBox1.Name = "MinutesTextBox1";
            this.MinutesTextBox1.Size = new System.Drawing.Size(100, 20);
            this.MinutesTextBox1.TabIndex = 1;
            this.MinutesTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBox1_KeyPress);
            // 
            // SecondsTextBox1
            // 
            this.SecondsTextBox1.Location = new System.Drawing.Point(78, 147);
            this.SecondsTextBox1.Name = "SecondsTextBox1";
            this.SecondsTextBox1.Size = new System.Drawing.Size(100, 20);
            this.SecondsTextBox1.TabIndex = 2;
            this.SecondsTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondsTextBox1_KeyPress);
            // 
            // HoursLabel1
            // 
            this.HoursLabel1.AutoSize = true;
            this.HoursLabel1.Location = new System.Drawing.Point(26, 65);
            this.HoursLabel1.Name = "HoursLabel1";
            this.HoursLabel1.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel1.TabIndex = 3;
            this.HoursLabel1.Text = "Часы";
            // 
            // MinutesLabel1
            // 
            this.MinutesLabel1.AutoSize = true;
            this.MinutesLabel1.Location = new System.Drawing.Point(15, 108);
            this.MinutesLabel1.Name = "MinutesLabel1";
            this.MinutesLabel1.Size = new System.Drawing.Size(46, 13);
            this.MinutesLabel1.TabIndex = 4;
            this.MinutesLabel1.Text = "Минуты";
            // 
            // SecondsLabel1
            // 
            this.SecondsLabel1.AutoSize = true;
            this.SecondsLabel1.Location = new System.Drawing.Point(10, 150);
            this.SecondsLabel1.Name = "SecondsLabel1";
            this.SecondsLabel1.Size = new System.Drawing.Size(51, 13);
            this.SecondsLabel1.TabIndex = 5;
            this.SecondsLabel1.Text = "Секунды";
            // 
            // SecondLabel2
            // 
            this.SecondLabel2.AutoSize = true;
            this.SecondLabel2.Location = new System.Drawing.Point(253, 146);
            this.SecondLabel2.Name = "SecondLabel2";
            this.SecondLabel2.Size = new System.Drawing.Size(51, 13);
            this.SecondLabel2.TabIndex = 11;
            this.SecondLabel2.Text = "Секунды";
            // 
            // MinutesLabel2
            // 
            this.MinutesLabel2.AutoSize = true;
            this.MinutesLabel2.Location = new System.Drawing.Point(258, 104);
            this.MinutesLabel2.Name = "MinutesLabel2";
            this.MinutesLabel2.Size = new System.Drawing.Size(46, 13);
            this.MinutesLabel2.TabIndex = 10;
            this.MinutesLabel2.Text = "Минуты";
            // 
            // HoursLabel2
            // 
            this.HoursLabel2.AutoSize = true;
            this.HoursLabel2.Location = new System.Drawing.Point(269, 61);
            this.HoursLabel2.Name = "HoursLabel2";
            this.HoursLabel2.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel2.TabIndex = 9;
            this.HoursLabel2.Text = "Часы";
            // 
            // SecondsTextBox2
            // 
            this.SecondsTextBox2.Location = new System.Drawing.Point(321, 143);
            this.SecondsTextBox2.Name = "SecondsTextBox2";
            this.SecondsTextBox2.Size = new System.Drawing.Size(100, 20);
            this.SecondsTextBox2.TabIndex = 8;
            this.SecondsTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondsTextBox2_KeyPress);
            // 
            // MinutesTextBox2
            // 
            this.MinutesTextBox2.Location = new System.Drawing.Point(321, 101);
            this.MinutesTextBox2.Name = "MinutesTextBox2";
            this.MinutesTextBox2.Size = new System.Drawing.Size(100, 20);
            this.MinutesTextBox2.TabIndex = 7;
            this.MinutesTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBox2_KeyPress);
            // 
            // HoursTextBox2
            // 
            this.HoursTextBox2.Location = new System.Drawing.Point(321, 58);
            this.HoursTextBox2.Name = "HoursTextBox2";
            this.HoursTextBox2.Size = new System.Drawing.Size(100, 20);
            this.HoursTextBox2.TabIndex = 6;
            this.HoursTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBox2_KeyPress);
            // 
            // ActionsWithTime
            // 
            this.ActionsWithTime.FormattingEnabled = true;
            this.ActionsWithTime.Items.AddRange(new object[] {
            "+",
            "-",
            "<=>",
            "H",
            "M",
            "S"});
            this.ActionsWithTime.Location = new System.Drawing.Point(198, 96);
            this.ActionsWithTime.Name = "ActionsWithTime";
            this.ActionsWithTime.Size = new System.Drawing.Size(41, 21);
            this.ActionsWithTime.TabIndex = 12;
            this.ActionsWithTime.SelectedIndexChanged += new System.EventHandler(this.ActionsWithTime_SelectedIndexChanged);
            this.ActionsWithTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ActionsWithTime_KeyPress);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(191, 202);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(55, 23);
            this.Equal.TabIndex = 13;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Answer
            // 
            this.Answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer.Location = new System.Drawing.Point(155, 250);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(133, 13);
            this.Answer.TabIndex = 14;
            this.Answer.Text = "Тут будет выведен ответ";
            this.Answer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(181, 26);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(75, 23);
            this.ReverseButton.TabIndex = 15;
            this.ReverseButton.Text = "Реверс";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выставитьТекущееВремяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выставитьТекущееВремяToolStripMenuItem
            // 
            this.выставитьТекущееВремяToolStripMenuItem.Name = "выставитьТекущееВремяToolStripMenuItem";
            this.выставитьТекущееВремяToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.выставитьТекущееВремяToolStripMenuItem.Text = "Выставить текущее время";
            this.выставитьТекущееВремяToolStripMenuItem.Click += new System.EventHandler(this.выставитьТекущееВремяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 272);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.ActionsWithTime);
            this.Controls.Add(this.SecondLabel2);
            this.Controls.Add(this.MinutesLabel2);
            this.Controls.Add(this.HoursLabel2);
            this.Controls.Add(this.SecondsTextBox2);
            this.Controls.Add(this.MinutesTextBox2);
            this.Controls.Add(this.HoursTextBox2);
            this.Controls.Add(this.SecondsLabel1);
            this.Controls.Add(this.MinutesLabel1);
            this.Controls.Add(this.HoursLabel1);
            this.Controls.Add(this.SecondsTextBox1);
            this.Controls.Add(this.MinutesTextBox1);
            this.Controls.Add(this.HoursTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(459, 310);
            this.MinimumSize = new System.Drawing.Size(459, 310);
            this.Name = "Form1";
            this.Text = "TimeCalculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HoursTextBox1;
        private System.Windows.Forms.TextBox MinutesTextBox1;
        private System.Windows.Forms.TextBox SecondsTextBox1;
        private System.Windows.Forms.Label HoursLabel1;
        private System.Windows.Forms.Label MinutesLabel1;
        private System.Windows.Forms.Label SecondsLabel1;
        private System.Windows.Forms.Label SecondLabel2;
        private System.Windows.Forms.Label MinutesLabel2;
        private System.Windows.Forms.Label HoursLabel2;
        private System.Windows.Forms.TextBox SecondsTextBox2;
        private System.Windows.Forms.TextBox MinutesTextBox2;
        private System.Windows.Forms.TextBox HoursTextBox2;
        private System.Windows.Forms.ComboBox ActionsWithTime;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выставитьТекущееВремяToolStripMenuItem;
    }
}

