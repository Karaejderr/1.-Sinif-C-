using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sayı_Dizisi
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Lütfen sayı dizisinin kaç basamaklı olacağının giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] fibonacciDizisi= new int [n];//n=10 için 0,1,2,3,4,5,6,7,8,9,10
            fibonacciDizisi[0] = 0;              //i=2 için  2,3,4,5,6,7,8,9,10,11,12
            fibonacciDizisi[1] = 1;
            Console.WriteLine("1");
            for (i = 2;i<=n;i++)
            {
                fibonacciDizisi[i] = fibonacciDizisi[i - 1] + fibonacciDizisi[i - 2];
                Console.WriteLine(fibonacciDizisi[i]);

            }          
        }
    }
}
