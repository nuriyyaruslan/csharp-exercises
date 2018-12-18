using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace list9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9). String tipli List yarat. 
            Icerisini ashagidaki SHERTLERI odeyen  5 dene tesadufu metn elemtleri ile doldur:
            uzunlugu 5 - 10 intervalindan cox olmasin,daxilinde minimum 3 dene reqem olsun.
            Cehdlerin sayini siyahinin sonunda goster.Bundan sonra LIST -in butun elemtleri arasindan
            rast gelinen reqemleri aralarinda { +}isharesi qoymaqla yanashi cap et
            ve sonra alinan neticenin axirina {=} isharesi qoyub cavabi cap et*/
            Console.WriteLine("1-ci cumleni daxil edin:");
            string cumle1 = Console.ReadLine();
            Console.WriteLine("2-ci cumleni daxil edin");
            string cumle2 = Console.ReadLine();
            Console.WriteLine("3-cu cumleni daxil edin");
            string cumle3 = Console.ReadLine();
            Console.WriteLine("4-cu cumleni daxil edin");
            string cumle4 = Console.ReadLine();
            Console.WriteLine("5-ci cumleni daxil edin");
            string cumle5 = Console.ReadLine();
            List<string> cumleler = new List<string>();
            cumleler.Add(cumle1);
            cumleler.Add(cumle2);
            cumleler.Add(cumle3);
            cumleler.Add(cumle4);
            cumleler.Add(cumle5);
            int sum = 0;
            int countNumber = 0;
            string sumString = "";
            string resultSum = "";
            for (int i = 0; i < cumleler.Count; i++)
            {

                foreach (char item in cumleler[i].ToString())
                {
                    if (Char.IsDigit(item))
                    {
                        sum += Convert.ToInt32(item.ToString());
                        countNumber++;
                        sumString += item.ToString() + "+";
                    }
                }
            }
            if (countNumber>=3 && cumle1.Length>=5)
            resultSum = sumString.Remove(sumString.Length - 1) + "=" + sum.ToString();
            Console.WriteLine(String.Format("Sum: {0} \r\n countNumber: {1}  \r\n resultSum: {2}",sum,countNumber,resultSum));
            Console.ReadLine();      
        }   
    }
    
}
