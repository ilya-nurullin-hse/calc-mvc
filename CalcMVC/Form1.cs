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
        public Form1()
        {
            InitializeComponent();
        }

        private void Equal_Click(object sender, EventArgs e)
        {

        }

        private void ActionsWithTime_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ActionsWithTime.Text)
            {
                case "+":
                    {
                       
                        break;
                    }
            }
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