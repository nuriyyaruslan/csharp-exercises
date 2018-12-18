using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv_artan_sira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("massivin elementlerini daxil edin");
            int[] ededler = new int[5];
            Console.WriteLine("massivin 1-ci elementini daxil edin");
            ededler[0] = int.Parse(Console.ReadLine());
            ededler[1] = int.Parse(Console.ReadLine());
            ededler[2] = int.Parse(Console.ReadLine());
            ededler[3] = int.Parse(Console.ReadLine());
            ededler[4] = int.Parse(Console.ReadLine());
            int enBoyuk = ededler[1];
            for (int i = 0; i < ededler.Length; i++)
            {
                if (ededler[i] > enBoyuk)
                    enBoyuk = ededler[i];
            }
            ededler.ToString().Remove(enBoyuk);
            Console.WriteLine("**"+enBoyuk);
            Console.WriteLine("massivin qalan elementleri:"+ededler);
            Console.ReadLine();
        }
    }
}
