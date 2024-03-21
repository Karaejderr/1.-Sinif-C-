using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Takım_Anketi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // gs fb bjk ts
            int tkm;
            int katılım;
            int gs = 0;
            int fb=0;
            int bjk=0;
            int ts=0;
            int diğer = 0;
            float gsort, fbort, bjkort, tsort, diğerort;
            Console.WriteLine("Lütfen katılımcı sayısını giriniz");
            katılım = Convert.ToInt32(Console.ReadLine());
            
            for(int i =1;i<= katılım;i++)
            {
                Console.WriteLine("Lütfen takımınızı seçiniz.\nGS = 1\nFB = 2\nBJK = 3\nTS = 4\nBaşka takım = 5");
                tkm = Convert.ToInt32(Console.ReadLine());
                switch (tkm)
                {
                    case 1:

                        Console.WriteLine("Tuttuğunu takım Galatasaray.");
                        gs++;
                        break;

                    case 2:
                        Console.WriteLine("Tuttuğun takım Fenerbahçe");
                        fb++;
                        break;
                    case 3:
                        Console.WriteLine("Tuttuğun takım Beşiktaş");
                        bjk++;
                        break;
                    case 4:
                        Console.WriteLine("Tuttuğun takım Trabzon Spor");
                        ts++;
                        break;
                    default:
                        Console.WriteLine("Başka bir takım tutuyorsun");
                        diğer++;
                        break;
                }
                

            }
            Console.WriteLine("***************************************");
            gsort = (100 * gs) / katılım;
            fbort = (100 * fb) / katılım;
            bjkort = (100 * bjk) / katılım;
            tsort = (100 * ts) / katılım;
            diğerort = (100 * diğer) / katılım;
            Console.WriteLine($"Galatasaray\nOy sayısı = {gs}\nOy oranı = %{gsort}\n----------");
            Console.WriteLine($"Fenerbahçe\nOy sayısı = {fb}\nOy oranı = %{fbort}\n----------");
            Console.WriteLine($"Beşiktaş\nOy sayısı = {bjk}\nOy oranı = %{bjkort}\n----------");
            Console.WriteLine($"Trabzon Spor\nOy sayısı = {ts}\nOy oranı = %{tsort}\n----------");
            Console.WriteLine($"Başka takım tutanlar\n-Oy sayısı = {diğer}\nOy oranı = {diğerort}");


        }
    }
}
