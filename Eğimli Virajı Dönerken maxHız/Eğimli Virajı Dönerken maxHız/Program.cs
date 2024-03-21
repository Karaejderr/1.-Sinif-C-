using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eğimli_Virajı_Dönerken_maxHız
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v^2=tan(derece) * g * r

            // derece girilmesi lazım
            // g = 10 alıncak
            // çevreyi dışarıdan versin r yi bulsun
            // pi = 3.14

            double pi = 3.14;
            double Vmax;

            Console.WriteLine("Lütfen bir çevre değeri giriniz");
            double cevre = Convert.ToInt32(Console.ReadLine());
            double r = cevre / (2 * pi);

            Console.WriteLine($"Yarı çağ değeri = {r}");

            Console.WriteLine("Lütfen bir açı değeri giriniz");
            double aci = Convert.ToInt32(Console.ReadLine());
            double radian = aci * (Math.PI / 180);
            double tanjant = Math.Tan(radian);
            Console.WriteLine($"Açını tanjant değeri {tanjant}");

            double sayi1 = tanjant * 10 * r;
            Vmax = Math.Sqrt(sayi1);
            Console.WriteLine($"Virajı dönebileceğiniz maksimum hız değeri {Vmax}m/s");








        }
    }
}
