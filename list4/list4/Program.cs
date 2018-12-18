using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4).String tipli List yarat. Buraya 200 dene tesadufu formada metnler ile doldur.
            // Bu listin ele elemetlerini cap et ki: daxilinde { A},{ B} simvollari olsun { A}
            //ile { B} simvollari yanashi gelmesinler { C},{ D} simvolu olsun amma { E}
            // simvolu olmasin { B}   yanashi gelmesinler.
            //200 metn cox oldugu ucun biz 1 metn ve onun cumleleri uzerinde calisiriq:AACBDA. mkdmm ACDADB
            Console.WriteLine("input text:");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            List<string> sentencesList = new List<string>();
            sentencesList.AddRange(sentences);
            string result = "";
            for (int i = 0; i < sentencesList.Count; i++)
            {
                if (sentencesList[i].Contains('A') && sentencesList[i].Contains('B') && !sentencesList.Contains("AB") && !sentencesList[i].Contains("BA") && sentencesList[i].Contains('C') && sentencesList[i].Contains('D') && !sentencesList[i].Contains('E') && !sentencesList[i].Contains("BB"))
                    result += sentencesList[i] + "\r\n";
            }
            Console.WriteLine(String.Format("Result: {0}",result));
            Console.ReadKey();
        }
    }
}
