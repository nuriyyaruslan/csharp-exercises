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

namespace string1_14cu_misal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = Interaction.InputBox("1-ci eded", "ededin reqem sayi 6 olmalidir!", "eded1");
            label7.Text = Interaction.InputBox("2-ci eded", "ededin reqem sayi 6 olmalidir!", "eded2");
            label8.Text = Interaction.InputBox("3-ci eded", "ededin reqem sayi 6 olmalidir!", "eded3");
            label9.Text = Interaction.InputBox("4-ci eded", "ededin reqem sayi 7 olmalidir!", "eded2");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = label6.Text;
            string number2 = label7.Text;
            string number3 = label8.Text;
            string number4 = label9.Text;
            string netice1=(((Convert.ToInt32(number1.Substring(0, 3)) + Convert.ToInt32(number2.Substring(0, 3)) + Convert.ToInt32(number3.Substring(0, 3)) +
                Convert.ToInt32(number4.Remove(0, 3))) - (Convert.ToInt32(number4.Substring(0, 1)) * Convert.ToInt32(number4.Substring(1, 1)) *
                Convert.ToInt32(number4.Substring(2, 1)))) * 60 / 100).ToString();
            string netice2 = (Convert.ToInt32(netice1) - Convert.ToInt32(netice1) * 18 / 100).ToString();
            label11.Text = netice2;
        }
    }
}
