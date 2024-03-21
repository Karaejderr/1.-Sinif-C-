using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabı_Bitirme_Süres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kitabın sayfa sayısı verilecek
            // ilk gün okunan kitap sayısı verilecek
            // sonraki günlerde okunan sayfa sayısı %10 artacak

            float sayfa = Convert.ToInt32(Console.ReadLine());
            float okunan=Convert.ToInt32(Console.ReadLine());
            int gün = 0;
            float toplam = Convert.ToInt32(Console.ReadLine());
            if (sayfa <= toplam)
                okunan = okunan + (okunan * 1/10);
            toplam += okunan;
            gün++;
            Console.WriteLine($"gün={gün}");



        }
    }
}
