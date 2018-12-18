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

namespace String2_misal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.Font = fontDialog1.Font;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                this.ForeColor = Color.DarkRed;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\new\secondFolder");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Create("C:\\new\\secondFolder\\secondFile.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter writeText = new StreamWriter("C:\\new\\secondFolder\\secondFile.txt");
            writeText.WriteLine("anona is the best in the world . What is sanonas . i dont know");
            writeText.AutoFlush = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader readText = new StreamReader("C:\\new\\secondFolder\\secondFile.txt");
            textBox1.Text=readText.ReadToEnd();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            //Sozlerin arasinda nece dene ilk ve son simvolu eyni olan soz var. 
            string text = textBox1.Text;
            string result = "";
            int count = 0;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if(word.Length > 1 && word.Substring(0, 1) == word.Substring(word.Length - 1))
                    {
                        result += word+"\r\n";
                        count++;
                    }
                    break;
                }
            }
            label3.Text = result;
            label5.Text = count.ToString();

        }
    }
}
