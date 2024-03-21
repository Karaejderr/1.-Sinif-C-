using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_Aracın_Yakıt_Masrafı__Düzenlenmiş_Hali_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araç 0-20 arasında km başı 3 lt yakıt yakıyor 
            //21-60 arasında km başına 5 lt yakıyor
            //61 den sonra km başına 8 lt yakıyor
            //a ve t değerleri dışarıdan girilerek v = a * t ve x=1/2 * a * t^2 değeri hesaplanır
            //V değeri uygun aralıkta ki işlem yapılırken öncek aralıktaki işlemleride dahil edilir

            Console.WriteLine("Lütfen bir ivme değeri giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir süre değeri giriniz");
            int t = Convert.ToInt32(Console.ReadLine());
            double v = a * t;
            double x;
            double yakılanYakıt;
            double yakıtMasrafı;
            double yirmiHızınaGeldiğiSüre = 20.0 / a;
            double yirmiHızınaGeldiğiSüredeAldığıYol = 0.5 * a * yirmiHızınaGeldiğiSüre * yirmiHızınaGeldiğiSüre;
            double altmışHızınaGeldiğiSüre = 60 / a;
            double altmışHızınaGeldiğiSüredeAlınanYol = 0.5 * a * altmışHızınaGeldiğiSüre * altmışHızınaGeldiğiSüre; 

            if (0 <= v && v <= 20)
            {
                Console.WriteLine("Alınan yol değeri hesaplanıyor...");
                x = 0.5 * a * t * t;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Alınan yol = {x}");

                Console.WriteLine("Yakılan yakıt miktarı hesaplanıyor...");
                yakılanYakıt = x * 3;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Yakılan yakıt miktarı = {yakılanYakıt}");

                Console.WriteLine("Yakıt masrafı hesaplanıyor...");
                yakıtMasrafı = yakılanYakıt * 30;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Yakıt masrfı = {yakıtMasrafı}");
            }
            else if (21 <= v && v <= 60)
            {                                
                Console.WriteLine("Alınan yol değeri hesaplanıyor...");
                x = 0.5 * a * t * t;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Alınan yol {x}");

                Console.WriteLine("Yakılan yakıt miktarı hesaplanıyor ...");
                yakılanYakıt = (yirmiHızınaGeldiğiSüredeAldığıYol * 3) + ((x - yirmiHızınaGeldiğiSüredeAldığıYol) * 5);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Yakılan yakıt miktarı = {yakılanYakıt}");

                Console.WriteLine("Yakıt masrafı hesaplanıyor ...");
                yakıtMasrafı = yakılanYakıt * 30;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Yakıt masrfı = {yakıtMasrafı}");
            }
            else if (v > 60)
            {                             
                Console.WriteLine("Alınan yol değeri hesaplanıyor...");
                x = 0.5 * a * t * t;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Alınan yol {x}");

                Console.WriteLine("Yakılan yakıt miktarı hesaplanıyor...");
                yakılanYakıt = (yirmiHızınaGeldiğiSüredeAldığıYol * 3) + ((altmışHızınaGeldiğiSüredeAlınanYol - yirmiHızınaGeldiğiSüredeAldığıYol) * 5) + ((x - altmışHızınaGeldiğiSüredeAlınanYol - yirmiHızınaGeldiğiSüredeAldığıYol) * 8);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Yakılan yakıt miktarı = {yakılanYakıt}");

                Console.WriteLine("Yakıt masrafı hesaplanıyor ...");
                yakıtMasrafı = yakılanYakıt * 30;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Yakıt masrfı = {yakıtMasrafı}");
            }
        }
    }
}
