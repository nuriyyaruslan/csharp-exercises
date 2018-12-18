using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5).String tipli List yarat. 
            Icerisini ashagidaki SHERTLERI odeyen.Buraya 60 dene tesadufu metn elemtleri ile doldur:
		    uzunlugu 5 - 30 intervalindan cox olmasin,daxilinde { A},{ B}
			simvollari olsun. { A} larin sayi { B} den cox olsun. { B} simvolu { A} simvolundan qabaq gelsin . { A}
            simvolu { B} simoluna nisbeten sonuncu rast gelinsin */ //hjBnj AkAmkAkB akjAnjjA
            Console.WriteLine("input text");
            string text = Console.ReadLine();
            int countA = 0;
            int countB = 0;
            string[] sentences = text.Split('.');
            List<string> sentencesList = new List<string>();
            sentencesList.AddRange(sentences);
            string result = "";
            for (int i = 0; i < sentencesList.Count; i++)
            {
                foreach (char item in sentencesList[i])
                {
                    if (item == 'A')
                        countA++;
                    else if (item == 'B')
                        countB++;
                }
                if (sentencesList[i].Length > 5 && sentencesList[i].Length < 30 && sentencesList[i].Contains('A') && sentencesList[i].Contains('B') && sentencesList[i].IndexOf('A') > sentencesList[i].IndexOf('B') && countA > countB)
                    result += sentencesList[i] + "\r\n";
                else
                {
                    result += "yalnisdir.o cur cumle yoxdur:";
                    break;
                }        
            }
            Console.WriteLine(String.Format("result:{0} ",result));
            Console.ReadLine();
        }

    }
}
