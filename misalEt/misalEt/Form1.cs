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

namespace misalEt
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
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Interaction.InputBox("input your text", "input text", "text");
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string text = textBox1.Text;
             string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                newText += text[i]+"\r\n";
                listBox1.Items.Add(newText);
            }
            
        }
    }
}
