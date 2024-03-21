using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Büyük_Ünlü_Uyumu_Gelişmiş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalın Ünlü Uyumu : Kelimedeki ünlülerin 'a - ı - o - u' ünlülerinden oluşmasındır");

            Console.WriteLine("****************");

            Console.WriteLine("İnce Ünlü Uyumu : Kelimedeki ünlülerin 'e - i - ö - ü' ünlülerinde oluşmasıdır");

            Console.WriteLine("***************");

            Console.WriteLine("Büyük Ünlü Uyumu : Kelime kalın ve ince ünlü uyumlarından en az birine uyuyursa sağlanır.");

            Console.WriteLine("-----------------------------------------------------------------------------------------");

            Console.WriteLine("Lütfen kelime girin");
            string kelime = Console.ReadLine();  //adım 
            int kelimeUzunluk = kelime.Length; //kelimeUzunluk = 4
            char[] kelimeÜnlü = new char[50];
            int i;
            int ünlüSayısı = 0;
            for (i = 0; i < kelimeUzunluk; i++)
            {
                if (kelime[i] == 'a' || kelime[i] == 'ı' || kelime[i] == 'o' || kelime[i] == 'u' || kelime[i] == 'e' || kelime[i] == 'i' || kelime[i] == 'ö' || kelime[i] == 'ü')
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
            bool kalınÜnlü = false;
            bool inceÜnlü = false;
            bool büyükÜnlü = false;
            if (ünlüSayısı == 0)
            {
                büyükÜnlü = true;
            }

            else
            {
                for (i = 0; i < ünlüSayısı; i++)
                {


                    if (kelimeÜnlü[i] == 'e' || kelimeÜnlü[i] == 'i' || kelimeÜnlü[i] == 'ö' || kelimeÜnlü[i] == 'ü')
                    {
                       kalınÜnlü = false;
                        inceÜnlü = true;
                        büyükÜnlü = true;
                    }

                }

                if (kalınÜnlü == false)
                {
                    for (i = 0; i < ünlüSayısı; i++)
                    {


                        if (kelimeÜnlü[i] == 'a' || kelimeÜnlü[i] == 'ı' || kelimeÜnlü[i] == 'o' || kelimeÜnlü[i] == 'u')
                        {
                            kalınÜnlü = true;
                            inceÜnlü = false;
                            büyükÜnlü = true;
                        }

                    }
                }
            }
            if(kalınÜnlü==false)
            {
                Console.WriteLine("Kelime kalın ünlü uymuna uymaz.");
            }
            else
            {
                Console.WriteLine("Kelime kalın ünlü uyumuna uyar.");
            }

            if (inceÜnlü == false)
            {
                Console.WriteLine("Kelime ince ünlü uymuna uymaz.");
            }
            else
            {
                Console.WriteLine("Kelime ince ünlü uyumuna uyar.");
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
