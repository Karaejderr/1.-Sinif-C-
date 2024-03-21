using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_İş_Yerinin_Gider_Hesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // işçi sayısı girilecek
            // satış başı 20 tl prim
            // çalışma saati > 9 ise saat başı 100 tl prim
            /// elektirk kw para kw<=240 = 1,48 tl kw>240 = 2.22
            /// suyun m^3 parası = 12 tl
            

            Console.WriteLine("Çalışan sayısını giriniz");
            int işçi = Convert.ToInt32(Console.ReadLine());
            int toplamMaaş = 0;
            int i = 1;
            int maaş;


            for (; i <= işçi; i++)
            {
                Console.WriteLine("İşçinin çalışma saatini giriniz");
                int saat = Convert.ToInt32(Console.ReadLine());

                if (saat > 9)
                {
                     maaş = 15000;
                    Console.WriteLine("İşçinin sattığı ürün adedini giriniz");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    maaş = maaş + ((saat - 9) * 100) + (adet * 22);
                    Console.WriteLine($"İşçinin maaşı = {maaş}");
                    toplamMaaş += maaş;  


                }
                if (saat <= 9)
                {
                    maaş = 15000;
                    Console.WriteLine("İşçinin sattığı ürün adedini giriniz");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    maaş = maaş + (adet * 20);
                    Console.WriteLine($"İşçinin maaşı = {maaş}");
                    toplamMaaş += maaş;  
                    
                }
                

            } 

            Console.WriteLine("Harcanan elektrik miktarını kw cinsinden giriniz");
            int kw = Convert.ToInt32(Console.ReadLine());
            int elektrikMasrafı;
            if (kw <= 240)
            {
                
                elektrikMasrafı = (int)(kw * 1.48);
                Console.WriteLine($"Elektrik masrafı = {elektrikMasrafı}");

            }
            else
            {
                elektrikMasrafı = (int)(kw * 2.22);
                Console.WriteLine($"Elektrik masrafı = {elektrikMasrafı}");
            }

            Console.WriteLine("Harcanan su miktarının değerin m^3 cinsinden giriniz");
            int harcananSu = Convert.ToInt32(Console.ReadLine());
            int suMasrafı = harcananSu * 12;
            Console.WriteLine($"Su masrafı = {suMasrafı}");
            int toplamGider = toplamMaaş + elektrikMasrafı + suMasrafı;
            Console.WriteLine($"Toplam maaş gideri{toplamMaaş}");
            Console.WriteLine($"İş yerinizin toplam gideri {toplamGider}");
            





        }
    }
}
