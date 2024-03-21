using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Ticaret_İndirim_Kampanyası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //200 Tl altına indirim ugulanmayacak
            //200 - 500 Tl arasına %15 indirim
            //501 - 800 Tl arasına %30 indirim
            //801 Tl sonrasına %40 indirim

            Console.WriteLine("Ürünün fiyatının giriniz");
            double ürünFiyati = Convert.ToInt32(Console.ReadLine());

            if (ürünFiyati < 200)
            {
                Console.WriteLine($"Ürüne indirim uyugulanmaz. Ürün fiyatı {ürünFiyati}");
            }

            else if (200 <= ürünFiyati && ürünFiyati <= 500) 
            {
                ürünFiyati = ürünFiyati - (ürünFiyati * 15 / 100);
                Console.WriteLine($"Ürünün indirimli fiyatı {ürünFiyati}");
            }
            else if (501 <= ürünFiyati && ürünFiyati <= 800)
            {
                ürünFiyati = ürünFiyati - (ürünFiyati * 30 / 100);
                Console.WriteLine($"Ürünün indirimli fiyatı {ürünFiyati}");
            }
            else if (801 <= ürünFiyati)
            {
                ürünFiyati = ürünFiyati - (ürünFiyati * 40 / 100);
                Console.WriteLine($"Ürünün indirimli fiyatı {ürünFiyati}");
            }
        }
    }
}
