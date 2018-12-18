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

namespace string2_misal3
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
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    //Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            //    // Sozlerin arasindan necesinin daxilinde { a}
            //    //herfi var ve sozun uzunlugu 10 simvoldan coxdur.
            //    string text = textBox1.Text;
            //    int count = 0;
            //    string wordd = "";
            //    string[] words = text.Split(' ');
            //    foreach (string word in words)
            //        try
            //    {
            //        {
            //            if (word.Contains('a') && word.Length > 10)
            //            {
            //                count++;
            //                wordd += word + "\r\n";
            //            }
            //        }
            //        label3.Text = wordd + "\r\n" + "count is " + count.ToString();
            //    }
            //    catch (FormatException ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    finally
            //    {
            //        label4.Text = "exercise is completed successfully";
            //    }





            //Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            //Sozlerin arasidan en uzun sozun I herfi, en qisa sozun I herfine beraberdirmi?

            //    string text = textBox1.Text;
            //    string LongestWord = "";
            //    string ShortestWord = "                  ";
            //    string[] words = text.Split(' ');
            //    for (int i = 0; i < words.Length; i++)
            //    {

            //        if (words[i].Length>LongestWord.Length)
            //        {
            //            LongestWord = words[i];
            //        }
            //        if(words[i].Length<ShortestWord.Length)
            //        { 
            //            ShortestWord = words[i];
            //        }
            //    }
            //    if (LongestWord.Substring(0, 1) == ShortestWord.Substring(0, 1))
            //    {
            //        label3.Text = "beraberdir";
            //    }
            //    else
            //    {
            //        label3.Text = "beraber deyil";
            //    }
            //}





            //Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            //Sozlerin arasindan en UZUN ve en QISA sozu legv et.
            //    string text = textBox1.Text;
            //    string LongestWord = "";
            //    string ShortestWord = "                   ";
            //    string newText = "";
            //    string[] words = text.Split(' ');
            //    for (int i = 0; i < words.Length; i++)
            //    {

            //        if (words[i].Length > LongestWord.Length)
            //        {
            //            LongestWord = words[i];
            //        }
            //        if (words[i].Length < ShortestWord.Length)
            //        {
            //            ShortestWord = words[i];
            //        }
            //    }
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        if(words[i]==LongestWord||words[i]==ShortestWord)
            //           newText+=words[i] = " ";
            //        else
            //           newText += words[i]+" ";
            //    }
            //    label3.Text = newText;
            //    label4.Text = "en uzun soz: " + LongestWord + "\r\n" + "en qisa soz: " + ShortestWord;




            //Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            //Sozlerin sayi eger 6 - den coxdursa o zaman:
            //sag terefden II ve en axirdan III sozlerin yerini deyish.
            //string text = textBox1.Text;
            //string[] words = text.Split(' ');
            //string one = "";
            //string two = "";
            //string newText = "";
            //if (words.Length > 6)
            //{
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        one = words[words.Length - 2];
            //        two = words[words.Length - 3];
            //        if (words[i] == one)
            //            newText += two + " ";
            //        else if(words[i]==two)
            //            newText += one + " ";
            //        else
            //            newText += words[i]+" ";
            //    }
            //}
            //else
            //{
            //    label4.Text = "the count of words should be more than 6";bax
            //}
            //label3.Text = "sagdan 2 ci soz: " + one;
            //label4.Text ="sagdan 3cu soz: "+ two;
            //label5.Text = newText;




            //Verilmish tesadufu metnin muxtelif yerlerinde reqemler var.
            //Bu metnde her bir reqemi yerine ozunun sayi qeder * yaz.
            //string text = textBox1.Text;
            //string newText = "";
            //foreach (char oneSymbol in text)
            //{
            //    if (Char.IsDigit(oneSymbol))
            //        newText += "*";
            //    else
            //        newText += oneSymbol;
            //}       
            //label3.Text = newText;




            //Verilmish tesadufu metnde bir nece yerde {#} isharesi rast gelinir
            //Bu metnde {#} isharesinin qabagindaki simvollari legv et.
            //string text = textBox1.Text;
            //label3.Text = text.Remove(text.LastIndexOf("#"));



            //Verilmish tesadufu metnde bir nece yerde {#} isharesi rast gelinir,
            // Bu metnde butun {#} isharelerinin qabagina metnin son simvolunu at.
            //string text = textBox1.Text;
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == '#')
            //    {
            //        //newText += text.Insert((i),text.Substring(text.Length - 1));
            //    }
            //}
            //label3.Text = newText;

            //the best version to write this program!

            //string text = textBox1.Text;
            //string[] words = text.Split('#');
            //string newText = "";
            //foreach (string word in words)
            //{
            //    newText += text.Substring(text.Length - 1)+"#"+ word.Substring(0);
            //}
            //label3.Text = newText.Substring(2);



            //Verilmish setrde cumleler {.} isharesi ile ayriliblar.
            //Butun noqteden sonra gelen simvollari BOYUK herifle ,
            //yerde qalan simvolari ise hamisini ise KICIK herifle evez edib metni cap et.
            //string text = textBox1.Text;
            //string[] sentences = text.Split('.');
            //string newText = "";
            //foreach (string sentence in sentences)
            //{
            //    newText += '.' + sentence.Substring(0, 1).ToUpper() + sentence.Substring(1).ToLower();
            //}
            //label3.Text = newText.Substring(1);




            //Verilmish setrde muxtelif yerlerde aciq moterize"(" ve bagli moterize ")"  ishareleri rast gelinir.
            //Eger verilmish metnde bu isharelerin sayinin duzgun qoyuldugunu yoxla.
            //Duzgundurse : bu metindeki butun aciq ve bagli moterizelerini fiqurlu moterizelerler "{","}"  ile evez et.
            //Eks halda butun sadece xeberdarliq cixartsin.
            //string text = textBox1.Text;
            //int countOpen = 0;
            //int countClose = 0;
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == '(')
            //        countOpen++;
            //    else if (text[i] == ')')
            //        countClose++;
            //}
            //if (countOpen == countClose)
            //{
            //    foreach(char oneletter in text)
            //    {
            //        if (oneletter == '(')
            //            newText += '{';
            //        else if (oneletter == ')')
            //            newText += '}';
            //        else
            //            newText += oneletter.ToString();
            //    }
            //}
            //else
            //{
            //    label4.Text = "moterizelerin sayi duzgun deyil!";
            //}
            //label3.Text = newText;




            //12)Verilmish metnde sozler probel funsksiyasi ile ayriliblar.
            // Bu cumledeki sozleri TESADUFU qaydada yerlerini deyishdirib qarishdir.
            //string text = textBox1.Text;
            //List<string> sozler = text.Split('-').ToList();
            //List<string> acarlar = new List<string>();
            //int say = text.Split('-').ToList().Count();
            //int sira = 1;
            //Random rn = new Random();
            //while (sira <= say)
            //{
            //    int r = rn.Next(say);
            //    if (!acarlar.Contains(r.ToString()))
            //    {
            //        listBox1.Items.Add(sozler[r]);
            //        acarlar.Add(r.ToString());
            //        sira++;
            //    }
            //}



            //13) Verilmish tesadufu metnde sozler probel funsksiyasi ile ayriliblar. Sozlerin daxilinde 
            //reqemlerde var.Ele sozleri cap et ki:onun daxilindeki reqemlerin komekliyi ile hemin sozun
            //uzunlugunu gosteren ededi duzletmek olsun.

            //string text = textBox1.Text;
            //string[] words = text.Split('-');
            //string reqem = "";
            //foreach (string word in words)
            //{
            //    foreach (char oneLetter in word)
            //    {
            //        if (Char.IsDigit(oneLetter))
            //        {
            //            reqem += oneLetter;
            //            //Random rn = new Random();
            //            //int say = reqem.Length;
            //            //int tesadufiEded = rn.Next(say);
            //            if (Convert.ToInt32(reqem) == word.Length)
            //                listBox1.Items.Add(word);
            //        }

            //    }
            //}



            /*Verilmish setrde sozler probel funsksiyasi ile ayriliblar.
            Butun sozlerin hamisinda ishtirak eden SIMVOL varmi? Eger varsa:
            hemin simvolu ve ondan butun metnde ne qederdirse onun sayini cap et.Eger yoxdursa
            hec bir sozde ishtirak etmeyen 2 dene ayri latin herfi cap et.*/

            //string text = textBox1.Text;
            //string[] words = text.Split('*');
            //int countWords = 0;
            //int countOneSymbol = 0;
            //foreach (string word in words)
            //{
            //    foreach (char oneSymbol in word )
            //    {
            //        if (word.Contains(oneSymbol))
            //        {
            //            countWords++;
            //            if (countWords == words.Length)
            //            {
            //                label3.Text = oneSymbol.ToString();
            //            }
                        
            //        }
                    

            //    }
            //}
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Interaction.InputBox("input your Text", "Input text to carculate", "text");
        }
    
    }
}
