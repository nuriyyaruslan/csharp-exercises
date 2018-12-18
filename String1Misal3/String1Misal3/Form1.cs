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

 

namespace String1Misal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Interaction.InputBox("eded daxil edin", "eded daxil edin", "eded");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            label4.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
            if (colorDialog2.ShowDialog() == DialogResult.OK)
                this.ForeColor = colorDialog2.Color;
            if (colorDialog3.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog3.Color;
                button2.BackColor = colorDialog3.Color;
                button3.BackColor = colorDialog3.Color;
                button4.BackColor = colorDialog3.Color;
                button5.BackColor = colorDialog3.Color;
                button6.BackColor = colorDialog3.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                this.Font = fontDialog1.Font;

        }

        private void button2_Click(object sender, EventArgs e)
        { //verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi.//
          /* string eded = label2.Text;
           int cem = 0;
           string sonEded = "";
           if (eded.Length == 9)
           {
               sonEded += eded.Substring(3, 3);
               foreach (char birReqem in sonEded)
               {
                   if (Char.IsDigit(birReqem))
                       cem += Convert.ToInt32(birReqem.ToString());
                   else
                       label4.Text = "eded daxil edin";
               }
               label4.Text = cem.ToString();
           }
           else
               MessageBox.Show("ededin reqem sayi\n 9 olmalidir","Diqqet!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); */




            // verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati//
            //string eded = label2.Text;
            //int cem = 0;
            //if (eded.Length == 5)
            //    cem += Convert.ToInt32(eded.Substring(0, 1)) + Convert.ToInt32(eded.Substring(4, 1));
            //else
            //{
            //    MessageBox.Show( "ededin reqem sayi\n 5 olmalidir","Diqqet!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
            //    label4.Text = Math.Pow(cem, 2).ToString();



            //verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.//
            //string eded = label2.Text;
            //string netice = "";
            //if(eded.Length==6)
            //{
            //    netice += eded.Remove(0, 1);
            //    label4.Text = (netice + " ilk reqem sonda ==>"+ eded.Substring(0, 1)).ToString();
            //}
            //else
            // MessageBox.Show("ededin reqem sayi\n 6 olmalidir", "Diqqet!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);



            ////verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et.
            //string number = label2.Text;
            //if(number.Length==8)
            //{
            //    label4.Text = number.Substring(1, 6);
            //}
            //else
            //  MessageBox.Show("ededin reqem sayi\n 8 olmalidir", "Diqqet!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);




            //verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir.
            //1-ci usul:
            //string number = label2.Text;
            //string turnedNumber = "";
            //for (int i = 0; i < number.Length; i++)
            //{ 
            //  turnedNumber+=(number[number.Length - i - 1]).ToString();
            //}
            //label4.Text = 8 + turnedNumber + 8;
            //2-ci usul:
            //string number=label2.Text;
            //Stack numbers = new Stack();
            //numbers.Push(number.Substring(0, 1));
            //numbers.Push(number.Substring(1, 1));
            //numbers.Push(number.Substring(2, 1));
            //numbers.Push(number.Substring(3, 1));
            //label4.Text = 8 + numbers.Pop().ToString() + numbers.Pop().ToString() +
            //numbers.Pop().ToString() + numbers.Pop().ToString() + 8;




            //Verilmis ededin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap.
            //string number = label2.Text;
            //string onePart = ""; //axirdan 3cu reqem
            //string secondPart = "";//axirinci reqem
            //for (int i = 0; i < number.Length; i++)
            //{
            //    onePart = number[number.Length - i - 3].ToString();
            //    break;
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    secondPart = number[number.Length - i - 1].ToString();
            //    break;
            //}
            //label4.Text =(int.Parse(onePart) + int.Parse(secondPart)).ToString();




            //9 reqemli ededin tek yerde dayananlardan bir eded duzlet
            //string number = label2.Text;
            //string resultNumber = "";
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if(i%2==0)
            //    {
            //        resultNumber += number[i].ToString();
            //    }
            //}
            //label4.Text = resultNumber;





            //9 reqemli ededin tek yerde dayananlardan bir eded duzlet, 
            // sonra cut yerde dayanlarinda bir eded duzlet,  sonra onlari topla.
            //riyazi olaraq baxsaq mes 23456 ededinde 2,4,6 reqemleri ededin tek yerde duranlaridir
            //ve proqramda onlara muraciet etmek ucun indexlerine muraciet etmek lazimdir.
            //mes 4 ededi 2-ci indexde yerlesdiyinden biz i%2=0 olaraq qeyd edirik.
            //string eded = label2.Text;
            //string tekEdedler = "";
            //string cutEdedler = "";
            //int cem = 0;
            //for (int i = 0; i < eded.Length; i++)
            //{
            //    if (i % 2 == 0)
            //        tekEdedler += eded[i].ToString(); //tek yerde duran
            //    else if (i % 2 != 0)
            //        cutEdedler += eded[i].ToString(); //cur yerde duran
            //}
            //label4.Text = (Convert.ToInt32(tekEdedler) + Convert.ToInt32(cutEdedler)).ToString();


        }

    }
}
