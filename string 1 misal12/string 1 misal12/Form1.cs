using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Microsoft.VisualBasic;

namespace string_1_misal12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 2 dene 5 reqemli eded daxil et. 
       // I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
       // Neticenin axirina I ededin en axirinci reqemini artir.


        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = label3.Text;
            string number2 = label4.Text;
            int sum = 0;
            int multiple = 1;
           
            if (number1.Length == 5 && number2.Length == 5)
            {
                foreach (char oneNumber1 in number1)
                {
                    if (Char.IsDigit(oneNumber1))
                        sum += Convert.ToInt32(oneNumber1);
                }
                multiple = int.Parse(number2.Substring(0, 1)) * int.Parse(number2.Substring(1, 1)) *
                    int.Parse(number2.Substring(2, 1)) * int.Parse(number2.Substring(3, 1)) * int.Parse(number2.Substring(4, 1));
                label7.Text = (sum + multiple).ToString() + number1.Substring(4, 1);
            }
            else
                label5.Text = "Opps! you should input 5items on your number!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Interaction.InputBox("input only number", "input first number", "numer1");
            label4.Text = Interaction.InputBox("input only number", "input second number", "number2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label7.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.Font = fontDialog1.Font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }
    }
}
