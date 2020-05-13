using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Q3_CeyreklerAcikligi_
{
    class Program
    {
        public static int adet;
        public static double[] sayilar;
        public static double q3;
        public static double sonucQ3;
        public static double q1;
        public static double sonucQ1;
        static void Main(string[] args)
        {
            
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************");
            Console.WriteLine("***************");
            sayilar = new double[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi;
                Console.Write("{0}. Sayıyı Giriniz : ", i + 1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }
            Array.Sort(sayilar);
            ceyrekQ1();
            ceyrekQ3();

            double sonuc = sonucQ3 - sonucQ1;
            Console.Write("Sonuç = {0}", sonuc);
            Console.ReadLine();
        }

        public static double ceyrekQ3()
        {
            q3 = (adet + 1) * 0.75;
            double kucukDeger = Math.Floor(q3);
            double buyukDeger = Math.Ceiling(q3);
            sonucQ3 = sayilar[Convert.ToUInt32(buyukDeger - 1)] + (0.25 * (sayilar[Convert.ToUInt32(buyukDeger - 1)] - sayilar[Convert.ToUInt32(kucukDeger - 1)]));
            return sonucQ3;
        }

        public static double ceyrekQ1()
        {
            q1 = (adet + 1) * 0.25;
            double kucukDeger = Math.Floor(q1);
            double buyukDeger = Math.Ceiling(q1);
            sonucQ1 = sayilar[Convert.ToUInt32(buyukDeger - 1)] + (0.75 * (sayilar[Convert.ToUInt32(buyukDeger - 1)] - sayilar[Convert.ToUInt32(kucukDeger - 1)]));
            return sonucQ1;
        }
        
    }
}
