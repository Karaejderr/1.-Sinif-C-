using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Çiftçi_Sorusu__ödev_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fidan sayısı dışarından girilecek
            //Bir fidanın maliyeti 5000 tl dir ve fidanlar 1 yaşındadır
            //Malzeme giderleri 100.000 tl dir. Bu işe toplamda 100.000 + 5000*fidan sayısı kadar para yatırılmışıtır
            //fidanlar 2. yaşından itibaren ürün vermektedir
            //fidanlar 2-5 yılları arasında 50kg
            //6-20 yılları arasında 80kg
            //21 den sonra 100 kg ürün vermektedir
            //1 kg meyvenin fiyatı 100 tl dir
            //her bir ağacın yıllık masrafı 2000 tl dir
            //ayrıyeten her yıl 100.000 tl masraf yapılmaktadır
            //hasat 2. yıldan itibaren yapılacaktır ve hasat ücreti 50.000 tl dir
            //her yıl ürünlerden elde edilen kar %25 artarken maaliyet %20 artmakatdir

            Console.WriteLine("Lütfen fidan sayısını giriniz");
            int fidanSayısı = Convert.ToInt32(Console.ReadLine());
            int malzemeMasrafı = 100000; //tek seferlik en başta eklenecek
            int ağacınYıllıkMasrafı = 2000;
            int yıllıkMasraf = 100000;
            int hasatMasrafı = 50000;
            int meyveKgÜcreti = 100;
            int toplamMasraf = (fidanSayısı * 5000) + 100000;
            int toplamGelir = 0;
            int yas = 1;

            toplamMasraf = toplamMasraf + malzemeMasrafı + (fidanSayısı * ağacınYıllıkMasrafı);
            yas = yas + 1;

            toplamMasraf = toplamMasraf + (fidanSayısı * ağacınYıllıkMasrafı) + yıllıkMasraf + hasatMasrafı;
            toplamGelir = toplamGelir + (meyveKgÜcreti * fidanSayısı * 50);

            yas = yas + 1;

            if (3 <= yas && yas <= 5)
            {
                while (toplamGelir - toplamMasraf < (fidanSayısı * 5000) + 100000)
                {
                    ağacınYıllıkMasrafı = ağacınYıllıkMasrafı + (ağacınYıllıkMasrafı / 5);
                    yıllıkMasraf = yıllıkMasraf + (yıllıkMasraf / 5);
                    hasatMasrafı = hasatMasrafı + (hasatMasrafı / 5);
                    meyveKgÜcreti = meyveKgÜcreti + (meyveKgÜcreti / 4);

                    toplamMasraf = toplamMasraf + (fidanSayısı * ağacınYıllıkMasrafı) + yıllıkMasraf + hasatMasrafı;
                    toplamGelir = toplamGelir + (meyveKgÜcreti * fidanSayısı * 50);

                    yas = yas + 1;


                }
            }
            else if (6 <= yas && yas <= 20)

            {
                while (toplamGelir - toplamMasraf < (fidanSayısı * 5000) + 100000)
                {
                    ağacınYıllıkMasrafı = ağacınYıllıkMasrafı + (ağacınYıllıkMasrafı / 5);
                    yıllıkMasraf = yıllıkMasraf + (yıllıkMasraf / 5);
                    hasatMasrafı = hasatMasrafı + (hasatMasrafı / 5);
                    meyveKgÜcreti = meyveKgÜcreti + (meyveKgÜcreti / 4);

                    toplamMasraf = toplamMasraf + (fidanSayısı * ağacınYıllıkMasrafı) + yıllıkMasraf + hasatMasrafı;
                    toplamGelir = toplamGelir + (meyveKgÜcreti * fidanSayısı * 80);

                    yas = yas + 1;
                }
                

            }

            else if (yas > 20)
            {
                while (toplamGelir - toplamMasraf < (fidanSayısı * 5000) + 100000)
                {
                    ağacınYıllıkMasrafı = ağacınYıllıkMasrafı + (ağacınYıllıkMasrafı / 5);
                    yıllıkMasraf = yıllıkMasraf + (yıllıkMasraf / 5);
                    hasatMasrafı = hasatMasrafı + (hasatMasrafı / 5);
                    meyveKgÜcreti = meyveKgÜcreti + (meyveKgÜcreti / 4);

                    toplamMasraf = toplamMasraf + (fidanSayısı * ağacınYıllıkMasrafı) + yıllıkMasraf + hasatMasrafı;
                    toplamGelir = toplamGelir + (meyveKgÜcreti * fidanSayısı * 100);

                    yas = yas + 1;
                }
            }
            Console.WriteLine($"Fidanların Yaşı = {yas}");
            

        }
    }
}

    