using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMVC
{
    
    //проверка гит
    public partial class Form1 : Form
    {
        const int TextBoxesMaxLength = 7;  //макс. размер тексбокса  в символах
        public Form1()
        {
            InitializeComponent();
            HoursTextBox2.MaxLength = TextBoxesMaxLength;
            HoursTextBox1.MaxLength = TextBoxesMaxLength;
            MinutesTextBox1.MaxLength = TextBoxesMaxLength;
            MinutesTextBox2.MaxLength = TextBoxesMaxLength;
            SecondsTextBox1.MaxLength = TextBoxesMaxLength;
            SecondsTextBox2.MaxLength = TextBoxesMaxLength;
        }
        /// <summary>
        /// Подсчет значений и вывод на label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equal_Click(object sender, EventArgs e)
        {
            switch (ActionsWithTime.Text)

            {

                case "+":
                    {
                        MessageBox.Show("Вывод Суммы");
                        break;
                    }
                case "-":
                    {
                        MessageBox.Show("Вывод Разности");
                        break;
                    }
                case "<=>":
                    {
                        MessageBox.Show("Вывод Промежутка");
                        break;
                    }
                case "H":
                    {
                        MessageBox.Show("Вывод времени в часах");
                        break;
                    }
                case "M":
                    {
                        MessageBox.Show("Вывод времени в минутах");
                        break;
                    }
                case "S":
                    {
                        MessageBox.Show("Вывод времени в секундах");
                        break;
                    }
            }
        }

        /// <summary>
        /// Вывод для форматов времени: H/M/S
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionsWithTime_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ActionsWithTime.Text)
            {
                case "H":
                    {
                        MessageBox.Show("Особый вывод для конвертирования в часы");
                        break;
                    }
                case "M":
                    {
                        MessageBox.Show("Особый вывод для конвертирования в минуты");
                        break;
                    }
                case "S":
                    {
                        MessageBox.Show("Особый вывод для конвертирования в секунды");
                        break;
                    }
            }
        }
        /// <summary>
        /// Кнопка смены времени из левых textBox'ов в правые. Для быстрого изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReverseButton_Click(object sender, EventArgs e)
        {
          
            string ToSwipe = string.Empty;
            /*Hours swipe*/
            ToSwipe = HoursTextBox1.Text;
            HoursTextBox1.Text = HoursTextBox2.Text;
            HoursTextBox2.Text = ToSwipe;

            /*Minutes swipe*/
            ToSwipe = MinutesTextBox1.Text;
            MinutesTextBox1.Text = MinutesTextBox2.Text;
            MinutesTextBox2.Text = ToSwipe;

            /*Seconds swipe*/
            ToSwipe = SecondsTextBox1.Text;
            SecondsTextBox1.Text = SecondsTextBox2.Text;
            SecondsTextBox2.Text = ToSwipe;

        }
        /*  События нажатия клавиш. Запрет на !число + возможность нажать backspace*/
        #region KeyPressesEvents
        private void HoursTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void MinutesTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SecondsTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void HoursTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void MinutesTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SecondsTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion  

    }
   
}
/*
 * спросить про почту
 нахождение интервала (1-2) (?если отр) - нельзя
 нахождения суммы (+)
 нахождение разности(-)
 свайп (1=2, 2,1)
 преобразования в тип (час/минута/секунда) (тримим ли ед. времени)

     */