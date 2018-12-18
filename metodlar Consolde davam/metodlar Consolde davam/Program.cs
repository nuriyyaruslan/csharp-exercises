using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_Consolde_davam
{
    class Program
    {
        static void Main(string[] args)
        {
            //6). INTEGER tipli  metod(a,b,c,d) yarat. 
            //Bu ededlerin arasindan 7 - e bolunenleri cap etsin(Console.WriteLine metodun icerisinde yaz).
            Console.WriteLine("a-ni daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b-ni daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c-ni daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("d-ni daxil edin");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("7-ye bolunen:"+Program.metod(a,b,c,d));
            Console.ReadLine();
            
            

        }
     public static int metod(int a,int b,int c,int d)
        {
            int bolunur = 0;
            string eded = a.ToString() +","+ b.ToString() +","+ c.ToString() +","+ d.ToString();
            string[] ededler = eded.Split(',');
            foreach (string item in ededler)
            {
                if (int.Parse(item) % 7 == 0)
                    bolunur = int.Parse(item);
            }
            return bolunur;
        }
    }
}
