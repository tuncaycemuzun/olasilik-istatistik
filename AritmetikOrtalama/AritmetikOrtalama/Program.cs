using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikOrtalama
{
    class Program
    {
        public static double mod;
        static void Main(string[] args)
        {
            int adet;
            int sayi, toplam = 0;
            double ort=0;
            int modControl = 0;
            int aklimda = 0;
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[] sayilar = new int[adet];
            for(int i = 1; i <= adet; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz : ",i);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                sayilar[i-1] = sayi;
                Console.Clear();
            }
            ort = Convert.ToDouble(toplam) / Convert.ToDouble(adet);
            if (adet % 2 == 0)
            {
                double medyan1, medyan2, medyan;
                
                Array.Sort(sayilar);

                medyan2 = sayilar[adet / 2];
                medyan1 = sayilar[(adet / 2) - 1];
                medyan = (medyan1 + medyan2) / 2;
                Array.Sort(sayilar);
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.Write(sayilar[i] + " ");
                }
                Console.WriteLine("\nMedyan = {0}", medyan);
            }
            else
            {
                int medyan;
                
                Array.Sort(sayilar);
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.Write(sayilar[i] + " ");
                }
                medyan = sayilar[(adet - 1) / 2];
                Console.WriteLine("\nMedyan = {0}", medyan);
            }

            for (int i = 0; i < adet; i++)
            {
                

                for (int j = 0; j < adet; j++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        modControl++;
                    }
                }
                if (modControl > aklimda)
                {
                    mod = sayilar[i];
                    aklimda = modControl;
                }
                modControl = 0;
            }
            Console.WriteLine("Mod = " + mod);
            Console.WriteLine("Girilen {0} adet sayının ortalaması ={1}\n", adet, ort);
            Console.ReadLine();
        }
    }
}
