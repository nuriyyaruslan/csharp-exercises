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

namespace Dovr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1).1-1000 qeder ededlerin cemi 7 bolunurmu?
            //int cem = 0;
            //for (int i = 0; i <1000 ; i++)
            //{
            //    cem += i;
            //}
            //if (cem % 7 == 0)
            //    MessageBox.Show("cem 7-ye tambolunur :)");
            //else
            //    MessageBox.Show("cem 7-ye bolunmur :)");



            //2).1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi:

            //for (int i = 1; i < 1000; i++)
            //{
            //    if (Convert.ToInt32(i.ToString()) % 7 == 0 && Convert.ToInt32(i.ToString()) % 8 == 0)
            //        listBox1.Items.Add(i);
            //}



            //3).1-1000 qeder ededlerin icerisinden  ele ededleri cap et ki, reqemleri cemi 3-e bolunsun.

            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char item in i.ToString())
            //    {
            //        cem += Convert.ToInt32(item.ToString());
            //    }
            //    if (cem % 3 == 0)
            //        listBox1.Items.Add(i);
            //}



            //4).1-1000 qeder ededlerin icerisinden ele ededleri cap etki 
            //reqemleri cemi 3 e bolunsun ve sonuncu reqem 3 olmasin.
            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char item in i.ToString())
            //    {
            //        cem += Convert.ToInt32(item.ToString());
            //    }
            //    if (cem % 3 == 0 && i.ToString().Substring(i.ToString().Length - 1) != "3")
            //    {
            //        listBox1.Items.Add(i);
            //    }

            //}



            //5).1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :hem reqemleri cemi 5 - e bolunsun, 
            // hem de ozu 5 - e bolunsun

            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char item in i.ToString())
            //    {
            //        cem += Convert.ToInt32(item.ToString());
            //    }
            //    if (cem % 3 == 0 && Convert.ToInt32(i.ToString())%5==0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}




            //6).1-1000 qeder ederlerin icerisinden  ele ededleri cap etki : hem ozu cut eded olsun, 
            //hem reqemleri cemi tek eded olsun, hem I reqemi tek eded olsun.

            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char reqem in i.ToString())
            //    {
            //        cem += Convert.ToInt32(reqem.ToString());
            //    }
            //    if (cem % 2 == 1 && Convert.ToInt32(i.ToString()) % 2 == 0 && int.Parse(i.ToString().Substring(0, 1)) % 2 == 1)
            //        listBox1.Items.Add(i);
            //}




            //7).1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //hemin ededin daxilinde 3 reqemi umumiyyetle olmasin.

            //for (int i = 0; i < 1000; i++)
            //{
            //    if (!i.ToString().Contains("3"))
            //        listBox1.Items.Add(i);
            //}




            //8).1-1000 qeder ederlerin icerisinden, daxilinde 3 reqemi olmayib,
            //reqemleri cemi 3 olan en sonuncu eded hansidir ?
            //int eded = 0;
            //for (int i = 10; i < 1000; i++)
            //{ 
            //    int cem = 0;
            //    foreach (char reqem in i.ToString())
            //    {
            //        cem += Convert.ToInt32((reqem.ToString()));
            //    }
            //    if (!i.ToString().Contains("3") && cem == 3)
            //    {
            //        if (int.Parse(i.ToString()) > eded)
            //            eded = int.Parse(i.ToString());

            //    }   
            //}
            //label3.Text = eded.ToString();



            //9). 1-1000 qeder ederlerin icerisinde 
            //11 - e bolunub reqemleri cemi 11 - den boyuk olan 11 - ci eded hansidir?
            //int ededSayi = 0;
            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char reqem in i.ToString())
            //    {
            //        cem += Convert.ToInt32(reqem.ToString());
            //    }
            //    if (Convert.ToInt32(i) % 11 == 0 && cem > 11)
            //    {
            //        ededSayi++;
            //        listBox1.Items.Add(eded +")"+ i);
            //        if (ededSayi == 11)
            //            label3.Text = i.ToString();
            //    }

            //}




            //10).1-1000 qeder CUT ederlerin icerisinde 
            //reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            //int enBoyukEded = 0;
            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char reqem in i.ToString())
            //    {
            //        cem += Convert.ToInt32((reqem.ToString()));
            //    }
            //    if (int.Parse(i.ToString())%2==0 && cem == 6)
            //    {
            //        listBox1.Items.Add(i);
            //        if (int.Parse(i.ToString()) > enBoyukEded)
            //            enBoyukEded = int.Parse(i.ToString());

            //    }
            //}
            //label3.Text = enBoyukEded.ToString();



            /*11).1-1000 qeder ededlerin icerisinden  ele ededleri cap etki :
                  hem polindrom olsun,hem ededin reqemleri daxilinde 3 olmasin
                   hem ededin reqemleri cemi 10 dan boyuk olsun*/

            //for (int eded = 10; eded < 1000; eded++)
            //{
            //    int cem = 0;
            //    string pol = "";
            //    foreach (char reqem in eded.ToString())
            //    {
            //        cem += Convert.ToInt32(eded.ToString());
            //    }
            //    for (int i = 0; i < eded.ToString().Length; i++)
            //    {
            //        pol += eded.ToString()[eded.ToString().Length - i - 1];
            //    }
            //    if (int.Parse(eded.ToString()) == int.Parse(pol) && !eded.ToString().Contains("3") && cem > 10)
            //        listBox1.Items.Add(eded);
            //}




            //butunreqemlerin ve herflerin eyni oldugunu gosteren proqram:
            //string text = textBox1.Text;
            //for (int i = 0; i < text.Length - 1; i++)
            //{
            //    if (text[i] == text[i + 1])
            //        label3.Text = text;
            //    else
            //        label3.Text = "yalnisdir!";
            //}


            /*12).1-100000 qeder ederlerin icerisinden  ele ededleri cap etki : hem butun reqemleri eyni olsun,
               hem reqemleri cemi 5 den boyuk olsun hem reqemleri arasinda 5 reqemi olmasin	 */
            //for (int eded = 10; eded < 10000; eded++)
            //{
            //    bool same = true;
            //    for (int i = 0; i < eded.ToString().Length; i++)
            //    {
            //        if(eded.ToString()[0]!=eded.ToString()[eded.ToString().Length-i-1])
            //        {
            //            same = false;
            //            break;
            //        }
            //    }
            //    int cem = 0;
            //    foreach (char item in eded.ToString())
            //    {
            //        cem += Convert.ToInt32(item.ToString());
            //    }
            //    if (same==true && cem > 5 && !eded.ToString().Contains("5"))
            //        listBox1.Items.Add(eded);
            //}



            //13). 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
            // hem butun reqemleri yalniz tek ededlerden ibaret olsun,polindrom olsun,
            //daxilinde minimum 1 dene 5 reqemi olsun.

            //for (int eded = 0; eded < 10000; eded++)
            //{
            //    string pol = "";
            //    for (int i = 0; i < eded.ToString().Length; i++)
            //    {
            //        pol += eded.ToString()[eded.ToString().Length - i - 1];
            //    }
            //    foreach (char item in eded.ToString())
            //    {
            //        if (Convert.ToInt32(item.ToString()) % 2 == 1 && eded.ToString() == pol && eded.ToString().Contains("5"))
            //            listBox1.Items.Add(eded);

            //    }
            //}




            /*14).1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
            hem ededin ozunun daxilinde minimum 2 dene 5 olsun,
	        hem ededin ozunun daxilinde 2 dene yanashi gelen 1 reqemi olsun
            hem ededin reqemleri cemi 7 - 15 arasinda olsun. hem ededin reqemlerinin daxilinde 6 reqemi olmasin*/

            //for (int eded = 0; eded < 100000; eded++)
            //{
            //    int cem = 0;
            //    int besSayi = 0;
            //    foreach (char reqem in eded.ToString())
            //    {
            //        cem += Convert.ToInt32(reqem.ToString());
            //        if (reqem == '5')
            //            besSayi++;
            //    }
            //    if (cem > 7 && cem < 15 && eded.ToString().Contains("11") && !eded.ToString().Contains("6"))
            //        listBox1.Items.Add(eded);
            //}




            //15).1-10000 qeder ederlerin icerisinden  ele ededleri cap etki :
            // hem sade eded olsun,hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmasin
            // hem ededin reqemleri ceminde 2 reqemi olmasin

            //for (int eded = 2; eded < 10000; eded++)
            //{
            //    int cem = 0;
            //    foreach (char reqem in eded.ToString())
            //    {
            //        cem += int.Parse(reqem.ToString());
            //    }
            //    if (!eded.ToString().Contains("0") && !eded.ToString().Contains("1") && !eded.ToString().Contains("5") &&
            //        !eded.ToString().Contains("7") && !eded.ToString().Contains("9") && !cem.ToString().Contains("2"))
            //        listBox1.Items.Add(eded);
            //    if(!cem.ToString().Contains("2"))
            //    listBox2.Items.Add(cem);
            //}

        }
    }
}
