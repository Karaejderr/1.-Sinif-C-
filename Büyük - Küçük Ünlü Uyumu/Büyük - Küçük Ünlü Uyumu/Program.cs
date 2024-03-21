using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Büyük___Küçük_Ünlü_Uyumu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //önce sistemin ünlüleri bilmesi gerekek
            
            Console.WriteLine("Lütfen kelime girin");
            string kelime = Console.ReadLine();  //adım 
            int kelimeUzunluk = kelime.Length; //kelimeUzunluk = 4
            char[] kelimeÜnlü = new char[50];
            int i;
            int ünlüSayısı = 0;
            for (i = 0; i < kelimeUzunluk; i++)
            {
                if (kelime[i] == 'a' || kelime[i] == 'ı' || kelime[i] == 'o' || kelime[i] == 'u' || kelime[i] == 'e' || kelime[i] == 'i' || kelime[i] == 'ö' || kelime[i]=='ü')
                {
                    ünlüSayısı++;
                }
            }
          
            for (i = 0; i < kelimeUzunluk; i++) // adım = kelimeUzunluk:4  ///i=0 1 2 3 4
            {
                if (kelime[i] == 'a' || kelime[i] == 'ı' || kelime[i] == 'o' || kelime[i] == 'u' || kelime[i] == 'e' || kelime[i] == 'i' || kelime[i] == 'ö' || kelime[i] == 'ü')
                {
                    kelimeÜnlü[i] = kelime[i];
                }                       
            }
         
            bool büyükÜnlü = true;
            if (ünlüSayısı==0)
            {
                büyükÜnlü =true;
            }

            else
            {
                for (i = 0; i < ünlüSayısı; i++) 
                {


                    if (kelimeÜnlü[i] == 'e' || kelimeÜnlü[i] == 'i' || kelimeÜnlü[i] == 'ö' || kelimeÜnlü[i] == 'ü')
                    {
                        büyükÜnlü = false;
                    }

                }
            }
                       
            if (büyükÜnlü == false)
            {
                Console.WriteLine("Büyük ünlü uyumuna uymaz");
            }
            else
            {
                Console.WriteLine("Büyük ünlü uymuna uyar");
            }









        }
    }
}
