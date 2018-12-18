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

namespace metn_ve_simvollar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //1)Verilmish metnde {a} simvolun sayi {b} simvolun sayindan nece defe coxdur?
            //string text = textBox1.Text;
            //double countA = 0;
            //double countB = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a')
            //        countA++;
            //    else if (text[i] == 'b')
            //        countB++;
            //}
            // label3.Text = "{a} simvolunun sayi {b} simvolunun sayindan"+"\r\n" + countA / countB + " defe coxdur.";




            //2)Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
            //string text = textBox1.Text;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (i % 2 == 0 && text[i] == 'a')
            //        label3.Text = "It is true";
            //    else
            //        label3.Text = "It is false";
            //}



            //3)Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir?
            //string text = textBox1.Text;
            //int countB = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (i % 2 == 0 && text[i] == 'b')
            //        countB++;
            //}
            //label3.Text = countB.ToString();



            //4)Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
            //string text = textBox1.Text;
            //if (text.IndexOf('a')== 0)
            //    label3.Text = text.IndexOf('a')+"- ne tek ne de cutdur!";
            //else if(text.IndexOf('a')%2!= 0)
            //    label3.Text = text.IndexOf('a')+" - tekdir!";
            //else
            //    label3.Text = text.IndexOf('a') + " - cutdur!";



            //5)Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan  hansi birinci gelir?
            //string text = textBox1.Text;
            //if (text.IndexOf('a') < text.IndexOf('b') && text.IndexOf('a') < text.IndexOf('c'))
            //    label3.Text = "a-1-ci gelir.";
            //else if (text.IndexOf('b') < text.IndexOf('a') && text.IndexOf('b') < text.IndexOf('c'))
            //    label3.Text = "b-1-ci gelir.";
            //else if (text.IndexOf('c') < text.IndexOf('a') && text.IndexOf('c') < text.IndexOf('b'))
            //    label3.Text = "c-1-ci gelir.";
            //switch (text[i])
            //{
            //    case 'a':
            //        label3.Text = "{a}-1-ci gelir.";
            //        break;
            //    case 'b':
            //        label3.Text = "{b}-1-ci gelir.";
            //        break;
            //    case 'c':
            //        label3.Text = "{c}-1-ci gelir";
            //        break;
            //        //default:
            //        //    label3.Text = "metnde a,b e ya c yoxdur";
            //        //    break;
            //}




            //6)Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            //string text = textBox1.Text;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a' && text[i-1]==text[i+1])
            //        label3.Text = "a-nin indeksi==>" + text.IndexOf('a') + " ve şərt doğrudur.";

            //}




            //7)Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?
            //string text = textBox1.Text;
            //if (text.IndexOf('a') < text.IndexOf('b') && text.IndexOf('b') < text.IndexOf('c'))
            //    label3.Text = "dogrudur.";
            //else
            //    label3.Text = "yalnisdir.";




            //8)Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.
            //string text = textBox1.Text;
            //string AdansonrakiSimvol = "";
            //string newText1 = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a')
            //        AdansonrakiSimvol+= text[i + 1].ToString();
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    newText1 += AdansonrakiSimvol;
            //}
            //label3.Text =text.Remove(text.IndexOf('a'))+"a"+ newText1+text.Substring(text.IndexOf(AdansonrakiSimvol));




            //9)Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
            //string text = textBox1.Text;
            //string soz1= text.Substring(0, 3);
            //    string soz2=text.Substring(text.Length - 1) + text.Substring(text.Length - 2,1) + text.Substring(text.Length - 3,1);
            //label3.Text = soz1 + "\r\n" + soz2;
            //if (soz1.Substring(0, 1) == soz2.Substring(0, 1) && soz1.Substring(1, 1) == soz2.Substring(1, 1) && soz1.Substring(2, 1) == soz2.Substring(2, 1))
            //    label3.Text = soz1+" ve "+soz2+" beraberdir ve sert dogrudur";
            //else
            //    label3.Text = "yalnisdir";

            //2-ci usul:
            //burada 2-ci sozu tersine cevire bilerdik amma bunun yerine novbeti usulda soldan bir-bir elementlerini goturduk ve muqayise etdik,cunki zaten muqayise edilecekdi.3-cu usulumuz ne optimaldir.
            //string soz2netice = "";
            //for (int i = 0; i < soz2.Length; i++)
            //{
            //    soz2netice += soz2[soz2.Length-i-1];
            //}

            //3cu usul:
            //string text = textBox1.Text;
            //string soz1 = text.Substring(0, 3);
            //string soz2 = text.Substring(text.Length - 3);

            //if (soz1.Substring(0, 1) == soz2.Substring(2, 1) && soz1.Substring(1, 1) == soz2.Substring(1, 1) && soz1.Substring(2, 1) == soz2.Substring(0, 1))
            //   label3.Text = soz1+" ve "+soz2+"  nin tersi "+"beraberdir ve sert dogrudur";
            //else
            //    label3.Text = "yalnisdir";




            //10)Verilmish metinde butun reqemleri legv et. ve ya hansisa simvolu elave et.
            //string text = textBox1.Text;
            //string newtext = "";
            //foreach (char onlyOne in text)
            //{
            //    if (Char.IsDigit(onlyOne))
            //        //newtext += '*';
            //        newtext += "";
            //    else
            //        newtext += onlyOne;
            //}
            //label3.Text = newtext;



            //11)Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu  ve
            //eyni zamandan butun { b}  simvollarinin qabagina { a} simvolunu yaz.
            //string text = textBox1.Text;
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i].ToString() =="a")
            //        newText += text[i - 1] + "b"+"a";
            //    //newText+= text.Insert(text.IndexOf('a'), "b")+"\r\n";
            //    else if (text[i].ToString() =="b")
            //        newText += text[i - 1] + "a"+"b";
            //    //newText+= text.Insert(text.IndexOf('b'), "a");
            //    else
            //        newText += text[i];
            //}
            //label3.Text = newText;





            //12)Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.
            //string text = textBox1.Text;
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (i == text.IndexOf('a'))
            //        newText += text[i];
            //    else if (i == text.LastIndexOf('a'))
            //        newText += text[i];
            //    else
            //        newText += "*";
            //}
            //label3.Text = newText;




            //13)Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.
            //string text = textBox1.Text;
            //string newtext = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (i % 2 == 0)
            //        newtext += text[i].ToString().ToLower();
            //    else
            //        newtext += text[i].ToString().ToUpper();
            //}
            //label3.Text = newtext;




            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen  simvolun BOYUK formasi ile evez et.

            //string text = textBox1.Text;
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (i % 2 == 0)
            //        newText += text[i + 1].ToString().ToUpper();
            //    else
            //        newText += text[i];
            //}
            //label3.Text = newText;



            /*15)Verilmish metinde ilk ve son simvol eynidirse,ve metn daxilinde yanashi gelen { a}
                 simvolu varsa,ve metn daxilinde { b} simvolu yoxdursa o zaman bu metnde butun { c}
                 simvollari yox et ve neticede alinan metn zerkalni olub olmadigini yoxla.*/

            string text = textBox1.Text;
            string newText = "";
            if (text.Substring(0, 1) == text.Substring(text.Length - 1) && text.Contains("aa") && !text.Contains("b"))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'c')
                        newText += "";
                    else
                        newText += text[i];
                }
            }
            label3.Text = newText;
        

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
    }
}
