using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegisimKatsayisi
{
    class Program
    {
        public static double[] sayilar;
        public static int adet;
        static void Main(string[] args)
        {
            
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            sayilar = new double[adet];
            double sonuc = KatsayiHesaplama();
            Console.Write("Sonuç = {0}",sonuc);
            Console.ReadLine();
        }
        public static double KatsayiHesaplama()
        {
            double ortalama = 0;
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi;
                Console.Write("{0}. Sayıyı Giriniz : ", i + 1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
                toplam = toplam + sayi;
            }
            ortalama = toplam / adet;

            double sonOrtalama = 0;
            double sontoplam = 0;
            double[] farkDizisi = new double[adet];
            for (int i = 0; i < farkDizisi.Length; i++)
            {
                double fark = sayilar[i] - ortalama;
                farkDizisi[i] = Math.Pow(fark, 2);
                sontoplam = farkDizisi[i] + sontoplam;
            }
            sonOrtalama = sontoplam / (adet - 1);

            double standartSapma = Math.Sqrt(sonOrtalama);
            double a = (standartSapma / ortalama)*100;
           

            double sonuc= a;
            return sonuc;
        }
    }
}
