using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod
{
    class Program
    {
        public static double mod;
        static void Main(string[] args)
        {
            int adet,sayi;
            int modControl = 0;
            int aklimda = 0;
            Console.Write("Adet Giriniz : ");
            adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];
            for(int i = 0; i < adet; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz : ",i+1);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
                for(int j = 0; j < adet; j++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        modControl++;
                    }
                }
                if (modControl > aklimda)
                {
                    mod = sayilar[i]; aklimda = modControl;
                }
            modControl = 0;
            }
            Console.WriteLine("Mod = "+mod);
            Console.ReadLine();
        }
    }
}
