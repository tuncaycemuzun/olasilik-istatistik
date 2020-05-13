using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varyans
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet;
            double anaOrtalama = 0;
            double sonOrtalama = 0;
            double anaToplam = 0;
            double sonToplam = 0;

            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            double[] sayiDizisi = new double[adet];
            Console.WriteLine("************");
            Console.WriteLine("************");
            for (int i=0; i<sayiDizisi.Length;i++)
            {
                double sayi;
                Console.Write("{0}. Sayıyı Giriniz : ",i+1);
                sayi = Convert.ToDouble(Console.ReadLine());
                sayiDizisi[i] = sayi;
                anaToplam = anaToplam + sayi;
            }
            anaOrtalama = anaToplam / adet;
           
            double[] farkDizisi = new double[adet];
            for(int i=0;i<farkDizisi.Length;i++)
            {
                farkDizisi[i] = sayiDizisi[i] - anaOrtalama;
            }


            double[] kareDizisi = new double[adet];
            for(int i=0;i<kareDizisi.Length;i++)
            {
                kareDizisi[i] = Math.Pow(farkDizisi[i],2);
                sonToplam += kareDizisi[i];
            }
            sonOrtalama = sonToplam / adet;
            Console.WriteLine("************");
            Console.WriteLine("************");
            Console.Write("Varyans = {0}",sonOrtalama);
            Console.ReadKey();
        }
    }
}
