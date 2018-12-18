using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6)String tipli List yarat. 
            //Icerisini ashagidaki SHERTLERI odeyen  60 dene tesadufu metn elemtleri ile doldur:uzunlugu 5 - 30 
            //intervalindan cox olmasin daxilinde { A},{ B} simvollari olsun  { A} ile { B}  simvollari yanashi
            //gelmesinler. { A} simvolunun sayi 3 den cox olsun { B} simvolunun sayi 2 den cox olsun ve
            //yanashi gelmesinler.Cehdlerin sayini siyahinin sonunda goster.	
            Console.WriteLine("input text");
            string text = Console.ReadLine();
            string[] cumleler = text.Split('.');
            int countA = 0;
            int countB = 0;
            string result = "";
            int cehdSayi = 0;
            List<string> cumlelerListi = new List<string>();
            cumlelerListi.AddRange(cumleler);
            for (int i = 0; i < cumlelerListi.Count; i++)
            {
                foreach (char item in cumlelerListi[i])
                {
                    if (item == 'A')
                        countA++;
                    else if (item == 'B')
                        countB++;
                }
                if (cumlelerListi[i].Contains('A') && cumlelerListi[i].Contains('B') && cumlelerListi[i].Length > 5 && cumlelerListi[i].Length < 30 && !cumlelerListi[i].Contains("AB") && !cumlelerListi[i].Contains("BA") && countA > 3 && countB > 2 && !cumlelerListi[i].Contains("AA") && !cumlelerListi[i].Contains("BB"))         
                {
                    result += cumlelerListi[i] + "\r\n";
                    cehdSayi++;
                }
                else
                {
                    result += "yalnisidir";
                    break;
                }
                  
            }
            Console.WriteLine(String.Format("netice: {0} \r\n cehd sayi: {1}",result,cehdSayi));
            Console.ReadLine();








        }
    }
}
