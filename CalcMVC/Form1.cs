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
    
   
    public partial class Form1 : Form
    {
        Time FirstTimePeriod;
        Time SecondTimePeriod;
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
            Equal.Enabled = false;
        }
        /// <summary>
        /// Подсчет значений и вывод на label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equal_Click(object sender, EventArgs e)
        {
            
            /*Обработчик работы с неверным форматом - для пользователя который захочет вставить строку из буфера*/
            try
            {
              FirstTimePeriod= new Time(Convert.ToInt32(HoursTextBox1.Text), Convert.ToInt32(MinutesTextBox1.Text), Convert.ToInt32(SecondsTextBox1.Text));
               SecondTimePeriod  = new Time(Convert.ToInt32(HoursTextBox2.Text), Convert.ToInt32(MinutesTextBox2.Text), Convert.ToInt32(SecondsTextBox2.Text));
            }
            catch (Exception ex)
            {
                int a;
                HoursTextBox1.Text = Int32.TryParse(HoursTextBox1.Text, out  a) == true ? HoursTextBox1.Text : "0";
                MinutesTextBox1.Text = Int32.TryParse(MinutesTextBox1.Text, out  a) == true ? MinutesTextBox1.Text : "0";
                SecondsTextBox1.Text = Int32.TryParse(SecondsTextBox1.Text, out  a) == true ? SecondsTextBox1.Text : "0";

                HoursTextBox2.Text = Int32.TryParse(HoursTextBox2.Text, out  a) == true ? HoursTextBox2.Text : "0";
                MinutesTextBox2.Text = Int32.TryParse(MinutesTextBox2.Text, out  a) == true ? MinutesTextBox2.Text : "0";
                SecondsTextBox2.Text = Int32.TryParse(SecondsTextBox2.Text, out  a) == true ? SecondsTextBox2.Text : "0";
                FirstTimePeriod = new Time(Convert.ToInt32(HoursTextBox1.Text), Convert.ToInt32(MinutesTextBox1.Text), Convert.ToInt32(SecondsTextBox1.Text));
                SecondTimePeriod = new Time(Convert.ToInt32(HoursTextBox2.Text), Convert.ToInt32(MinutesTextBox2.Text), Convert.ToInt32(SecondsTextBox2.Text));

               
            }
            /*Конец обработчика форматов*/


            
            Answer.Text = "Ответ выведен справа";
            switch (ActionsWithTime.Text)

            {
                    
                case "+":
                    {
                        Time sum = TimeCalc.Sum(FirstTimePeriod, SecondTimePeriod);
                        Answer.Text= sum.ToString();
                        Logger.Log("+", FirstTimePeriod, SecondTimePeriod, sum);
                        break;
                    }
                case "-":
                    {
                        Time sub = TimeCalc.Sub(FirstTimePeriod, SecondTimePeriod);
                        if (sub.Hours < 0)
                        {
                            Answer.Text = @"Невозможно вычислить";
                            Logger.Log("-", FirstTimePeriod, SecondTimePeriod, @"Невозможно вычислить");
                        }
                        else
                        {
                            Answer.Text = sub.ToString();
                            Logger.Log("-", FirstTimePeriod, SecondTimePeriod, sub);
                        }

                        // MessageBox.Show("Вывод Разности");
                        break;
                    }
                case "<=>":
                    {
                        Time interval = TimeCalc.GetInterval(FirstTimePeriod, SecondTimePeriod);
                        if (interval.Hours < 0)
                        {
                            Answer.Text = @"Невозможно вычислить";
                            Logger.Log("<=>", FirstTimePeriod, SecondTimePeriod, @"Невозможно вычислить");
                        }
                        else
                        {
                            Answer.Text = interval.ToString();
                            Logger.Log("<=>", FirstTimePeriod, SecondTimePeriod, interval);
                        }

                        //MessageBox.Show("Вывод Промежутка");
                        break;
                    }
                case "H":
                    {

                        MinutesTextBox2.Text = string.Empty;
                        SecondsTextBox2.Text = string.Empty;
                        int hours = TimeCalc.ToHours(FirstTimePeriod);
                        HoursTextBox2.Text = hours.ToString();

                        Logger.Log("ToHours", FirstTimePeriod, hours);
                        // MessageBox.Show("Вывод времени в часах");
                        break;
                    }
                case "M":
                    {
                        HoursTextBox2.Text = string.Empty;
                        SecondsTextBox2.Text = string.Empty;
                        int minutes = TimeCalc.ToMinutes(FirstTimePeriod);
                        MinutesTextBox2.Text = minutes.ToString();

                        Logger.Log("ToMinutes", FirstTimePeriod, minutes);
                        //  MessageBox.Show("Вывод времени в минутах");
                        break;
                    }
                case "S":
                    {
                        MinutesTextBox2.Text = string.Empty;
                        HoursTextBox2.Text = string.Empty;
                        int seconds = TimeCalc.ToSeconds(FirstTimePeriod);
                        SecondsTextBox2.Text = seconds.ToString();

                        Logger.Log("ToSeconds", FirstTimePeriod, seconds);
                        // MessageBox.Show("Вывод времени в секундах");
                        break;
                    }
                default:
                    {
                        ActionsWithTime.Text = "+";
                        Time sum = TimeCalc.Sum(FirstTimePeriod, SecondTimePeriod);
                        Answer.Text = sum.ToString();
                        Logger.Log("+", FirstTimePeriod, SecondTimePeriod, sum);
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
            if (ActionsWithTime.Text == string.Empty) Equal.Enabled = false;
            else Equal.Enabled = true;
            MakeAllTextBoxEnabled();
            switch (ActionsWithTime.Text)
            {
                case "H":
                    {
                        SecondsTextBox2.Enabled = false;
                        MinutesTextBox2.Enabled = false;
                        break;
                    }
                case "M":
                    {
                        HoursTextBox2.Enabled = false;
                        SecondsTextBox2.Enabled = false;
                        break;
                    }
                case "S":
                    {
                        HoursTextBox2.Enabled = false;
                        MinutesTextBox2.Enabled = false;
                      
                        break;
                    }
               
                    
            }
           
        }
        /// <summary>
        /// Открывает возможность работать со всеми текстбоксами
        /// </summary>
        private void MakeAllTextBoxEnabled()
        {
            HoursTextBox1.Enabled = true;
            HoursTextBox2.Enabled = true;
            SecondsTextBox2.Enabled = true;
            SecondsTextBox1.Enabled = true;
            MinutesTextBox2.Enabled = true;
            MinutesTextBox1.Enabled = true;
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
        /// <summary>
        /// Устанавливает текущее время взятое из данных системы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выставитьТекущееВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoursTextBox1.Text = DateTime.Now.Hour.ToString();
            MinutesTextBox1.Text = DateTime.Now.Minute.ToString();
            SecondsTextBox1.Text = DateTime.Now.Second.ToString();
        }

        private void ActionsWithTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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