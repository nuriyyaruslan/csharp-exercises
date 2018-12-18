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


namespace String2_misal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.Font = fontDialog1.Font;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) ;
            this.BackColor = colorDialog1.Color;
            this.ForeColor = Color.DarkBlue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\new\ourFirstTextFolder");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\new\ourFirstTextFolder\myTextFile.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter writeText = new StreamWriter(@"C:\new\ourFirstTextFolder\myTextFile.txt");
            writeText.WriteLine("If you’ve never written a computer program, don’t worry.There is always a first time. In this book we will teach you how to program from scratch. We do not expect any previous knowledge or abilities. All you need is some basic computer literacy and a desire to take up programming. The rest you will learn from the book.");
            writeText.AutoFlush = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader readText=new StreamReader(@"C:\new\ourFirstTextFolder\myTextFile.txt");
            textBox1.Text = readText.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {   //Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            //Sozlerin arasinda en uzun sozu cap et.
            string text = textBox1.Text;
            string largestWord = "";
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > largestWord.Length)
                    largestWord = word;
            }
            label3.Text = largestWord;
        }
    }
}
