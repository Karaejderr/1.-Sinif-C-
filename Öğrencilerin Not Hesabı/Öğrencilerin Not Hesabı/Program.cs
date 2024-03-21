using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrencilerin_Not_Hesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vizenin %30 ödevin %20 finalin %50
            // ort >= 85 A
            // 70<=ort<=84 B
            // 50<=ort<=69 C
            // 45<= ort <= 49 D
            // ort<49 F

            Console.WriteLine("Sınıf mevcudunu giriniz");
            int mevcut = Convert.ToInt32(Console.ReadLine());
            int i;
            int ortalama;
            int vize;
            int final;
            int ödev;
            char derece;
            int toplamOrtalama = 0;

            for (i=1;i<=mevcut;i++)
            {
                Console.WriteLine($"{i}. öğrencinin vize notunu giriniz notunu giriniz");
                Console.WriteLine($"Vize = {vize=Convert.ToInt32(Console.ReadLine())}");
                Console.WriteLine("    --------------------  --------------------    ");

                Console.WriteLine($"{i}. öğrencinin final notunu giriniz notunu giriniz");
                Console.WriteLine($"Final = {final = Convert.ToInt32(Console.ReadLine())}");
                Console.WriteLine("    --------------------  --------------------    ");

                Console.WriteLine($"{i}. öğrencinin ödev notunu giriniz notunu giriniz");
                Console.WriteLine($"Ödev = {ödev = Convert.ToInt32(Console.ReadLine())}");
                Console.WriteLine("    --------------------  --------------------    ");
                ortalama = (vize * 30 / 100) + (final * 50 / 100) + (ödev * 20 / 100);
                toplamOrtalama += ortalama;
                if (ortalama >= 85)
                    derece = 'A';
                else if (70 <= ortalama && ortalama <= 84)
                    derece = 'B';
                else if (50 <= ortalama && ortalama <= 69)
                    derece = 'C';
                else if (45 <= ortalama && ortalama <= 49)
                    derece = 'D';
                else 
                    derece = 'F';
                Console.WriteLine($"{i}. öğrenicinin not ortalaması {ortalama} derecesi {derece}");
                Console.WriteLine("**************++++++++++++************++++++++++++***********");

            }
            Console.WriteLine($"Sınıfın toplam ortalaması {toplamOrtalama/mevcut}");

        }
    }
}
