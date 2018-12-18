using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _10.metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //10).3 dene INTEGER tipli metod yarat. metod1(a), metod2(a), metod3(a)  
            //metod1 a-ededinin reqemlerin cemini tapir. metod2 a - ededinin reqemleri arasinda
            //nece dene 0 oldugnu tapir. metod3 a-ededinin polindrom oldugunu yoxlayir.  Hesabla: 
            //Bu metodlarin komekliyi ile 1 - 500 ele ededleri cap etki reqemleri cemi 9 - dan boyuk olsun,
            // icerisinde 0 reqemi olmasin ve polindrom olsun.
          
            for (int j = 1; j < 500; j++)
            {
                if (metod1(j) > 9 && metod2(j) == 0 && metod3(j))
                    Console.WriteLine(j);          
            }
            Console.ReadLine();
          

        }
        public static int metod1(int a)
        {
            int reqemCem = 0;
            foreach (char reqem in a.ToString())
            {
                reqemCem += Convert.ToInt32(reqem.ToString());
            }
            return reqemCem;
        }
        public static int metod2(int a)
        {
            int countZero = 0;
            foreach (char item in a.ToString())
            {
                if (item == '0')
                    countZero++;
            }
            return countZero;
        }
        public static bool metod3(int a)
        {
            bool pol = true;
            for (int i = 0; i < a.ToString().Length; i++)
            {
                if (a.ToString()[i] != a.ToString()[a.ToString().Length - i - 1])
                    pol = false;
            }
            return pol;
        }
    }
}
