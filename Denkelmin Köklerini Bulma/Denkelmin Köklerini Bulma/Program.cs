using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denkelmin_Köklerini_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen denklemin köklerini giriniz (a,b,c)");

            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            float c = Convert.ToInt32(Console.ReadLine());
            float x1;
            float x2;
            float delta;

            delta = b * b - 4 * a * c;

            Console.WriteLine($"Delta değeri = {delta}");

            if (delta > 0)
            {
                x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Denklemin kökleri x1 = {x1} x2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Denklemin kökleri x1 = x2 = {x1}");
            }
            else if (delta <0)
                Console.WriteLine($"Denklemin kökü yoktur");


        }
    }
}
