using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //9).2 dene INTEGER tipli metod yarat.   metod1(a,b) ve metod2(c,d);   
            // metod1 - a ile b ni toplayib alinan cavabin reqemleri cemini tapir.
            // metod2 - c ile d-ni hasilini icerisindeki 5 reqemlerin sayini tapir. Hesabla: metod1 - metod2
            Console.WriteLine("a-ni daxil edin: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b-ni daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c-ni daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("d-ni daxil edin:");
            int d = int.Parse(Console.ReadLine());
            int result = Program.metod1(a, b) - Program.metod2(c, d);
            Console.WriteLine(String.Format("Reqemlerin cemi:{0} hasilde 5 reqeminin sayi: {1} netice: {2}",Program.metod1(a,b),Program.metod2(c,d),result));
            Console.ReadKey();
        }
        public static int metod1(int a, int b)
        {
            int ededCem = a + b;
            int reqemCem = 0;
            foreach (char reqem in ededCem.ToString())
            {
                reqemCem += Convert.ToInt32(reqem.ToString());
            }
            return reqemCem;
        }
        public static int metod2(int c, int d)
        {
            int reqemHasil = c * d;
            int count5 = 0;
            foreach (char reqem in reqemHasil.ToString())
            {
                if (reqem == '5')
                    count5++;
            }
            return count5;
        }
    }
}
 