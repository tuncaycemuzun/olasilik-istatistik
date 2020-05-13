using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrekansSeris_Tekrar_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,sayi,sayac=0,i,j,k,l;
            
            Console.Write("Adet Giriniz : ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[x];
            Console.WriteLine("Sayıları Giriniz : ");
            for(int a = 0; a<x; a++)
            { 
                sayi = Convert.ToInt32(Console.ReadLine());
                dizi[a] = sayi;
            }
            Console.WriteLine("**************");
            Array.Sort(dizi);
            
            for (j = 0; j < x; j++)
            {
                for (k = 0; k < x; k++)
                {
                    if (dizi[j] == dizi[k])
                    {
                        for (l = 0; l < j; l++)
                        {
                            if (dizi[l] == dizi[j])
                                sayac = -1;
                        }
                        sayac++;
                    }
                }
                if (sayac != 0)
                    Console.WriteLine(dizi[j] + " sayısı " + sayac + " kez tekrar edildi");
                sayac = 0;
            }
            Console.ReadLine();

        }
    }
}
