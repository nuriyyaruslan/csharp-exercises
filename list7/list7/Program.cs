using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String tipli List yarat. 
                 Icerisini ashagidaki SHERTLERI odeyen  60 dene tesadufu metn elemtleri ile doldur:
		         uzunlugu 5-30 intervalindan cox olmasin,
				 daxilinden {A} simvolu olmasin,
				 daxilinde reqem olmasin
				 ilk simvol hansidirsa o simvoldan metnde minimum 4 dene olsun.
		         Cehdlerin sayini siyahinin sonunda goster. 
				 */
            Console.WriteLine("input text");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            List<string> sentencesList = new List<string>();
            sentencesList.AddRange(sentences);
            string firstLetter = "";
            int countFirstLetter = 0;
            string result = "";
            int tryCount = 0;
            for (int i = 0; i < sentencesList.Count; i++)
            {
                firstLetter += sentencesList[i].Substring(0, 1);
                foreach (char item in sentencesList[i])
                {
                    if(!Char.IsDigit(item) && item==Convert.ToChar(firstLetter))
                        countFirstLetter++;
                }
                if (sentencesList[i].Length > 5 && sentencesList[i].Length < 30 && !sentencesList[i].Contains('A') && countFirstLetter >= 4)
                {
                    result += sentencesList[i] + "\r\n";
                    tryCount++;
                }
                else
                {
                   result = "yalnisdir";
                    break;
                }
            }
            Console.WriteLine(String.Format("tryCountL: {0} \r\n result: {1} \r\n firstLetter: {2} \r\n countOfFirstLetter: {3}",tryCount,result,firstLetter,countFirstLetter));
            Console.ReadLine();
            
        }
    }
}
