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
            // Zad 1

            /*int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(i, 3) + " ");
            }*/

            // Zad 2

            /*for (int i = 0; i < 1000; i += 15) //albo step: i = i + 15
            {
                Console.WriteLine(i + " ");
            }*/

            // Zad 3

            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }*/

            // Zad 4

            /*int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);*/

            // Zad 5

            /*int x;
            int n = int.Parse(Console.ReadLine());
            int suma = n * (n + 1) / 2;

            for (int i = 0; i < n-1; i++)
            {
                int x = int.Parse(Console.ReadLine());
                suma = suma - x;
            }
            Console.WriteLine(suma);*/

            // Zad 6

            /*int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;
            int temp;
            Console.Write($"{a} {b} ");
            for (int i = 0; i < n; i++)
            {
                temp = a;
                b = temp + b;
            }
            Console.Write(b + " ");*/

            Console.ReadKey();
        }
    }
}
