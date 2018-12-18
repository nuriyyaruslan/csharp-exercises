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

namespace _10luq_say_sisteminden_2_liye_cevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int onluq = Convert.ToInt32(textBox1.Text);
            string binary = "";
            while(onluq>=1)
            {
                binary += (onluq % 2).ToString();
                onluq = onluq / 2;
            }
            label3.Text = binary;

        }
    }
}
