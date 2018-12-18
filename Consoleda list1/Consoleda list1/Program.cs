using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Consoleda_list1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1).String tipli List yarat. Buraya 20 dene tesadufu formada metnleri doldur.
            //Bu listin tek yerde dayanan elemetlerin icerisinde { A} simvolu olanlari cap et.
            Console.WriteLine("a-ni daxil edin");
            string a = Console.ReadLine();
            Console.WriteLine(Program.metod1(a));
            Console.ReadLine();         
        }
        
       public static string metod1(string a)
        {
            string soz = "";
            string[] cumleler = a.Split('.');
            List<string> cumlelerList = new List<string>();
            cumlelerList.AddRange(cumleler);
            for (int i = 0; i < cumlelerList.Count; i++)
            {
                string[]sozler = cumlelerList[i].Split(' ');
                for (int j = 0; j < sozler.Length; j++)
                {
                    if (j % 2 == 0 && sozler[j].Contains("a"))
                    soz += sozler[j] + "\r\n";
                }
            }
            return soz;
        }
        
    }
}
