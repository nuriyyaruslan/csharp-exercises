using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_1_misal_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            // 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
           //  Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
          //Cavabdan 7 reqemli ededin son 5 reqemini cix. 
         //  Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
        // Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
       // Cavabin axirina 11 artir.
      //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
     //Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label7.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eded1 = textBox1.Text;
            string eded2 = textBox2.Text;
            string eded3 = textBox3.Text;
            string eded4 = textBox4.Text;
            string eded5 = textBox5.Text;
            string ReqemliEded = "";
            //int sonDan2ci =0;
            for (int i = 0; i < eded5.Length; i++)
            {
                if (i % 2 == 0)
                    ReqemliEded += eded5[i];

            }
           string netice1= (((Math.Pow(Convert.ToInt32((Convert.ToInt32(eded1) + Convert.ToInt32(eded2)).ToString().Substring(1, 2)), 2) +
                     Convert.ToInt32(eded1 + eded2)) - Convert.ToInt32(eded5.Remove(0, 2))) + Convert.ToInt32((Convert.ToInt32(eded3) +
                     Convert.ToInt32(eded4)).ToString().Substring(2, 3))).ToString() + 11;
           string netice2 = (int.Parse(netice1) - int.Parse(ReqemliEded)).ToString();
            //for (int i = 0; i < netice2.Length; i++)
            //{
            //    sonDan2ci += netice2[netice2.Length - i - 2];
            //    break;
            //}
            //label7.Text = netice2.Insert(sonDan2ci,88.ToString());
            label7.Text = netice2;
        }
    }
}
