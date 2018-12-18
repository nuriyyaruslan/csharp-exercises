using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8 String tipli List yarat. 
               Icerisini ashagidaki SHERTLERI odeyen  60 dene tesadufu metn elemtleri ile doldur:
                             uzunlugu 5-10 intervalindan cox olmasin,
                             daxilinde {A} ve {B} larin say maksimum 8  ve minimum 3 dene olsun,
                       Bundan sonra LIST -in  5,1,2,4  nomreli xanalarinda ki elementleri bir setrde cap et.
                       Elementlerin arasinda vergul isharesi qoy.
                       Eger cap olunan element daxilinde  reqem varsa, cap ederken hemin elementin ilk herfini BOYUK yaz.
                       Cehdlerin sayini siyahinin sonunda goster.  */
            //metnler cox oldugu ucun biz bunlari cumleler uzerinde helle edirik.
            Console.WriteLine("input text:");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            List<string> sentencesList = new List<string>();
            sentencesList.AddRange(sentences);
            int countA = 0;
            int countB = 0;
            string resultText = "";
            for (int i = 0; i < sentencesList.Count; i++)
            {
                foreach (char item in sentencesList[i])
                {
                    if (item == 'A')
                        countA++;
                    else if (item == 'B')
                        countB++;
                }
                resultText = sentencesList[0] +","+ sentencesList[1]+"," + sentencesList[3] +","+ sentencesList[5];
            }
            string[] newMassiv = resultText.Split(',');
            string resultSentence = "";
            for (int m = 0; m < newMassiv.Length; m++)
            {
                foreach (char item in newMassiv[m])
                {
                    if (Char.IsDigit(item))
                    {
                        resultSentence+= newMassiv[m].Substring(0, 1).ToUpper() + newMassiv[m].Substring(newMassiv[m].Length - 1);
                    }
                    else
                        resultSentence += newMassiv[m];
                }
            }
            if(countA<=8 && countA>=3&& countB<=8 && countB>=3)
                Console.WriteLine(String.Format("CountA= {0} \r\n CountB={1} \r\n ResultText: {2}\r\n ResultSentence: {3}",countA,countB,resultText,resultSentence));
            Console.ReadLine();
        }
    }
}
