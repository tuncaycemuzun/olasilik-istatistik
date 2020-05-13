using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, comb;
            Console.Write("n Değerini Giriniz : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("r Değerini Giriniz : ");
            r = Convert.ToInt32(Console.ReadLine());
            comb = combin(n, r);
            Console.WriteLine("Sonuç:{0}", comb);
            Console.ReadLine();
        }

        static int combin(int a, int b)
        {
            int f1, f2, f3, y;
            f1 = fact(a);
            f2 = fact(b);
            f3 = fact(a - b);
            y = f1 / (f2 * f3);
            return y;
        }

        static int fact(int x)
        {
            int fx = 1, i;
            for (i = 1; i <= x; i++)
                fx = fx * i;
            return fx;
        }
    }
}
