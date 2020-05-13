using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medyan
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet,sayi;
            Console.Write("Adet Giriniz :");
            adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];
            if (adet % 2 == 0)
            {
                double medyan1, medyan2, medyan;
                for (int i = 0; i < adet; i++)
                {
                    Console.Write("{0}. Sayıyı Giriniz :", i + 1);
                    sayi = Convert.ToInt32(Console.ReadLine());
                    sayilar[i] = sayi;
                }
                Array.Sort(sayilar);
                
                medyan2 = sayilar[adet / 2];
                medyan1 = sayilar[(adet / 2) - 1];
                medyan = (medyan1 + medyan2) / 2;
                Array.Sort(sayilar);
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.Write(sayilar[i] + " ");
                }
                Console.WriteLine("\nMedyan = {0}",medyan);
            }
            else
            {
                int medyan;
                for(int i=0; i < adet; i++)
                {
                    Console.Write("{0}. Sayıyı Giriniz :",i+1);
                    sayi = Convert.ToInt32(Console.ReadLine());
                    sayilar[i] = sayi;
                }
                Array.Sort(sayilar);
                for(int i=0; i < sayilar.Length; i++)
                {
                    Console.Write(sayilar[i]+" ");
                }
                medyan = sayilar[(adet-1) / 2];
                Console.WriteLine("\nMedyan = {0}", medyan);
            }
            Console.ReadLine();
        }
    }
}
