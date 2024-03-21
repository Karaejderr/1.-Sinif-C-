
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindomik_Sayılar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen basamak sayısını giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayı = new int[n];
            int[] sayıTersi = new int[n];
            int i;
            for (i=0;i<n;i++)
            {
                Console.WriteLine($"Lütfen {i+1}. basmakdaki sayıyı giriniz");
                sayı[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Sayımız=");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{sayı[i]}");

            }
            
            
            for(i=0;i<n;i++)
            {
                sayıTersi[i] = sayı[n - 1];
                n--;
            }
            bool palindomik=true;
            for(i=0;i<n;i++)
            {
                if (sayı[i] != sayıTersi[i])
                {

                    palindomik = false;
                }
            }
            if(palindomik==false)
            {
                Console.WriteLine("\nSayı palindomik sayı değil");
            }
            else
            {
                Console.WriteLine("\nSayı palindomik sayı");
            }
            

        }
    }
}
