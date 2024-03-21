using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_Tır_Şöfürünün_Aldığı_Ücret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fibonnaci sayı dizisi
            // belirlenen sayıya kadar fibonnacci sayı dizisi yazdırması lazım
            // fibonnaci sayı dizisi kendisinden önceki sayıların toplamıdır
            //1 1 2 3 5 8 13 21 .....a, k, a+k

            Console.WriteLine("Kaç tane fibonnaci sayı üretilsin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            int i = 0;
            Console.WriteLine($"{b-1}");
            Console.WriteLine($"{b}");

            for (b = 2; i <= a; i++)
                b = (b - 1) + (b - 2);
            Console.WriteLine($"{b}");
            









        }
    }
}
