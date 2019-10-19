using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, suma = 0;
            Console.Write("Podaj liczbę n:");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                suma += n % 10;
                n /= 10;
            }
            Console.Write("Suma cyfr tej liczby wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
