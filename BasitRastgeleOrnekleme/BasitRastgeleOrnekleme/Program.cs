using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitRastgeleOrnekleme
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, max, min,sayi;
            Random rastgele = new Random();
            Console.Write("Adet Giriniz : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minimum Sayı Giriniz : ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum Sayı Giriniz : ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            if (x != 0)
            {
                if ((max-min)+1<=x)
                {
                    for (int i = 0; i < x; i++)
                    {
                        sayi = rastgele.Next(min, max);
                        Console.Write(sayi);
                        Console.Write("\n");
                    }
                }
                else if((max-min)+1>x)
                {
                    int[] sayilar = new int[x];
                    Random tekrarsızRastgele = new Random();
                    int i = 0;
                    while (i <= x-1)
                    {
                        int sayi2 = tekrarsızRastgele.Next(min, max);
                        if (sayilar.Contains(sayi2))
                            continue;
                        sayilar[i] = sayi2;
                        i++;
                    }
                    Array.Sort(sayilar);
                    foreach (int sayi2 in sayilar)
                        Console.WriteLine(sayi2);
                    Console.ReadKey();
                }

            }
            else
                Console.Write("Adet olarak 0 girilemez.");
            
            Console.ReadLine();

        }
    }
}
