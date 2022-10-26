using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1
            /*for (int i = 1; i < 31; i++)
            {
                Console.WriteLine(i);
            }*/

            // Zad 2
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i+=2)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }*/

            // Zad 3
            /*for (int i = 1000; i < 10000; i+=379)
            {
                Console.WriteLine(i);
            }*/

            // Zad 4
            /*for (int i = 100; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            // Zad 5
            /*int nliczb = int.Parse(Console.ReadLine());
            List<int> Liczby = new List<int>();
            for (int i = 1; i < nliczb+1; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Liczby.Add(n);
            }
            Console.WriteLine(Liczby.Sum());*/

            // Zad 6
            /*int k = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 2; i < (k * 2) + 2; i += 2)
            {
                suma += i;
            }
            Console.WriteLine(suma);*/

            // Zad 7
            /*int m = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 11; i < (m * 2) + 11; i += 2)
            {
                suma += i;
            }
            Console.WriteLine(suma);*/

            // Zad 8
            /*double W0 = int.Parse(Console.ReadLine());
            double L = int.Parse(Console.ReadLine());
            L = L * 12;
            double W1 = W0;
            for (int i = 0; i < L; i++)
            {
                W0 = W0 + (W1 * 0.005);
            }
            Console.WriteLine(W0);*/

            // Zad 9
            /*int n = int.Parse(Console.ReadLine());
            int a = 21;
            int suma = 0;
            for (int i = 0; i < n+1; i++)
            {
                for (int i1 = 0; i1 < i; i+=a)
                {
                    suma += a;
                    a += 100;
                }
            }
            Console.WriteLine(suma);*/

            // Zad 10
            /*for (int i = 1; i < 1000; i++)
            {
                if (Math.Pow(i % 10, 2) == i)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    if (Math.Pow(i % 100, 2) == i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }*/

            Console.ReadKey();
        }
    }
}
