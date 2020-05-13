using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitSeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sayi;

            Console.Write("Adet Giriniz :");
            x = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[x];
            Console.Write("Sayıları Giriniz :\n");
            for (int i =0; i<x; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }
            Array.Sort(sayilar);
            Console.Clear();
            Console.Write("Sayıları Sıralanmış Listesi\n*********************************\n");
            for (int i = 0; i<x; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            
            Console.ReadLine();
        }
    }
}
