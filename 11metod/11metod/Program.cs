using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _11metod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11).3 dene INTEGER tipli metod yarat. metod1(a), metod2(a,b,c), metod3(a,b,c) 
            metod1 - 1 den a -ya kimi olan ededlerin cemini FOR operatorunun komekliyi ile tapir.
            metod2 - a,b,c edelerinin kvadratlari cemindeki 5 reqemlerinin sayini tapir.
            metod3 - a,b,c ededlerinin icerisinden en boyuk olani secib onun reqemleri cemini tapir.
            Hesabla: (metod1 + metod2) * (metod2 - metod3); */
            Console.WriteLine("a-ni daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b-ni daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c-ni daxil edin");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("metod1: a-ya qeder olan ededlerin cemi: "+Program.metod1(a));
            int cem = Program.metod1(a) + Program.metod2(a, b, c);
            Console.WriteLine("metod2: ededinlerin kvlarinin ceminde olan 5 lerin sayi: "+Program.metod2(a,b,c));
            Console.WriteLine("metod3 : ededler arasinda en boyuk olan: "+Program.metod3(a,b,c));    
            int ferq = Program.metod2(a, b, c) - Program.metod3(a, b, c);
            Console.WriteLine(String.Format("metod1 ile 2nin cemi: {0} \r\n metod2 ile metod3 un ferqi: {1}\r\n netice:{2}",cem,ferq,cem*ferq));
            Console.ReadLine();
        }
      public static int metod1(int a)
        {
            int cem = 0;
            for (int i = 1; i < a; i++)
            {
                cem += i;
            }
            return cem;
        }
        public static int metod2(int a, int b, int c)
        {
            int cemKv = 0;
            int countFine = 0;
            cemKv = a * a + b * b + c * c;
            foreach (char item in cemKv.ToString())
            {
                if (item == '5')
                    countFine++;
            }
            return countFine;
        }
       public static int metod3(int a,int b,int c)
        {
            int enBoyuk = a;
            List<int> ededler = new List<int>();
            ededler.Add(a);
            ededler.Add(b);
            ededler.Add(c);
            for (int i = 0; i < ededler.Count; i++)
            {
                if (ededler[i] > enBoyuk)
                    enBoyuk = ededler[i];
            }
            return enBoyuk;
           
        }
    }
}
