using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2olculu_massiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = ""; textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            textBox8.Clear(); textBox9.Clear(); textBox10.Clear(); textBox11.Clear();
            textBox12.Clear(); textBox13.Clear(); textBox14.Clear(); textBox15.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1).Verilmish 3x3 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin en sag sutunundaki elemetlerin cemini tap.
            //int[,] matrix = new int[3, 3];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //label7.Text = (matrix[0, 2] + matrix[1, 2] + matrix[2, 2]).ToString();




            //2).Verilmish 3x3 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            // Bu massivin butun elemtleri arasinda nece polindrom eded var ?
            //int[,] matrix = new int[3, 3];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //int countPolindrom = 0;
            //for (int row = 0; row < 3; row++)
            //{
            //    bool pol = true;
            //    for (int col = 0; col < 3; col++)
            //    {   //massivin her bir elementini liste elave edirik:
            //        // listBox1.Items.Add(matrix[row, col])
            //        for (int i = 0; i < matrix[row, col].ToString().Length; i++)
            //        {
            //            if (matrix[row, col].ToString()[i] != matrix[row, col].ToString()[matrix[row, col].ToString().Length - i - 1])
            //            {
            //                pol = false;
            //                break;
            //            }
            //            else
            //            {
            //                if (matrix[row, col].ToString().Length > 1)
            //                {
            //                    countPolindrom++;
            //                    listBox1.Items.Add(matrix[row, col]);
            //                }
            //                break;
            //            }
            //        }
            //    }
            //}
            //label7.Text = countPolindrom.ToString();



            //3).Verilmish 3x3 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin sag sutunundaki butun elemetleri 0 ile evez et.
            //int[,] matrix = new int[3, 3];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //label7.Text = matrix[0, 0] + "," + matrix[0, 1] + "," + "0" + "\r\n" + matrix[1, 0] + "," + matrix[1, 1] +","+ "0" + "\r\n" + matrix[2, 0] + "," + matrix[2, 1] +","+ "0";




            //4).Verilmish 3x3 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            //Bu massivin sag sutunundaki butun elemetleri en sol sutunundaki elemetlerle evez et.
            //int[,] matrix = new int[3, 3];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrixin elementlerinin labele sade yolla elave edilmesi:
            // label7.Text = matrix[0, 2] + "," + matrix[0, 1] + "," + matrix[0, 0] + 
            //     "\r\n" + matrix[1, 2] + "," + matrix[1, 1] + "," + matrix[1, 0] + "\r\n"
            //     + matrix[2, 2] + "," + matrix[2, 1] + "," + matrix[2, 0];
            //dovr operatoralarindan istifade edilmekle daxil edilmesi:
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        if (matrix[row, col] == matrix[0, 0])
            //            listBox1.Items.Add(matrix[0, 2]);
            //        else if (matrix[row, col] == matrix[0, 2])
            //            listBox1.Items.Add(matrix[0, 0]);
            //        else if (matrix[row, col] == matrix[1, 0])
            //            listBox1.Items.Add(matrix[1, 2]);
            //        else if (matrix[row, col] == matrix[1, 2])
            //            listBox1.Items.Add(matrix[1, 0]);
            //        else if (matrix[row, col] == matrix[2, 0])
            //            listBox1.Items.Add(matrix[2, 2]);
            //        else if (matrix[row, col] == matrix[2, 2])
            //        listBox1.Items.Add(matrix[2, 0]);
            //        else
            //        listBox1.Items.Add(matrix[row, col]);


            //    }
            //}
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        //coldan sitifade etmekle liste elave edilmesi:
            //        /* if(col==2)
            //         {
            //             listBox1.Items.Add(matrix[row, 0]);
            //         }
            //         else if(col==0)
            //         {
            //             listBox1.Items.Add(matrix[row, 2]);
            //         }
            //         else
            //         {
            //             listBox1.Items.Add(matrix[row, col]);
            //         } */
            //        //eyni qaydani labele tetbiq ede bilerik:
            //        if (col == 2)
            //        {
            //            label7.Text +="|"+matrix[row, 0].ToString();
            //            label7.Text += "\r\n";
            //        }
            //        else if (col == 0)
            //            label7.Text +="|"+ matrix[row, 2].ToString();
            //        else
            //            label7.Text +="|"+ matrix[row, col].ToString();
            //    }
            //}



            //5).Verilmish 3x3 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir.
            // Bu massivin en alt sutunundaki elemetleri en ust sutundaki elemetlerle evez et.
            //int[,] matrix = new int[3, 3];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            ////daha sade hell yoludur,bura da label uzerinde massivin elementlerini yaziriq:
            ///* label7.Text = matrix[2, 0] + "," + matrix[2, 1] + "," + matrix[2, 2] + 
            //     "\r\n" + matrix[1, 0] + "," + matrix[1, 1] + "," + matrix[1, 2] + 
            //     "\r\n" + matrix[0, 0] + "," + matrix[0, 1] + "," + matrix[0, 2]; */

            ////nisbeten murekkeb hell yoludur hansi ki, burada biz listboxa massivin elementlerini daxil edirik:
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        if (row == 0)
            //        {
            //            listBox1.Items.Add("1-ci row un elementi:");
            //            listBox1.Items.Add(matrix[2, col]);
            //        }
            //        else if (row == 2)
            //        {
            //            listBox1.Items.Add("3-ci row un elementi:");
            //            listBox1.Items.Add(matrix[0, col]);                    }
            //        else
            //        {
            //            listBox1.Items.Add("2-ci row un elementi:");
            //            listBox1.Items.Add(matrix[1, col]);
            //        }
            //    }
            //}

            //matrixin elementlerini label da yazsaq o zaman en rahat ve elverisli yol budur:
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        if (row == 0)
            //            label7.Text += "|" + matrix[2, col].ToString();
            //        else if (row == 2)
            //            label7.Text += "|" + matrix[0, col].ToString();
            //        else
            //        {
            //            label7.Text += "|" + matrix[row, col].ToString();
            //            label7.Text += "\n\r";
            //        }
            //    }
            //}





            //6).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu 4 reqemli musbet ededlerden ibaretdir.
            // Bu massivin sag diognalindaki elemtlerin icerisinden necesinin I ve axirinci reqemleri eynidir.
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //label8.Text = matrix[0, 4].ToString() + "." + matrix[1, 3].ToString() + "." + matrix[2, 2].ToString() + "." + matrix[3, 1].ToString() +"."+ matrix[4, 0].ToString();
            //int count = 0;
            //string diagonals = label8.Text;
            //string[] massiv = diagonals.Split('.');
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    if (massiv[i].Length == 4 && massiv[i].Substring(0, 1) == massiv[i].Substring(3, 1))
            //        count++;
            //}
            //label7.Text = count.ToString();




            //7).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu 4 reqemli musbet ededlerden ibaretdir.
            //Bu massiv diognal elementlerinden necesi 0 - a beraberdir. (ortaya dushen elementi tekrar sayma)
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //label8.Text = matrix[0, 4].ToString() + "." + matrix[1, 3].ToString() + "." + matrix[2, 2].ToString() + "." + matrix[3, 1].ToString() + "." + matrix[4, 0].ToString() + "." +
            //    matrix[0, 0].ToString() + "." + matrix[1, 1].ToString() + "." + matrix[3, 3].ToString() + "." + matrix[4, 4].ToString();
            //int count = 0;
            //string diagonals = label8.Text;
            //string[] massiv = diagonals.Split('.');
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    if (massiv[i].Length == 4 && int.Parse(massiv[i].ToString())==0)
            //        count++;
            //}
            //label7.Text = count.ToString();




            //8).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu 4 reqemli musbet ededlerden ibaretdir.
            //Bu massivin her setrindeki 5 - e bolunen elementlerin cemini ayrica cap et.
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //int sum = 0;
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        if ( matrix[row,col].ToString().Length==4 && matrix[row, col] % 5 == 0)
            //        {
            //            listBox1.Items.Add(matrix[row, col]);
            //            sum += matrix[row, col];
            //        }
            //    }
            //}
            //label7.Text = "5-e bolunenlerin cemi: "+"\r\n" + sum.ToString();




            //9).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu 4 reqemli musbet ededlerden ibaretdir.
            //Bu massivin her setrindeki MAX elementi arica cap et.
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //int max0 = 0;
            //int max1 = 0;
            //int max2 = 0;
            //int max3 = 0;
            //int max4 = 0;
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        if (matrix[0, col] > max0)
            //            max0 = matrix[0, col];
            //        else if (matrix[1, col] > max1)
            //            max1 = matrix[1, col];
            //        else if (matrix[2, col] > max2)
            //            max2 = matrix[2, col];
            //        else if (matrix[3, col] > max4)
            //            max4 = matrix[3, col];
            //        else if (matrix[4, col] > max4)
            //            max4 = matrix[4, col];
            //    }
            //}
            //label8.Text = "netice: " + "\r\n" +" max0= "+ max0.ToString()+", max1= "+ max1.ToString()+", max2= " + max2.ToString() +", max3"+ max3.ToString() +" ,max4= "+ max4.ToString();




            //10).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu 4 reqemli musbet ededlerden ibaretdir.
            //Bu massivin DIOGNAL elementlerinden necesi 2 - e bolunur ve eyni zamanda polindromdu ?
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //label8.Text = matrix[0, 4].ToString() + "." + matrix[1, 3].ToString() + "." + matrix[2, 2].ToString() + "." + matrix[3, 1].ToString() + "." + matrix[4, 0].ToString() + "." +
            //    matrix[0, 0].ToString() + "." + matrix[1, 1].ToString() + "." + matrix[3, 3].ToString() + "." + matrix[4, 4].ToString();
            //string diagonals = label8.Text;
            //string[] massiv = diagonals.Split('.');
            //int count = 0;
            //bool polindrom = true;
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    for (int j = 0; j < massiv[i].Length; j++)
            //    {
            //        if (massiv[i].ToString()[j] != massiv[i].ToString()[massiv[i].ToString().Length - j - 1])
            //        {
            //            polindrom = false;
            //            break;
            //        }
            //        else
            //        {
            //            if (massiv[i].Length == 4 && int.Parse(massiv[i].ToString()) % 2 == 0)
            //            {
            //                count++;
            //                listBox1.Items.Add(massiv[i]);
            //                break;
            //            }
            //        }
            //    }
            //}
            //label8.Text = "nece denesi serte uyur? " + polindrom + "==>" + count.ToString();





            //11).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir. 
            // Bu massivin DIOGNAL elemtlerindeki butun ededlerin daxilindeki 5 reqemini legv edib ,
            //  hemin elementi tersine cap et. Alinan massivi cap et.
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //label8.Text = matrix[0, 4].ToString() + "." + matrix[1, 3].ToString() + "." + matrix[2, 2].ToString() + "." + matrix[3, 1].ToString() + "." + matrix[4, 0].ToString() + "." +
            //    matrix[0, 0].ToString() + "." + matrix[1, 1].ToString() + "." + matrix[3, 3].ToString() + "." + matrix[4, 4].ToString();
            //string diagonals = label8.Text;
            //string[] array = diagonals.Split('.');
            //for (int i = 0; i < array.Length; i++)
            //{
            //    foreach (char item in array[i])
            //    {
            //        if (item == '5')
            //        {
            //            string n = array[i].Replace("5", "");
            //            string k = "";
            //            if (n.Length > 1)
            //            {
            //                for (int m = n.Length - 1; m >= 0; m--)
            //                {
            //                    k += n[m];
            //                }
            //            }
            //            listBox1.Items.Add(k);
            //            break;
            //        }
            //    }
            //}




            //12).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir. 
            //Bu massivin perimetr boyu elementlerin cemini tapib cavabi massivin en I elementin yerine yaz.
            // Alinan massivi cap et.
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //int sum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3] + matrix[0, 4]
            //+ matrix[1, 4] + matrix[2, 4] + matrix[3, 4] + matrix[4, 4] + matrix[4, 3] + matrix[4, 2]
            //+ matrix[4, 1] + matrix[4, 0] + matrix[3, 0] + matrix[2, 0] + matrix[1, 0];
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        if (row == 0 && col == 0)
            //            listBox1.Items.Add(sum);
            //        else
            //            listBox1.Items.Add(matrix[row, col]);
            //    }
            //}
            //label8.Text = sum.ToString();




            //13).Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir. 
            // Bu massivin perimetrden kenarda qalan elementlerini cemini tap,
            // Sonra sag diognaldan yuxaridaki paralelde yerleshen elemetlerin cemini tap.
            //Sonra bu 2 alinan cemi bir - birine vurub cavabi yaz.
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //int parametrsSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3] + matrix[0, 4]
            //+ matrix[1, 4] + matrix[2, 4] + matrix[3, 4] + matrix[4, 4] + matrix[4, 3] + matrix[4, 2]
            //+ matrix[4, 1] + matrix[4, 0] + matrix[3, 0] + matrix[2, 0] + matrix[1, 0];
            //int paralelSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3] + matrix[1, 0] +
            //    matrix[1, 1] + matrix[1, 2] + matrix[2, 0] + matrix[2, 1] + matrix[3, 0];
            //label8.Text =paralelSum.ToString()+"*"+parametrsSum.ToString()+"= "+(paralelSum * paralelSum).ToString();




            //14). Verilmish 5x5 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir. 
            //Bu massivin butun elementleri arasindan minimum elementi tap,
            //hemin elementi hemin setrin max elementinin maksimum reqemi ile evez et
            //int[,] matrix = new int[5, 5];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[0, 3] = int.Parse(textBox4.Text);
            //matrix[0, 4] = int.Parse(textBox5.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[1, 3] = int.Parse(textBox9.Text);
            //matrix[1, 4] = int.Parse(textBox10.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //matrix[2, 3] = int.Parse(textBox14.Text);
            //matrix[2, 4] = int.Parse(textBox15.Text);
            //matrix[3, 0] = int.Parse(textBox16.Text);
            //matrix[3, 1] = int.Parse(textBox17.Text);
            //matrix[3, 2] = int.Parse(textBox18.Text);
            //matrix[3, 3] = int.Parse(textBox19.Text);
            //matrix[3, 4] = int.Parse(textBox20.Text);
            //matrix[4, 0] = int.Parse(textBox21.Text);
            //matrix[4, 1] = int.Parse(textBox22.Text);
            //matrix[4, 2] = int.Parse(textBox23.Text);
            //matrix[4, 3] = int.Parse(textBox24.Text);
            //matrix[4, 4] = int.Parse(textBox25.Text);
            //int min = matrix[0, 0];
            //int max = 0;
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        if (matrix[row, col] < min)
            //            min = matrix[row, col];
            //        if (matrix[row, col] > max)
            //            max = matrix[row, col];
            //    }
            //}
            //int maxMax = 0;
            //string newMax = "";
            //foreach (char item in max.ToString())
            //{
            //    if (int.Parse(item.ToString()) > maxMax)
            //    {
            //        maxMax = int.Parse(item.ToString());
            //}
            //    foreach (char item1 in max.ToString())
            //    {
            //            if (int.Parse(item.ToString()) == maxMax)
            //        {
            //            newMax += min.ToString();
            //            break;
            //        }      
            //            else
            //        {
            //            newMax += item.ToString();
            //            break;
            //        }
            //    }
            //}
            //label8.Text = max + "(<==max,min==>)" + min;
            //label7.Text = newMax;




            //15). Verilmish 3x3 formatinda cox olculu massivin elemetleri tesadufu musbet ededlerden ibaretdir. 
            //Bu massivinin ele elemetlerini tap ki,
            // o setrin MAKSIMUM ve eyni zamanda oldugu sutun MINIMUM elementi olsun.
            //int[,] matrix = new int[3, 3];
            //matrix[0, 0] = int.Parse(textBox1.Text);
            //matrix[0, 1] = int.Parse(textBox2.Text);
            //matrix[0, 2] = int.Parse(textBox3.Text);
            //matrix[1, 0] = int.Parse(textBox6.Text);
            //matrix[1, 1] = int.Parse(textBox7.Text);
            //matrix[1, 2] = int.Parse(textBox8.Text);
            //matrix[2, 0] = int.Parse(textBox11.Text);
            //matrix[2, 1] = int.Parse(textBox12.Text);
            //matrix[2, 2] = int.Parse(textBox13.Text);
            //int maxSetir = 0;
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        if (matrix[0, col] > maxSetir )
            //        {
            //            maxSetir = matrix[0, col];
            //            if (matrix[1, 2] > maxSetir && matrix[2, 2] > maxSetir)
            //                label8.Text = maxSetir.ToString();
            //        }         
            //    }
            //}    
        }
    }
}