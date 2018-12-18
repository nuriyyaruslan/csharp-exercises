using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //getNumericValue deyerin reqem olub olmadigini yoxlayir.
            //eger reqemdirse oldugu kimi qayidir,deyilse -1 qaytariri.
            label1.Text = Char.GetNumericValue('3').ToString();
            //ToUpper kicik herfi boyuk herfe cevirir,eger boyukdurse oldugu kimi qalir.
            label2.Text = Char.ToUpper('a').ToString();
            //ToLower boyuk herfe kicik herfe cevirir,eger kicikdirse oldugu kimi qalir.
            label3.Text = Char.ToLower('A').ToString();

            //IsNumber IsLetter IsDigit bunlar true false cavablari qaytarir
            //IsNumber eger daxil edilen deyer reqemdirse o zaman true eks halda false gosterir.
            label4.Text = Char.IsNumber('3').ToString();
            //IsLetter eger herfdirse true deyilse false qaytarir.
            label5.Text = Char.IsLetter('A').ToString();

        }
    }
}
