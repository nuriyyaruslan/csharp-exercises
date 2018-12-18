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

namespace string1Misal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eded = textBox1.Text;
            int cem = 0;
            if (eded.Length == 4)
            {
                foreach (char birReqem in eded)
                {
                    if (Char.IsDigit(birReqem))
                    {
                        cem += Convert.ToInt32(birReqem.ToString());
                        label4.Text = cem.ToString();
                    }
                    else
                    {
                        label5.Text = " Diqqet!\n Ədəd daxil edin!";
                    }

                }
            }
            else
            {
                MessageBox.Show("misalin sertine uygun deyil,4 reqemli eded daxil edilmelidir!");
            }

            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
            button1.ForeColor = Color.Red;
            button2.ForeColor = Color.Red;
            button3.ForeColor = Color.Red;
            button4.ForeColor = Color.Red;
            button5.ForeColor = Color.Red;
            button6.ForeColor = Color.Red;
            button6.BackColor = Color.Blue;
            label5.ForeColor = Color.DarkRed;
            label5.BackColor = Color.Orange;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                this.ForeColor = colorDialog1.Color;
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Interaction.InputBox("ədədi daxil edin", "ədədi daxil edin", "ədəd");

        }
    }
}
