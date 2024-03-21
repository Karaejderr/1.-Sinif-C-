using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depo_Doldurma_Progblemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. musluk 12 lt su ekleyecek
            //2. musluk 8 lt su boşaltacak
            // sistem her çalışmasıda 10 lt su ekleyecek
            int musluk1;
            int musluk2;
            int toplam = 0;
            Console.WriteLine("Lütfen deponun miktarını girinz");
            int depo = Convert.ToInt32(Console.ReadLine());
            int i;
            int eksiltilmesiGerekenMiktar = 0;
            for (i=0;toplam<=depo;i++)
            {
                Console.WriteLine("Lütfen musluk1 açıksa 1'e kapalıysa 0'a basınız");
                musluk1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen musluk2 açıksa 1'e kapalıysa 0'a basınız");
                musluk2 = Convert.ToInt32(Console.ReadLine());
                if(musluk1==1 && musluk2==1)
                {
                    toplam += 12 - 8 + 10; 
                    eksiltilmesiGerekenMiktar = 14;
                }
                if(musluk1==1 && musluk2==0)
                {
                    toplam += 12 + 10;
                    eksiltilmesiGerekenMiktar = 22;
                }
                if(musluk1==0 && musluk2==1)
                {
                    toplam += 10 - 8;
                    eksiltilmesiGerekenMiktar = 2;
                }
            }
            Console.WriteLine($"Deponuz {i-1}.doldurma işleminde {toplam - eksiltilmesiGerekenMiktar} lt su seviyesine ulaşacaktır. ");
        }
    }
}
