using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çarpanlar_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk sayıyı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
           
            int toplam1 = 0;
            int toplam2 = 0;
            int i;
            int k;
               

            for (i = 1; 0 < i && i < a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine($"{i}");
                    toplam1 += i;

                }             
            }
            Console.WriteLine($"İlk sayının çarpanları toplamı {i}");
            for (k = 1; 0 < k && k < b; k++)
            {
                if (b % k == 0)
                {
                    Console.WriteLine($"{k}");
                    toplam2 += k;

                }
            }
            Console.WriteLine($"İlk sayının çarpanları toplamı {k}");
            if (a==toplam2)
            {
                if (b == toplam1) ;
                Console.WriteLine("sayılar kardeş sayılardır");
            }
            else
                Console.WriteLine("sayıları kardeş sayı değildir");

        }
    }
}
