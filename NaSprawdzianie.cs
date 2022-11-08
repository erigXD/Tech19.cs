using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1 - Light Hard - Napisz program który obliczy sumę n pierwszych liczb fibonacciego

            /*int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                temp = a;
                a= b;
                b = temp + b;
                suma = suma + b;
            }
            Console.WriteLine(suma);*/

            // Zad 2 - Medium - Napisz program sumujący w początkowych liczb trzycyfrowych
            /*int suma = 0;
            int w = int.Parse(Console.ReadLine());
            for (int i = 100; i < w + 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);*/

            // Zad 3 - Hard - Sprawdź czy wpisana przez usera liczba jest doskonała
            int d = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i < d; i++)
            {
                if (d % i == 0)
                {
                    suma += i;
                }
            }
            if (suma == d)
            {
                Console.WriteLine("doskonała");
            }
            else
            {
                Console.WriteLine("nie doskonała");
            }

            Console.ReadKey();
        }
    }
}
