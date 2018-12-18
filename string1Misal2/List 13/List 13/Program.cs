using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] massiv = new string[5];
            Console.WriteLine("massivini elementlerini daxil edin");
            massiv[0] = Console.ReadLine();
            massiv[1] = Console.ReadLine();
            massiv[2] = Console.ReadLine();
            massiv[3] = Console.ReadLine();
            massiv[4] = Console.ReadLine();
            string newString = "";
            foreach (char item in massiv.ToString())
            {
                if ( Char.IsUpper('a'))
                {
                    newString += item.ToString();
                }
                else
                    Console.WriteLine("yalnisdir");
            }
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
