using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _8_.metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //8).2 dene INTEGER tipli metod yarat. metod1(a,b,c)  ve metod2(a,b,c)  
            // metod1 verilmish ededler arasindan MINIMUM tapir.
            // metod2 verilmish ededler arasindan MAXIMUM tapir. Hesabla: metod1 + metod2
            Console.WriteLine("a-ni daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b-ni daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c-ni daxil edin");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("min : {0} \r\n max : {1} \r\n result:{2}",Program.metod1(a,b,c),Program.metod2(a,b,c), Program.metod1(a, b, c) + Program.metod2(a, b, c)));
            Console.ReadLine();
        }    
        public static int metod1(int a, int b, int c)
        {
            int min = a;
            List<int> list1 = new List<int>();
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] < min)
                    min =list1[i];
            }
            return min;
        }
     public static int metod2(int a,int b,int c)
        {
            int max = a;
            List<int> list2 = new List<int>();
            list2.Add(a);
            list2.Add(b);
            list2.Add(c);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] > max)
                    max = list2[2];
            }
            return max;
        }
    }
}
