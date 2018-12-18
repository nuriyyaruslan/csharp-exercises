using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.metod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*14).4 dene STRING tipli metod yarat. metod1(a) ,metod2(a) ,metod3(a), metod4(a). 
             * a STRING tipli deyishendir.a - nin daxilindeki sozler tek probelle ayriliblar.+
            metod1 - a metninde ilk sozu secir ve onun daxilinde butun { a}  simvollarini temizleyir.+     
            metod2 - a metninde ilk sozun sonuncu simvolunu, son sozun I simvolunu birleshdirir.+
            metod3 - a metninde ilk { a} simvolu ile son { a} simvolu arasinda qalan metni secir.
            metod4 - a metninde ilk { a} simvolu ile son { a} simvolu arasinda qalan metn arasindan
            ilk { b} simvoluna ile son { b} simvolu arasinda qalan metni secir.
            Hesabla:metod1 + metod2 + metod3 + metod3 */
            Console.WriteLine("a metnini daxil edin:");
            string a = Console.ReadLine();
            Console.WriteLine(Program.metod1(a));
            Console.WriteLine(Program.metod2(a));
            Console.WriteLine(Program.metod3(a));
            Console.WriteLine(Program.metod4(a));
            Console.ReadLine();

        }
       public static string metod1(string a)
        {
            string[] sozler = a.Split(' ');
            string ilkSoz = sozler[0];
            string neticeSoz = "";
            foreach (char herf in ilkSoz)
            {
                if (herf == 'a')
                    neticeSoz += "";
                else
                    neticeSoz += herf.ToString();
            }
            return neticeSoz;          
        }
        public static string metod2(string a)
        {
            string[] sozler = a.Split(' ');
            string ilkSoz = sozler[0];
            string sonSoz = sozler[sozler.Length - 1];
            string netice = sozler[0].Substring(sozler[0].Length - 1) + sonSoz;
            return netice;
        }
       public static string metod3(string a)
        {
            string birinciHisse = a.Substring(a.IndexOf('a'));
            string ikinciHisse = birinciHisse.Remove(birinciHisse.LastIndexOf('a'));
            return ikinciHisse;            
        }
        public static string metod4(string a)
        {
            string birinciHisse = a.Substring(a.IndexOf('a'));
            string ikinciHisse = birinciHisse.Remove(birinciHisse.LastIndexOf('a'));
            string part1 = ikinciHisse.Substring(ikinciHisse.IndexOf('b'));
            string part2 = part1.Remove(part1.LastIndexOf('b'));
            return part2;
        }
    }
}
