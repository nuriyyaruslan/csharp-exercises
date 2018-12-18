using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentiq_emeliyyatlari
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
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // verilmish ededin tek ve ya cut eded oldugunu yoxla
            //int eded = int.Parse(textBox1.Text);
            //if (eded % 2 == 0)
            //    label3.Text = "cutdur";
            //else
            //    label3.Text = "tekdir";


            //2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart. 
            //Eks halda  "bolunmur" sozunu cap et.
            //    int eded1 = int.Parse(textBox1.Text);
            //    int eded2 = int.Parse(textBox2.Text);
            //    if (eded1 % eded2 == 0)
            //        label3.Text = "bolunur";
            //    else
            //        label3.Text = "bolunmur";




            //Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana.
            //string eded = textBox1.Text;
            //if (int.Parse(eded.Substring(eded.Length - 1)) == 7)
            //    label3.Text = "dogrudur";
            //else
            //    label3.Text = "yalnisdir";


            // Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana
            //string eded = textBox1.Text;
            //if (eded.Substring(0, 1) == eded.Substring(1, 1))
            //    label3.Text = "beli";
            //else
            //    label3.Text = "xeyir";



            //Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman 
            // hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart. 
            //string number = textBox1.Text;
            //if ((int.Parse(number.Substring(0, 1)) + int.Parse(number.Substring(1, 1))) % 2 == 0)
            //    label3.Text = (Convert.ToInt32(number.Substring(0, 1)) * Convert.ToInt32(number.Substring(1, 1))).ToString();

            //else
            //    label3.Text = "sert odenmir!";




            //Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
            //string number = textBox1.Text;
            //if (Convert.ToInt32(number.Substring(0, 1)) + Convert.ToInt32(number.Substring(2, 1)) == Convert.ToInt32(number.Substring(1, 1)))
            //    label3.Text = "beli";
            //else
            //    label3.Text = "xeyir";



            //Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
            //string number = textBox1.Text;
            //int cem = 0;
            //foreach (char item in number)
            //{
            //    cem += Convert.ToInt32(item.ToString());
            //}
            //if (cem == Math.Pow(Convert.ToInt32(number.Substring(0, 1)), 2))
            //    label3.Text = "Yes";
            //else
            //    label3.Text = "No!";



            //SWITCH operatoru ile yoxla. Verilmish ededdin sonuncu reqemi
            // 1 olarsa - "I gun" sozunu  2 olarsa - "II gun" sozunu
            // ...7 olarsa - "VI gun" sozunu yaz.

            //string number = textBox1.Text;
            //switch (int.Parse(number.Substring(number.Length - 1)))
            //{
            //    case 1:
            //        label3.Text = "1-ci gun";
            //        break;
            //    case 2:
            //        label3.Text = "2-ci gun";
            //        break;
            //    case 3:
            //        label3.Text = "3-cu gun";
            //        break;
            //        //.....
            //    case 7:
            //        label3.Text = "6-cu gun";
            //        break;
            //}




            /*WITCH operatoru ile yoxla. Verilmish ededdin 1 - ile 12 arasinda olugunu yoxla.
            (1 ve 12 ozude daxil olmaq sherti ile) Eger bu eded 1 olarsa - "Yanvar" sozunu
            2 olarsa - "Fevral" sozunu...12 olarsa - "Dekabr" sozunu yaz*/
            //string number = textBox1.Text;
            //if (int.Parse(number) >= 1 && int.Parse(number) <= 12)
            //{
            //    switch (int.Parse(number))
            //    {
            //        case 1:
            //            label3.Text = "january";
            //            break;
            //        case 2:
            //            label3.Text = "february";
            //            break;
            //        //....
            //        case 12:
            //            label3.Text = "december";
            //            break;
            //    }

            //}





            //IF operatoru ile yoxla. 
            //6 dene eded verilib.Bu ededlerden hansi en boyukdur.
            //string[] ededler = new string[6];
            //ededler[0] = textBox1.Text;
            //ededler[1] = textBox2.Text;
            //ededler[2] = textBox3.Text;
            //ededler[3] = textBox4.Text;
            //ededler[4] = textBox4.Text;
            //ededler[5] = textBox5.Text;
            //int enBoyuk = 0;
            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    if (int.Parse(ededler[i]) > enBoyuk)
            //        enBoyuk = int.Parse(ededler[i]);           

            //}
            //label3.Text = enBoyuk.ToString();




            // Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse o zaman
            // bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.Neticenin ustune ortaya dushen 2 reqemini gel. 

            //    string number = textBox1.Text;
            //    string IlkUc = "";
            //    string sonUc = "";
            //    int cemilkuc = 0;
            //    int cemsonuc = 0;
            //    IlkUc = number.Substring(0, 3);
            //    sonUc = number.Remove(0, 3);
            //    foreach (char item1 in IlkUc)
            //    {
            //        cemilkuc += Convert.ToInt32(item1.ToString());
            //    }

            //    foreach (char item2 in sonUc)
            //    {
            //        cemsonuc += Convert.ToInt32(item2.ToString());
            //    }

            //    if (cemilkuc == cemsonuc)
            //        label3.Text = number.Remove(0,2) +number.Substring(0,2);
            //    else
            //        label3.Text = "ilk 3 reqemin cemi son 3 reqemi cemine beraber deyildir!";





            /*Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir. 
            Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
            Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.*/
            //string number = textBox1.Text;
            //string resultNumber = "";
            //string newNumber1 = "";
            //string newNumber2 = "";
            //newNumber1 += "8" + number + "8";
            //newNumber2 += newNumber1.Remove(0, 4) + newNumber1.Substring(0, 4);
            //for (int i = 0; i < newNumber2.Length; i++)
            //{
            //    if (i % 2 == 1)
            //        resultNumber += "0";
            //    else
            //        resultNumber += newNumber2[i].ToString();
            //}
            //label3.Text ="newNumber1 is "+newNumber1+"\r\nnewNumber2 is "+newNumber2+"\r\n"+"resultNumber is "+ resultNumber;




            // Verilmish 7 reqemli eded polindromdursa  o zaman onun daxilinde nece dene 0 reqemi oldugunu tap?
            //string eded = textBox1.Text;
            //string ededinTersi = "";
            //int sifirSayi = 0;
            //for (int i = 0; i < eded.Length; i++)
            //{
            //    ededinTersi += eded[eded.Length - i - 1];
            //}
            //if(eded==ededinTersi)
            //{
            //    foreach (char item in eded)
            //    {
            //          if(item=='0')
            //            sifirSayi++;
            //    }
            //}
            //label3.Text = "ededin tersi: " + ededinTersi + " sifirSayi: " + sifirSayi;



            //Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
            // Bu ededin evvelin 1 reqemini artir.
            //string number = textBox1.Text;
            //if (number.Length <= 8)
            //    label3.Text = "1" + number;
            //else
            //    label3.Text = "ədədin uzunluğu şərtə uygun deyil!";




            //Verilmish 6 reqemli ededde nece unikal reqem var ? ( UNIKAL- Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)
            //string number = textBox1.Text;
            //string eded1 = "";
            //for (int i = 0; i <number.Length-1; i++)
            //{
            //    if (Convert.ToInt32(number[i].ToString())!= Convert.ToInt32(number[i+1].ToString()))
            //        eded1 += number[i] + "\r\n";
            //}
            //label3.Text = eded1;
        }
    }
}
