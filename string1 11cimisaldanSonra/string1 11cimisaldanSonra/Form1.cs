using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string1_11cimisaldanSonra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label12.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {    // 8 reqemli ededin reqemlerini iki -iki qruplashdir. 
             //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
             //Sonra cavabin ozunden onun 18 % ni cix;

            string number = textBox1.Text;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int cem = 0;
            if(number.Length==8)
            {
                group1 = Convert.ToInt32(number.Substring(0, 2));
                label7.Text = group1.ToString();
                group2 = Convert.ToInt32(number.Substring(2, 2));
                label8.Text = group2.ToString();
                group3 = Convert.ToInt32(number.Substring(4, 2));
                label9.Text = group3.ToString();
                group4 = Convert.ToInt32(number.Substring(6, 2));
                label10.Text = group4.ToString();
                cem += group1 + group2 + group3 + group4;
                label14.Text = cem.ToString();
                label12.Text=(Convert.ToInt32(cem.ToString() + 99) - Convert.ToInt32(cem.ToString() + 99) * 18 / 100).ToString();
            }
            else
            {
                MessageBox.Show("ededin reqemlerinin sayi\n 8 olmalidir", "Diqqet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
