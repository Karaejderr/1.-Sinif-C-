using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizide_Arana_Elemanı_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dizin boyutunu giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int a;
            int[] dizi; // tanımlama
            dizi = new int[n];//dizinin boyutunu girme
            for (i=0;i<n;i++)
            {
                
                Console.WriteLine($"Dizinin {i+1}. elemanı{dizi[i] = Convert.ToInt32(Console.ReadLine())} ");
            }
            Console.WriteLine("Aranan sayiyi giriniz");
            a=Convert.ToInt32(Console.ReadLine());
            int bulundu = 0;
            for(i=0;i<n;i++)
            {
                if (dizi[i] == a)
                    bulundu = 1;
            }
            if(bulundu==1)
                Console.WriteLine($"{a} dizinin {i-1}. elemanıdır");
            else
                Console.WriteLine("Dizide böyle bir eleman yok");
        }
    }
}
