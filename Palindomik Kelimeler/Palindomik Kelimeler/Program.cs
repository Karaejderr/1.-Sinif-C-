using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindomik_Kelimeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz");
            string kelime = Console.ReadLine();
            
            int kelimeUzunluk = kelime.Length;
            int n = kelimeUzunluk;
            char[] karakterlerDüz = new char[kelimeUzunluk];
            
            char[] karakterlerTers= new char[kelimeUzunluk];
            int i;
            for (i=0;i<n;i++)
            {
                karakterlerDüz[i] = kelime[i];
            }
            for(i=0;i<n;i++)
            {
                karakterlerTers[i] = kelime[n-1];
                n--;
            }
            bool palindomikKelimeler = true;
            for(i=0; i<n;i++)
            {
                if (karakterlerDüz[i] != karakterlerTers[i]) 
                {
                    palindomikKelimeler = false;
                }
            }
            if (palindomikKelimeler==false)
            {
                Console.WriteLine("Kelime palindomik değil");
            }
            else
            {
                Console.WriteLine("Kelime palindomiktir");
            }

           

            
            










        }
    }
}
