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

namespace Arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //burada olan verilenlerobject tipindedir,yeni istenilen tipi daxil ede bilerik.

            // string[] surnames = { "De", "Muni", "Uj", "Oli" };
            string[] names = { "nuriyya", "Ada", "Kafka", "Cem" };
            ArrayList list = new ArrayList();
            list.AddRange(names);
            int elementIndex= list.IndexOf("Ada");
            //MessageBox.Show(elementIndex.ToString());
            //eger yazdigimiz element listede varsa indexsini eks halda ise -1 gonderecek.
            // MessageBox.Show(list.Contains("nuriyya").ToString());
            MessageBox.Show(list.Count.ToString());
            list.Clear();


            // list.Add("csharp");
            // list.Add(34);
            // list.Remove("Kafka");
            //// list.RemoveAt(3);
            // list.Add("Marla");
            // list.Insert(1, "Cenni");
            // list.InsertRange(0, surnames);
            // list.RemoveRange(2, 2);
            // MessageBox.Show(list[0].ToString());


        }
    }
}
