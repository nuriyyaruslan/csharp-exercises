using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12metod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12).4 dene INTEGER tipli metod yarat. metod1(a) ,metod2(a) ,metod3(a), metod4(a);+
            metod1 - a ededinden butun 5 reqemlerini legv edir+
            metod2 - a ededi eger cut ededdirse, hemin ededdin reqemleri cemini qaytarir,
            eger tek ededdirse o zaman ozunu qaytarir,+metod3 - a ededin tersine duzub evveline ve 
            axirina 1 reqemini artirib,neticenin 111 bolunmesinden alinan qaligi tapir.
            metod4 - a ededin daxilinde 5 reqemini legv edib I ve axirinci reqemlerinin yerini deyishir.
            Hesabla: (metod1 + metod2 + metod3) * metod4 */
            Console.WriteLine("a-ni daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("metod1: ededden 5 reqemini legv et: {0}\r\n metod2: eger cutdurse reqem cemini tap: deyilse ozunu qaytar: {1} \r\n metod3: tersine cevir her terefine 1 artir ve sonra 111 e bolunme qaligini goster: {2}\r\n metod4: 5 reqemini legv et 1ci reqeminden sonuncunun yerini deyis: {3} \r\n netice :{4}",
                 Program.metod1(a), Program.metod2(a), Program.metod3(a), Program.metod4(a),(Program.metod1(a)+Program.metod1(a)+Program.metod3(a))*Program.metod4(a)));
            Console.ReadLine();
        }
        public static int metod1(int a)
        {
            string yeniEded = "";
            foreach (char item in a.ToString())
            {
                if (item == '5')
                    yeniEded += "";
                else
                    yeniEded += item.ToString();
            }
            return int.Parse(yeniEded);
        }
        public static int metod2(int a)
        { 
            if (a % 2 == 0)
            {
                int cem = 0;
                foreach (char item in a.ToString())
                {
                    cem += Convert.ToInt32(item.ToString());
                }
                return cem;
            }
            else
                return a;
        }
        public static int metod3(int a)
        {
            string tersi = "";
            for (int i = a.ToString().Length-1; i >=0; i--)
            {
                tersi += a.ToString()[i];
            }
            int qaliq = int.Parse("1" + tersi + "1") % 111;
            return qaliq;
        }
        public static int metod4(int a)
        {
            string yeniA = "";
            foreach (char item in a.ToString())
            {
                if (item == '5')
                    yeniA += "";
                else
                    yeniA += item.ToString();
            }
            string deyisilmis = "";
            deyisilmis += yeniA.Substring(yeniA.Length - 1,1) + yeniA.Substring(1, yeniA.Length - 2) + yeniA.Substring(0, 1);
            return int.Parse(deyisilmis);
            }
    }
}
