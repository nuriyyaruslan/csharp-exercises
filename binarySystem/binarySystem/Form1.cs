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

namespace binarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binary = "";
            int number = Convert.ToInt32(label5.Text);
            while(number>=1)
            {
                binary += (number % 2).ToString();
                number = number / 2;
            }
            label4.Text = binary;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = " ";
            label4.Text = " ";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.Font = fontDialog1.Font;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = Interaction.InputBox("Add the number", "Add the your number", "number");
        }
    }
}
