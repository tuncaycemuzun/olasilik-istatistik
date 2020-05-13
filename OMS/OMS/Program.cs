using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            double ortalama = 0;
            int adet;
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            double[] sayilar = new double[adet];
            for(int i = 0; i<sayilar.Length;i++)
            {
                int sayi;
                Console.Write("{0}. Sayıyı Giriniz : ",i+1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
                toplam += sayi;
            }
            ortalama = toplam / adet;

            double farkToplam = 0;
            double farkOrtalama = 0;
            double[] farkDizisi = new double[adet];
            for(int i=0;i<farkDizisi.Length;i++)
            {
                double fark = sayilar[i] - ortalama;
                
                if(fark<0)
                {
                    fark = fark * -1;
                }

                farkDizisi[i] = fark;

                farkToplam += farkDizisi[i];
            }
            farkOrtalama = farkToplam / adet;
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.Write("Sonuç = {0}",farkOrtalama);
            Console.ReadKey();
        }
    }
}
