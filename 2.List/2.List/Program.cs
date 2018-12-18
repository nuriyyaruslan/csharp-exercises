using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.List
{
    class Program
    {
        static void Main(string[] args)
        {
            //2).String tipli List yarat. Buraya 20 dene tesadufu formada metnleri doldur.
            // Bu listin ele elemetlerini cap et ki: uzunlugu 11 den cox olsun.
            //daxilinde { A} simvolu olsun, ilk simvol reqem olsun. 
            Console.WriteLine("texti daxil edin:");
            string text = Console.ReadLine();
            string[] cumleler = text.Split('.');
            List<string> cumlelerListi = new List<string>();
            cumlelerListi.AddRange(cumleler);
            string netice = "";
            for (int i = 0; i < cumlelerListi.Count; i++)
            {
                if(cumlelerListi[i].Contains("A") && cumlelerListi[i].Length>11 && Char.IsDigit(Convert.ToChar(cumlelerListi[i].Substring(0,1))) )
                    netice += cumlelerListi[i] + "\r\n";
            }
            Console.WriteLine("netice:"+netice);
            Console.ReadKey();
        }





















        //public static string metod(string metn)
        //{
        //    string cumle = "";
        //    string[] cumleler = metn.Split('.');
        //    for (int i = 0; i < cumleler.Length; i++)
        //    {
        //        for (int j = 0; j < cumleler[i].Length; j++)
        //        {
        //            if (Char.IsDigit(cumleler[i][j]) && cumleler[i].Length > 11 && cumleler[i].Contains("A"))
        //                cumle += cumleler[i] + "\r\n";
        //        }
        //    }
        //    return cumle;
        //}
    }
}
