using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrekansTablosu
{
    class Program
    {
        public static double limitAlt;
        public static double limitUst;
        public static double altSinifSiniriSayi;
        public static int sayac;
        public static double ustSinifSiniriSayi;
        static void Main(string[] args)
        {
            int adet;
            int sayi;
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];
            Console.Clear();
            for (int i = 0; i < adet; i++)
            {
                Console.Write("{0}.Sayıyı giriniz : ", i + 1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }
            Console.Clear();
            Array.Sort(sayilar);
            Console.Write("Sayılar : ");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            int min = sayilar.Min();
            int max = sayilar.Max();
            int r = max - min;

            double k = Convert.ToDouble(Math.Sqrt(adet));
            k = Math.Ceiling(k);
            double h = r / k;
            h = Math.Ceiling(h);

            Console.Write("------------ Sınıf Limitleri --------------\n\n");
            Console.Write("Alt\n\n");
            limitAlt = sayilar.Min();


            double[] sinifAltLimit = new double[Convert.ToInt32(k)];
            sinifAltLimit[0] = limitAlt;
            Console.WriteLine(limitAlt);
            for (int i = 1; i <= k - 1; i++)
            {
                limitAlt += Convert.ToInt32(h);
                Console.WriteLine(limitAlt);
                sinifAltLimit[i] = limitAlt;
            }
            Console.Write("\nÜst\n\n");
            double[] sinifUstLimit = new double[Convert.ToInt32(k)];
            sinifUstLimit[0] = sinifAltLimit[1] - 1;
            limitUst = sinifUstLimit[0];
            Console.Write(sinifUstLimit[0] + "\n");
            for (int i = 1; i <= k - 1; i++)
            {
                limitUst += Convert.ToInt32(h);
                Console.WriteLine(limitUst);
                sinifUstLimit[i] = limitUst;
            }
            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            Console.Write("------------ Sınıf Sınıfları --------------\n\n");
            double[] altSinifSiniri = new double[Convert.ToInt32(k)];
            altSinifSiniri[0] = sinifAltLimit[0] - 0.5;
            altSinifSiniriSayi = altSinifSiniri[0];
            Console.Write("Alt\n\n");
            Console.WriteLine(altSinifSiniriSayi);
            for (int i = 1; i <= k - 1; i++)
            {
                altSinifSiniriSayi += Convert.ToInt32(h);
                Console.WriteLine(altSinifSiniriSayi);
                altSinifSiniri[i] = altSinifSiniriSayi;
            }
            double[] ustSinifSiniri = new double[Convert.ToUInt32(k)];
            ustSinifSiniri[0] = sinifUstLimit[0] + 0.5;
            ustSinifSiniriSayi = ustSinifSiniri[0];
            Console.Write("\nÜst\n\n");
            Console.WriteLine(ustSinifSiniriSayi);

            for (int i = 1; i <= k - 1; i++)
            {
                ustSinifSiniriSayi += Convert.ToInt32(h);
                Console.WriteLine(ustSinifSiniriSayi);
                ustSinifSiniri[i] = ustSinifSiniriSayi;
            }


            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            Console.Write("------------ Sınıf Frekansı --------------\n\n");
            int[] sinifFrekansi = new int[Convert.ToUInt32(k)];
            for(int i = 0; i <= k - 1; i++)
            {
                double ilk = altSinifSiniri[i];
                double son = ustSinifSiniri[i];
                sayac = 0;
                for(int j=0;j<sayilar.Length;j++)
                {
                    if (ilk <= sayilar[j] & son >= sayilar[j])
                    {
                        sayac++;
                    }
                    sinifFrekansi[i] = sayac;
                    
                }
                Console.WriteLine(sinifFrekansi[i]);
            }

            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            Console.Write("------------ Sınıf Orta Noktası --------------\n\n");
            double[] sinifOrtaNokta = new double[Convert.ToUInt32(k)];
            for(int i = 0; i<= k - 1; i++)
            {
                sinifOrtaNokta[i]=(Convert.ToDouble(sinifAltLimit[i]) + Convert.ToDouble(sinifUstLimit[i]))/2;
                Console.WriteLine(sinifOrtaNokta[i]);
            }

            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            Console.Write("------------ Eklenik Frekans --------------\n\n");
            double[] eklenikFrekans = new double[Convert.ToInt32(k)];
            eklenikFrekans[0] = sinifFrekansi[0];
            Console.WriteLine(eklenikFrekans[0]);
            for(int i = 1; i <= k - 1; i++)
            {
                eklenikFrekans[i] = eklenikFrekans[i - 1] + sinifFrekansi[i];
                Console.WriteLine(eklenikFrekans[i]);
                
            }

            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            Console.Write("------------ Oransal Frekans --------------\n\n");
            double[] oransalFrekans = new double[Convert.ToInt32(k)];
            for (int i = 0; i <= k - 1; i++)
            {
                oransalFrekans[i] = Convert.ToDouble(sinifFrekansi[i]) / Convert.ToDouble(adet);
                Console.WriteLine(Math.Round(oransalFrekans[i],2));
            }

            Console.Write("\n********************************************\n");
            Console.Write("********************************************\n");
            Console.Write("------------ Oransal Eklenik Frekans --------------\n\n");
            double[] oransalEklenikFrekans = new double[Convert.ToInt32(k)];
            for (int i = 0; i <= k - 1; i++)
            {
                oransalEklenikFrekans[i] = Convert.ToDouble(eklenikFrekans[i]) / Convert.ToDouble(adet);
                Console.WriteLine(Math.Round(oransalEklenikFrekans[i],2));
            }

            Console.ReadLine();

        }
    }
}
