using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _7_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //7).INTEGER tipli  metod(a,b,c,d) yarat.
            //Bu ededlerin arasindan en boyuk hansi ededdir onu gostersin.
            Console.WriteLine("a-ni daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b-ni daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c-ni daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("d-ni daxil edin:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("en boyuk eded: "+Program.myMetod(a,b,c,d));
            Console.ReadLine();
        }
        public static int myMetod(int a,int b,int c,int d)
        {
            int bigNumber = 0;
            List<int> numbers = new List<int>();
            numbers.Add(a);
            numbers.Add(b);
            numbers.Add(c);
            numbers.Add(d);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > bigNumber)
                    bigNumber = numbers[i];
            }
            return bigNumber;
        }
    }
}
