using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _3.List
{
    class Program
    {
        static void Main(string[] args)
        {
            //3).String tipli List yarat. Buraya 30 dene tesadufu formada metnleri doldur.
            // Bu listin ele elemetlerini cap et ki:  daxilinde { A},{ B}
            // simvollari olsun.{ A} larin sayi { B}  den cox olsun,evvelden yoxlayanda { B}
            //simvolu { A} simvolundan qabaq gelsin,axirdan yoxlayanda { A} simvolu { B}
            //simoluna nisbeten sonuncu rast gelinsin. numune: BBAAA nksnnB kA.
            Console.WriteLine("metni daxil edin");
            string metn = Console.ReadLine();
            string[] cumleler = metn.Split('.');
            List<string> cumlelerListi = new List<string>();
            cumlelerListi.AddRange(cumleler);
            int countA = 0;
            int countB = 0;
            string netice = "";
            for (int i = 0; i < cumlelerListi.Count; i++)
            {
                    foreach (char item in cumlelerListi[i])
                    {
                        if (item == 'A')
                            countA++;
                        else if (item == 'B')
                            countB++;
                    }

                if (cumlelerListi[i].Contains('A') && cumlelerListi[i].Contains('B') && cumlelerListi[i].IndexOf('A') > cumlelerListi[i].IndexOf('B') && cumlelerListi[i].LastIndexOf('A') > cumlelerListi[i].LastIndexOf('B'))
                    netice += cumlelerListi[i] + "\r\n";           
            }
            Console.WriteLine("netice:   "+netice);
            Console.ReadKey();
        }
    }
}
