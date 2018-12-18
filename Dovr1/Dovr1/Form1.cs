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

namespace Dovr1
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
            //1).1-1000 qeder ededlerin cemini while operatorunun komekliyi ile cap et.
            //for operatoru ile
            //int cem = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    cem += i;
            //}
            //MessageBox.Show(cem.ToString());

            //while operatoru ile
            //int i = 0;
            //int cem = 0;
            //while( i<1000)
            //{
            //    cem += i;
            //    i++;
            //}
            //MessageBox.Show(cem.ToString());



            //2).1-1000 qeder ededlerin icerisinde  while operatorunun komekliyi ele ededleri cap et ki, reqemleri cemi 11 olsun.

            //for (int i = 10; i < 1000; i++)
            //{
            //    int cem = 0;
            //    foreach (char item in i.ToString())
            //    {
            //        cem += Convert.ToInt32(item.ToString());     
            //    }
            //    if (cem == 11)
            //        listBox1.Items.Add(i);
            //}




            //3). Her hansi bir eded daxil et.
            //Bu ededin daxilde 5 reqemi varmi? (ekrana beli - xeyr cavabini cixart! )
            //string eded = textBox1.Text;
            //foreach (char birReqem in eded)
            //{
            //    if (Char.IsDigit(birReqem))
            //    {
            //        if (eded.Contains('5'))
            //            label3.Text = "beli";
            //        else
            //            label3.Text = "xeyir";
            //    }
            //    else
            //        label3.Text = "eded daxil edilemlidir!";
            //}



            //4).Her hansi bir eded daxil et.
            //Bu ededin daxilde 5 reqemi varsa o zaman ekrana bu ededin reqemleri cemini cixart;
            // Eger 5 reqemi yoxdursa o zaman ekrana bu ededin reqemleri hasilini cixart.
            //string eded = textBox1.Text;
            //int cem= 0;
            //int hasil= 1;
            //foreach (char reqem in eded)
            //{
            //    if (Char.IsDigit(reqem))
            //    {
            //        if (eded.Contains('5'))
            //        {
            //            cem += Convert.ToInt32(reqem.ToString());
            //            label3.Text = cem.ToString();
            //        }
            //        else
            //        {
            //            hasil *= Convert.ToInt32(reqem.ToString());
            //            label3.Text = hasil.ToString();
            //        }
            //    }
            //    else
            //        label3.Text = "reqem daxil edin";         
            //}




            //5).Her hansi bir 10000 den boyuk eded daxil et.
            //Bu ededin daxilde minimum 4 dene 0 varmi?
            //Eger varsa o zaman ekrana bu ededin tek reqemlerin cemini cixart.
            //Eger yoxdursa cut reqemlerin cemini cixart;

            //string eded = textBox1.Text;
            //int cem = 0;
            //int sifirSayi = 0;
            //foreach (char BirReqem in eded)
            //{
            //    if (BirReqem == '0')
            //        sifirSayi++;
            //}
            //for (int i = 0; i < eded.Length; i++)
            //{
            //    if (sifirSayi > 3 && eded[i] % 2 == 1)
            //        cem += Convert.ToInt32(eded[i].ToString());
            //    else if (sifirSayi < 3 && eded[i] % 2 == 0)
            //        cem += Convert.ToInt32(eded[i].ToString());

            //}
            //label3.Text = cem.ToString();




            //6).Her hansi bir eded daxil et. Bu ededin ilk reqemini ededin axirina at.
            //string text = textBox1.Text;
            //label3.Text =text.Remove(0,1) + text.Substring(0,1);


            //7).Her hansi bir eded daxil et.Bu ededin axirinci reqemini evvele at.
            //string text = textBox1.Text;
            //label3.Text = text.Substring(text.Length - 1) + text.Remove(text.Length - 1);



            //8).Her hansi bir eded daxil et. Bu ededin axirinci reqemi ile evvelinci reqeminin yerini deyish.
            //string eded = textBox1.Text;
            //label3.Text = eded.Substring(eded.Length - 1) + eded.Substring(1, eded.Length - 2) + eded.Substring(0, 1);




            //9).Her hansi bir eded daxil et.
            //Eger eded ancaq tek reqemlerden ibaretdirse o zaman ededin daxilindeki butun cut reqemlerin cemini tap.
            //Eks halda butun reqemlerini topla.//misalda yalnisliq var cunki eger eded ancaq tek reqemden ibaret olsa o zaman orda cut reqem olmaz!

            //string eded = textBox1.Text;
            //int cem = 0;
            //for (int i = 0; i < eded.Length; i++)
            //{
            //    if (Convert.ToInt32(eded[i].ToString()) % 2 == 1)
            //        cem += Convert.ToInt32(eded[i].ToString());
            //    else
            //        cem += Convert.ToInt32(eded[i].ToString());

            //}
            //label3.Text = cem.ToString();




            //10).Her hansi bir eded daxil et.Eger eded polindromdursa o zaman bu ededin evveline 
            //ve axirina 1 reqemini artir ve cap et.Eks halda ededin ozunu cap et.
            //string eded = textBox1.Text;
            //string eksEded = "";
            //for (int i = 0; i < eded.Length; i++)
            //{
            //    eksEded += eded[eded.Length - i - 1];
            //}
            //if (eded == eksEded)
            //    label3.Text = "1" + eded + "1";
            //else
            //    label3.Text = eded;




            //11).1-100000 qeder ededlerin icerisinde ele ededleri cap etki:
            //Hem polindrom olsun.Hem reqemleri cemi 11 - den boyuk olsun
            // Hem reqemleri icerisinde 7,0,9 reqemleri olmasin
            // Hemde reqemleri icerisinde hec olmasa bir dene cut eded olsun.

            for (int eded = 0; eded < 100000; eded++)
            {
                int cem = 0;
                string polindrom = "";
                for (int i = 0; i < eded.ToString().Length; i++)
                {
                    polindrom += eded.ToString()[eded.ToString().Length - i - 1];
                    cem += Convert.ToInt32(eded.ToString()[i]);
                }
                if (cem > 11 && polindrom == eded.ToString() && eded.ToString().Contains("7") && eded.ToString().Contains("0") && eded.ToString().Contains("0"))
                    listBox1.Items.Add(eded);
            }


                //12) Her hansi bir 10000 den boyuk eded daxil et.
                //Bu ededin I ve axirinci reqemlerin yerini deyish cap et.
                //Sonra Alinan cavabin solda ve sagdan II reqemlerini legv et ve cap et.
                // Netice 3 - e bolnurmu yoxla? beli ve xeyr cap et
                //string eded = textBox1.Text;
                //string yeniEded1 = "";//ededin axirinci reqemi ile 1 ci reqemini deyisdikden sonra  yeniEded1e yaziriq.
                //string yeniEded2 = "";//sondan ve evvelden 2ci reqemi sildikden sonra yeniEde2 ye yaziriq.
                //if(int.Parse(eded)>10000)
                //{
                //   yeniEded1+= eded.Substring(eded.Length - 1) + eded.Substring(1, eded.Length - 2) + eded.Substring(0, 1);
                //   yeniEded2 += yeniEded1.Substring(0, 1) + yeniEded1.Substring(2, yeniEded1.Length - 4) + yeniEded1.Substring(yeniEded1.Length - 1);
                //    if (int.Parse(yeniEded1) % 3 == 0)
                //        label3.Text = "beli";
                //    else
                //        label3.Text = "xeyir";
                //}
                //label4.Text = yeniEded1 + "(yeniEded1)" + "   " + "(yenieded2)" + yeniEded2;





                //13).Her hansi bir eded daxil et.Bu ededin daxilinden 5 ve 7 reqemlerini legv et.
                //Neticenin I ve Sonuncu reqemlerini deyishib cap et. Alinan cavabin icerisinde 
                //nece dene tek reqem oldugunu yaz.

                //string eded = textBox1.Text;
                //string yeniText = "";
                //string netice = "";
                //int tekReqemSayi = 0;
                //foreach (char reqem in eded)
                //{
                //    if (reqem == '7' || reqem == '5')
                //        yeniText += "";
                //    else
                //        yeniText += reqem.ToString();
                //}
                //netice += yeniText.Substring(yeniText.Length - 1) + yeniText.Substring(1, yeniText.Length - 2) + yeniText.Substring(0, 1);
                //for (int i = 0; i < netice.Length; i++)
                //{
                //    if (Convert.ToInt32(netice[i].ToString()) % 2 == 1)
                //        tekReqemSayi++;

                //}

                //label3.Text = " netice: " + netice + "\r\n" + "Neticede olan tek Reqem sayi= " + tekReqemSayi;




                //14)Her hansi bir eded daxil et.Eger ededin reqemleri artan sira ile duzulubse:
                //O zaman reqemlerin icerisinden MAXIMUM reqemi cap et.
                // Eger azalan sira ile duzulubse: O zaman reqemlerin icerisinden MINIMUM reqemi cap et.
                // Eger ne azalan sira ile, nede artan sira ile duzulubse o zaman: ededin MINIMUM ve MAXIMUM reqemlerin cemini tap.

                //string text = textBox1.Text;
                //int longWord = 0;
                //int shortWord = 0;
                //int sum = 0;
                //for (int i = 0; i < text.Length - 1; i++)
                //{
                //    if (Convert.ToInt32(text[i + 1].ToString()) > Convert.ToInt32(text[i].ToString()))
                //        label3.Text = text.Substring(text.Length - 1);
                //    else if (Convert.ToInt32(text[i + 1].ToString()) < Convert.ToInt32(text[i].ToString()))
                //        label3.Text = text.Substring(text.Length - 1);
                //    //else
                //    //{
                //    //    if(Convert.ToInt32(text[i].ToString())>longWord)
                //    //        longWord = Convert.ToInt32(text[i].ToString());
                //    //    if (Convert.ToInt32(text[i].ToString()) < shortWord)
                //    //        shortWord = Convert.ToInt32(text[i].ToString());
                //    //    label3.Text = (longWord + shortWord).ToString();

                //    //}
                //}








            }
    }
}
