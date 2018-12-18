using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text.Length.ToString()); //metnin uzunlugu.xarakter sayi
            // MessageBox.Show(textBox1.Text.ToUpper().ToString()); butun herfleri boyuk edir.
            //toLower eksine kicik edir.
            //StartWith ve EndWith ne ile basliyir ve ne ile bitir onu gosterir.
            //Replace evez etmek.bir xarakteri ve ya sozleri deyisdire bilerik.
            // textBox1.Text = textBox1.Text.Insert(5, "     ");
            ////string name = "Nuriyya";
            ////string surname = "Isgandarova";
            ////textBox1.Text = String.Concat(name, surname);
            //split
            //padright meselen 10 xarakter lazimdi 3 u dolubsa qalanlarinin yerine -qoya bilerik (10,'-').
            //padleft sola doldurmaq ucundur!
            string[] sozler = textBox1.Text.Split(' ');
            MessageBox.Show(sozler.Length.ToString() +  " soz:"+ sozler[2]);

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
