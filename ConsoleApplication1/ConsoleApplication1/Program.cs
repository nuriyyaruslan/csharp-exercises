using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // he bu qeder bitdi?hee :D


            /*
             deme evvelce 7 /
             7%2=1
             7/2=3
             ikiklik(1)
             3%2=1
             3/2=1
             iklik=1+1= '11'
             1%2=1
             1/2=0.5
             0.5<1 dovrden cixi
             ikilik= 11+1= '111' 
            
             *  */
            int onluq = Convert.ToInt32(Console.ReadLine());
            string ikilik = "";
            int step = 0;
            Console.WriteLine(" step : "+step.ToString());
            Console.WriteLine("Ilk eded : " + onluq.ToString());
            Console.WriteLine("Ilk ilk 2lik : " +ikilik);
            while (onluq>=1)
            {
                step++;
                ikilik+= (onluq % 2).ToString();
                onluq = onluq / 2;
                Console.WriteLine(" step : " + step.ToString());
                Console.WriteLine("Bolunen eded : " + onluq.ToString());
                Console.WriteLine("qaliqda qalan : " + (onluq % 2).ToString());
            }
            Console.WriteLine(ikilik);
            Console.ReadKey();
        }
    }
}
