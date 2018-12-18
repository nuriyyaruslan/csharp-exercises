using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list15
{
    class Program
    {
        static void Main(string[] args)
        {
            //15)
            Console.WriteLine("input the text");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            List<string> sentencesList = new List<string>();
            sentencesList.AddRange(sentences);
            int tryCount = 0;
            string result = "";
            string netica = "";
            for (int i = 0; i < sentencesList.Count; i++)
            {
                if (sentencesList[i].Length > 5 && sentencesList[i].Contains('A') && sentencesList[i].Contains('B') && sentencesList[i].Contains('a') && sentencesList[i].Contains('b'))
                {
                    for (int j = 0; j < sentencesList[i].Length; j++)
                    {
                       
                    }
                }
                tryCount++;
            }
            Console.WriteLine("bunlardir:"+netica);
            Console.ReadLine();







           
        }
    }
}
