using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistematikRastgeleOrnekleme
{
    class Program
    {
        static void Main(string[] args)
        {
            int kitle, orneklem, k, a=0;
            Random rastgele = new Random();
            Console.Write("Kitle Giriniz : ");
            kitle = Convert.ToInt32(Console.ReadLine());
            Console.Write("Örneklem Giriniz : ");
            orneklem = Convert.ToInt32(Console.ReadLine());
            k = kitle / orneklem;
            a = rastgele.Next(1,k);

            Console.Write("a sayısı = " + a + "\n");

            if (orneklem != 0)
            {
                Console.WriteLine(a);
                for (int i=1;  i<orneklem; i++)
                {
                    Console.WriteLine(a+=k);
                }
            }
            
            else
                Console.Write("Örneklem 0 girilemez..");
            Console.ReadLine();
        }
    }
}
