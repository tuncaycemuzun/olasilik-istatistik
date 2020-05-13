using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, per, fakt, fakt1;
            Console.WriteLine("Permütasyon hesaplaması için n ve r değerlerini girin..:");
            Console.Write("n Değeri : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("r Değeri : ");
            r = Convert.ToInt32(Console.ReadLine());
            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            per = fakt / fakt1;
            Console.WriteLine("Permütasyon : {0}", per);
            Console.ReadLine();
        }
    }
}
