using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butun_elementler_bir_birine_beraberdirmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the count of array n:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            bool the_same = true;
            for (int j = 0; j < array.Length/2; j++)
            {
                if (array[0] != array[n - j - 1])
                {
                    the_same = false;
                    break;
                }
            }
            Console.WriteLine(the_same);
            Console.ReadLine();
        }
    }
}
