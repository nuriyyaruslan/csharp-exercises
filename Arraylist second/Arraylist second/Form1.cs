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

namespace Arraylist_second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            string[] names = { "Nuriyya", "Lemmi", "Cenni", "Con" };
            string[] surnames = { "Re", "Si", "Mi", "Fa" };
            //list.Add("Addam");
            //list.Add(76);
            //names bir basa toplu olaraq listin terkibine daxil etmek ucun 
            list.AddRange(names);
            list.Add("Babi");
            list.Insert(1, "Yann");
            list.Remove("Cenni");
            //hansi siradakini silmek istesek RemoveAtdan istifade edirik.
            list.RemoveAt(2);
            list.RemoveRange(1, 2);
            //necenci indeksden baslasin ve hansi listi elave etsin.
            list.InsertRange(0, surnames);
           // MessageBox.Show(names[1].ToString());
            listBox1.Items.AddRange(names);
            textBox1.Text = list.IndexOf("Cenni").ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
