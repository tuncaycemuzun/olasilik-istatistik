using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartSapma
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet;
            double ortalama = 0;
            double toplam = 0;
            
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            double[] sayilar = new double[adet];
            for(int i=0;i<sayilar.Length;i++)
            {
                int sayi;
                Console.Write("{0}. Sayıyı Giriniz : ",i+1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
                toplam = toplam + sayi;
            }
            ortalama = toplam / adet;

            double sonOrtalama = 0;
            double sontoplam = 0;
            double[] farkDizisi = new double[adet];
            for(int i=0; i < farkDizisi.Length; i++)
            {
                double fark = sayilar[i] - ortalama;
                farkDizisi[i] = Math.Pow(fark, 2);
                sontoplam = farkDizisi[i] + sontoplam;
            }
            sonOrtalama = sontoplam / (adet - 1);

            double standartSapma = Math.Sqrt(sonOrtalama);
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            Console.Write("Standart Sapma = {0}",standartSapma);
            Console.ReadKey();
        }
    }
}
