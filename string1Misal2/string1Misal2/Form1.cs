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

namespace string1Misal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Interaction.InputBox("ededi daxil edin", "eded daxil edin", "eded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eded = label4.Text;
            int netice = 0;
            if (eded.Length == 6)
            {
                string sonEded = eded.Substring(0, 3);
                foreach (char birReqem in sonEded)
                {
                    if (Char.IsDigit(birReqem))
                    {
                        netice += Convert.ToInt32(birReqem.ToString());
                    }
                    else
                       label5.Text = " Diqqet! eded daxil edin";
                }
                label5.Text = netice.ToString();
                label3.ForeColor = Color.Blue;
                label3.BackColor = Color.White;
            }
            
            else
               MessageBox.Show("ededin uzunlugu \n 6-ya beraber olmalidir", "Diqqet!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            label5.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.Font = fontDialog1.Font;
        }
    }
}
