using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birOlculuMassivler
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
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            label12.Text = "";
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1).Verilmish 1 olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin elemetlerin cemi 11 - e bolunurmu ?
            //string[] numbers = new string[10];
            //numbers[0] = textBox1.Text;
            //numbers[1] = textBox2.Text;
            //numbers[2] = textBox3.Text;
            //numbers[3] = textBox4.Text;
            //numbers[4] = textBox5.Text;
            //numbers[5] = textBox6.Text;
            //numbers[6] = textBox7.Text;
            //numbers[7] = textBox8.Text;
            //numbers[8] = textBox9.Text;
            //numbers[9] = textBox10.Text;
            //int cem = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    cem += int.Parse(numbers[i].ToString());
            //}
            //if (cem % 11 == 0)
            //    label12.Text = "Yes";
            //else
            //    label12.Text = "No";





            //2).Verilmish 1 olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin elemetlerin arasinda necesinin reqemleri cemi 11 - e beraberdir.?
            //string[] numbers = new string[10];
            //numbers[0] = textBox1.Text;
            //numbers[1] = textBox2.Text;
            //numbers[2] = textBox3.Text;
            //numbers[3] = textBox4.Text;
            //numbers[4] = textBox5.Text;
            //numbers[5] = textBox6.Text;
            //numbers[6] = textBox7.Text;
            //numbers[7] = textBox8.Text;
            //numbers[8] = textBox9.Text;
            //numbers[9] = textBox10.Text;
            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int cem = 0;
            //    foreach (char item in numbers[i])
            //    {
            //        cem += int.Parse(item.ToString());
            //    }
            //    if (cem % 11 == 0)
            //    {
            //        listBox1.Items.Add(numbers[i]);
            //        count++;
            //    }          
            //}
            //label12.Text = count.ToString();




            //3). Verilmish 1 olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin elemetlerin arasinda nece element polindromdur ?
            //string[] numbers = new string[10];
            //numbers[0] = textBox1.Text;
            //numbers[1] = textBox2.Text;
            //numbers[2] = textBox3.Text;
            //numbers[3] = textBox4.Text;
            //numbers[4] = textBox5.Text;
            //numbers[5] = textBox6.Text;
            //numbers[6] = textBox7.Text;
            //numbers[7] = textBox8.Text;
            //numbers[8] = textBox9.Text;
            //numbers[9] = textBox10.Text;
            //int countPol = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    string polindrom = "";
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        polindrom += numbers[i][numbers[i].Length - j - 1];
            //    }
            //    if (polindrom == numbers[i])
            //    {
            //        countPol++;
            //        listBox1.Items.Add(numbers[i]);
            //    }         
            //}
            //label12.Text = countPol.ToString();




            //4).Verilmish 1 olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin elemetleri arasindan I reqemi ve sonuncu reqemi eyni olan elemtlerin sayini tap.

            //string[] numbers = new string[5];
            //numbers[0] = textBox1.Text;
            //numbers[1] = textBox2.Text;
            //numbers[2] = textBox3.Text;
            //numbers[3] = textBox4.Text;
            //numbers[4] = textBox5.Text;
            ////numbers[5] = textBox6.Text;
            ////numbers[6] = textBox7.Text;
            ////numbers[7] = textBox8.Text;
            ////numbers[8] = textBox9.Text;
            ////numbers[9] = textBox10.Text;
            //int elementSayi = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i].Substring(0, 1) == numbers[i].Substring(numbers[i].Length - 1))
            //    {
            //        elementSayi++;
            //        listBox1.Items.Add(numbers[i]);
            //    }               
            //}
            //label12.Text = elementSayi.ToString();




            //5).Verilmish 1 olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin elemetleri arasindan: I ve sonuncu reqemi eyni olan,
            // reqemleri cemi 11 olan,reqemleri arasinda 0 olan elementlerin sayini tap.

            //string[] numbers = new string[5];
            //numbers[0] = textBox1.Text;
            //numbers[1] = textBox2.Text;
            //numbers[2] = textBox3.Text;
            //numbers[3] = textBox4.Text;
            //numbers[4] = textBox5.Text;
            //numbers[5] = textBox6.Text;
            //numbers[6] = textBox7.Text;
            //numbers[7] = textBox8.Text;
            //numbers[8] = textBox9.Text;
            //numbers[9] = textBox10.Text;
            //int elementSayi = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    if (numbers[i].Substring(0, 1) == numbers[i].Substring(numbers[i].Length - 1))
            //    {
            //        int cem = 0;
            //        foreach (char item in numbers[i])
            //        {
            //            cem += int.Parse(item.ToString());
            //        }
            //        if (cem == 11 && numbers[i].Contains("0"))
            //        {
            //            elementSayi++;
            //            listBox1.Items.Add(numbers[i]);
            //        }
            //    }
            //}
            //label12.Text = elementSayi.ToString();



            //6).Verilmish 1 olculu massivin elemetleri menfi ve musbet ededlerden ibaretdir.
            // Bu massivin MENFI elemetleri arasindan ele element varmi ki:
            // o element hem polindrom hemde reqemleri arasinda 5 olmasin.
            //Eger varsa cap et.

            //int[] massiv = new int[8];
            //massiv[0] = int.Parse(textBox1.Text);
            //massiv[1] = int.Parse(textBox2.Text);
            //massiv[2] = int.Parse(textBox3.Text);
            //massiv[3] = int.Parse(textBox4.Text);
            //massiv[4] = int.Parse(textBox5.Text);
            //massiv[5] = int.Parse(textBox6.Text);
            //massiv[6] = int.Parse(textBox7.Text);
            //massiv[7] = int.Parse(textBox8.Text);
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    if (int.Parse(massiv[i].ToString()) < 0)
            //    {
            //        bool simmetrik = true;
            //        for (int j = 0; j < massiv[i].ToString().Length / 2; j++)
            //        {
            //            if (massiv[i].ToString()[j] != massiv[i].ToString()[massiv[i].ToString().Length - j - 1])
            //            {
            //                simmetrik = false;
            //                break;
            //            }
            //        }
            //        if (simmetrik = true && !massiv[i].ToString().Contains("5"))
            //            listBox1.Items.Add(massiv[i]);
            //    }              
            //}


            //7). Verilmish 1 olculu massivin elemetleri menfi ve musbet ededlerden ibaretdir.
            // Bu massivin  MENFI elemetlerin sayi MUSBET elemetlerin sayindan coxdursa:
            // o zaman massivin butun MUSBET elemetleri MENFI elemetlerin cemi ile evez et.
            // eks halda butun MENFI elemetleri MUSBET elemetlerin cemi ile evez et.

            //int[] massiv = new int[5];
            //massiv[0] = int.Parse(textBox1.Text);
            //massiv[1] = int.Parse(textBox2.Text);
            //massiv[2] = int.Parse(textBox3.Text);
            //massiv[3] = int.Parse(textBox4.Text);
            //massiv[4] = int.Parse(textBox5.Text);
            //int cemMenfi = 0;
            //int cemMusbet = 0;
            //int sayMenfi = 0;
            //int sayMusbet = 0;
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    if (massiv[i] < 0)
            //    {
            //        sayMenfi++;
            //        cemMenfi += massiv[i];
            //    }
            //    else
            //    {
            //        sayMusbet++;
            //        cemMusbet += massiv[i];
            //    }
            //    if ( cemMenfi > cemMusbet && massiv[i]>0)
            //        listBox1.Items.Add(cemMenfi);
            //     else if (cemMusbet > cemMenfi && massiv[i] < 0)
            //        listBox1.Items.Add(cemMusbet);
            //    else
            //        listBox1.Items.Add(massiv[i]);
            //}

            //8).Verilmish 1 olculu massivin elemetleri menfi ve musbet ededlerden ibaretdir.
            //Bu massivin butun MUSBET elemetlerini ozunun MENFI elementi ile evez et.
            //Hemcinin butun MENFI elementleri icerisinden 5 reqemini legv et.

            //string[] ededler = new string[7];
            //ededler[0] = textBox1.Text;
            //ededler[1] = textBox2.Text;
            //ededler[2] = textBox3.Text;
            //ededler[3] = textBox4.Text;
            //ededler[4] = textBox5.Text;
            //ededler[5] = textBox6.Text;
            //ededler[6] = textBox7.Text;
            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    if (int.Parse(ededler[i]) > 0)
            //        listBox1.Items.Add("-" + ededler[i]);
            //    else
            //        listBox1.Items.Add(ededler[i].Replace("5", ""));
            //}




            //9).Verilmish 1 olculu massivin 10 dene STRING tipli elementden ibaretdir.
            // Bu elemtnlerin daxilinde adam adlari var.
            //Verilmish bu massivin elemtleri arasinda en uzun adam adi hansidirsa,
            //hemin adi TERSINE formada cap et.

            //string[] names = new string[10];
            //names[0] = textBox1.Text;
            //names[1] = textBox2.Text;
            //names[2] = textBox3.Text;
            //names[3] = textBox4.Text;
            //names[4] = textBox5.Text;
            //names[5] = textBox6.Text;
            //names[6] = textBox7.Text;
            //names[7] = textBox8.Text;
            //names[8] = textBox9.Text;
            //names[9] = textBox10.Text;
            //string longWord = "";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Length > longWord.Length)
            //        longWord = names[i];
            //}
            //string newLongWord = "";
            //for (int j = 0; j < longWord.Length; j++)
            //{
            //    newLongWord += longWord[longWord.Length - j - 1];
            //}
            //label12.Text = newLongWord;



            //10).Verilmish 1 olculu massivin 10 dene STRING tipli elementden ibaretdir. 
            // Bu xanalarin daxilinde tesadufu formada doldurulmush metnler var.
            //Verilmish bu massivin elemtleri arasinda I ve Sonuncu elementi eyni olan metnlerin sayini tap.

            //string[] massiv = new string[10];
            //massiv[0] = textBox1.Text;
            //massiv[1] = textBox2.Text;
            //massiv[2] = textBox3.Text;
            //massiv[3] = textBox4.Text;
            //massiv[4] = textBox5.Text;
            //massiv[5] = textBox6.Text;
            //massiv[6] = textBox7.Text;
            //massiv[7] = textBox8.Text;
            //massiv[8] = textBox9.Text;
            //massiv[9] = textBox10.Text;
            //int count = 0;
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    if (massiv[i].Substring(0, 1) == massiv[i].Substring(massiv[i].Length - 1))
            //    {
            //        count++;
            //        listBox1.Items.Add(massiv[i]);
            //    }            
            //}
            //label12.Text = count.ToString();




            //11).Verilmish 1 olculu massivin 10 dene STRING tipli elementden ibaretdir. 
            // Bu xanalarin daxilinde tesadufu formada doldurulmush metnler var.
            // Verilmish bu massivin elemtlerinin hamisinin icerisinde { a} simvolunu legv edib,
            //alinan massivi tezeden cap etmek lazimdir.

            //string[] massiv = new string[10];
            //massiv[0] = textBox1.Text;
            //massiv[1] = textBox2.Text;
            //massiv[2] = textBox3.Text;
            //massiv[3] = textBox4.Text;
            //massiv[4] = textBox5.Text;
            //massiv[5] = textBox6.Text;
            //massiv[6] = textBox7.Text;
            //massiv[7] = textBox8.Text;
            //massiv[8] = textBox9.Text;
            //massiv[9] = textBox10.Text;
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    listBox1.Items.Add(massiv[i].Replace("a", ""));
            //}




            //12).Verilmish 1 olculu massivin 10 dene STRING tipli xanadan ibaretdir. 
            //Bu xanalari yalniz { a},{ b}  ve { c}  simvollarinin komekliyi ile
            //tesadufu elemtlerle doldurmaq lazimdir.Bu elemetlerin arasinda tekrar element olmamalidir!
            //string[] massiv = new string[10];
            //massiv[0] = textBox1.Text;
            //massiv[1] = textBox2.Text;
            //massiv[2] = textBox3.Text;
            //massiv[3] = textBox4.Text;
            //massiv[4] = textBox5.Text;
            //massiv[5] = textBox6.Text;
            //massiv[6] = textBox7.Text;
            //massiv[7] = textBox8.Text;
            //massiv[8] = textBox9.Text;
            //massiv[9] = textBox10.Text;
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    int countA = 0;
            //    int countB = 0;
            //    int countC = 0;
            //    foreach (char item in massiv[i])
            //    {
            //        switch(item)
            //        {
            //            case 'a':
            //                countA++;
            //                break;
            //            case 'b':
            //                countB++;
            //                break;
            //            case 'c':
            //                countC++;
            //                break;
            //        }
            //    }
            //    if (countA == 1 && countB == 1 && countC == 1)
            //        listBox1.Items.Add(massiv[i]);
            //}




            //13).Verilmish 1 olculu massivin 10 dene integer tipli xanadan ibaretdir.
            // Bu xanalari tesadufu elementler ile doldurmaq lazimdir.Amma elemetlerin arasinda tekrarlanma 
            //olmamalidir.! Bu massivin elemtleri arasindan en boyuk elementi tap.
            int[] massiv = new int[5];
            massiv[0] = int.Parse(textBox1.Text);
            massiv[1] = int.Parse(textBox2.Text);
            massiv[2] = int.Parse(textBox3.Text);
            massiv[3] = int.Parse(textBox4.Text);
            massiv[4] = int.Parse(textBox5.Text);
            //massiv[5] = int.Parse(textBox6.Text);
            //massiv[6] = int.Parse(textBox7.Text);
            //massiv[7] = int.Parse(textBox8.Text);
            //massiv[8] = int.Parse(textBox9.Text);
            //massiv[9] = int.Parse(textBox10.Text);
            ////bool candition = true;
            ////for (int i = 0; i < massiv.Length-1; i++)
            ////{
            ////    if (massiv[0] == massiv[i + 1])
            ////    {
            ////        candition = false;
            ////    }
            ////    else
            ////        candition = true;
            ////}
            //en boyuk elementin tapilmasi

           
           
            for (int i = 0; i < massiv.Length-1; i++)
            {
                bool tekrar = true;
                int enBoyuk = 0;

                if (massiv[i]==massiv[i+1])
                {
                    tekrar = false;
                    listBox1.Items.Add(tekrar);
                }
                else
                {
                    tekrar = true;
                    listBox1.Items.Add(tekrar);
                }
                if (massiv[i] > enBoyuk)
                    enBoyuk = massiv[i];
                if (massiv[massiv.Length - i - 1] > enBoyuk)
                {
                    label12.Text = massiv[massiv.Length - i - 1].ToString();
                    break;
                }    
                else
                {
                    label12.Text = enBoyuk.ToString();
                    break;
                }

            }

            //14). Verilmish 1 olculu massivin 10 dene string tipli xanadan ibaretdir. 
            // Bu xanalarin daxilinde tesadufu formada doldurulmush simvol ve reqemlerden ibaret metnler var.
            // Bu xananin elementlerinin her birini daxilindeki reqemlerden bashqa diger simvollar
            //legv edib teze massiv duzelt.
            //string[] texts = new string[5];
            //texts[0] = textBox1.Text;
            //texts[1] = textBox2.Text;
            //texts[2] = textBox3.Text;
            //texts[3] = textBox4.Text;
            //texts[4] = textBox5.Text;
            //for (int i = 0; i < texts.Length; i++)
            //{
            //    string m = "";
            //    foreach (char item in texts[i])
            //    {
            //        if (Char.IsDigit(item))
            //            m += item.ToString();
            //        else
            //            m += "";
            //    }
            //    listBox1.Items.Add(m);
            //}





            //15).a ve b 2 massiv verilib. Her iki massiv integer tiplidir.
            // Bu massivler beraberdirmi?
            //Eger beraberdirse o zaman ikinci massivin elemtleri arasinda max elementinin max reqemini tap.
            //int[] a = new int[5];
            //int[] b = new int[5];
            //a[0] = int.Parse(textBox1.Text);
            //a[1] = int.Parse(textBox2.Text);
            //a[2] = int.Parse(textBox3.Text);
            //a[3] = int.Parse(textBox4.Text);
            //a[4] = int.Parse(textBox5.Text);
            //b[0] = int.Parse(textBox6.Text);
            //b[1]= int.Parse(textBox7.Text);
            //b[2]= int.Parse(textBox8.Text);
            //b[3]= int.Parse(textBox9.Text);
            //b[4]= int.Parse(textBox10.Text);
            //if (a[0]==b[0] && a[1]==b[1] && a[2]==b[2] && a[3]==b[3] &&a[4]==b[4])
            //{
            //    int maxEdedBde = 0;
            //    int maxReqem = 0;
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        if (b[i] > maxEdedBde)
            //            maxEdedBde = b[i];
            //    }
            //    foreach (char item in maxEdedBde.ToString())
            //    {
            //        if (int.Parse(item.ToString()) > maxReqem)
            //            maxReqem = Convert.ToInt32(item.ToString());
            //    }
            //    label12.Text = maxEdedBde + " ==> " + maxReqem;
            //}

        }
    }
}
