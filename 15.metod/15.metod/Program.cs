using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.metod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*15). 3 dene  metod yarat. metod1(a) ,metod2(a) ,metod3(a) 
            (TIPLERINI metodlarin qaytardigi deyishenlere gore ozunuz mueyyen etmelisiniz)
	        metod1 - verilimish metnde en cox rast gelinen simvolu tapib onu secir.     
            metod2 - verilimish metndeki butun sozlerin daxilinde ishtirak eden simvolun olub olmadigini yoxlayir.
            metod3 - verilimish metnde en uzun sozun icersinden UNIKAL simvollari birleshdir.
            Hesabla: Eger metod2 cavabi YES olsa o zaman: metod1 + metod3
            Eger metod2 cavabi NO olsa o zaman: metod2 -in daxilindeki butun metod1 simvolunu legv et.*/
           
           
        }
        public static string metod1(string a)
        {
            string[] herfler = { "a", "b", "c", "ç", "d", "e", "f", "c", "h", "j", "k", "l", "m", "n", "o", "ö", "ə", "q", "p", "s", "ş", "v", "r", "x", "z", "g", "t", "y", "u", "ü", "ı", "ğ" };
            int[] counts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < herfler.Length; j++)
                {
                    for (int m = 0; m < counts.Length; m++)
                    {
                        if (a[i].ToString() == herfler[j].ToString())
                            counts[i]++;
                    }
                }
            }
            
        }


    }
}
