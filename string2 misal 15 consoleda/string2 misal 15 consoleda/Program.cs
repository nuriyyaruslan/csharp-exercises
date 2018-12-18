using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2_misal_15_consoleda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmish setrde muxtelif sayda {/} ishareleri qoyulub. Bu isharelerin sayi melum deyil.
            //Bu metnde {/} ishareleri arasindaki UNIKAL sozleri uzunluguna gore alt alta cap et.
            //evvlece sozleri / e gore ayirib liste atiriq.bize sadece unikal sozler lazim oldugu ucun 1-ci ve axirinci sozu silirik.
            //ve qalan sozleri ekrana cixaririq.
            string text = Console.ReadLine();
            List<string> sozler = text.Split('/').ToList();
            sozler.RemoveAt(sozler.Count - 1);
            sozler.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("butun sozler");
            Console.WriteLine();
            foreach (var item in sozler)
            {
                Console.WriteLine(item);
            }

            List<string> unikal = new List<string>();
            Console.WriteLine();
            Console.WriteLine("unikal sozler");
            Console.WriteLine();
            foreach (var item in sozler)
            {
                if (!unikal.Contains(item))
                {
                    unikal.Add(item);
                    Console.WriteLine(item);
                }
            }
            string temp = "";
            for (int i = 0; i < unikal.Count()-1; i++)
            {
                for (int j = 0; j < unikal.Count(); j++)
                {
                    if(unikal[i].Length<unikal[j].Length)
                    {
                        temp = unikal[i];
                        unikal[i] = unikal[j];
                        unikal[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sirali:");
            Console.WriteLine();
            foreach (var item in unikal)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
