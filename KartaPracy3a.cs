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
                Console.Write("*-|");
            }*/

            // Tabliczka mnożenia
            /*for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }*/

            // Zad 2
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write("*" * i);
                if (i % 2 == 0)
                {
                    Console.Write("||");
                }
                else
                {
                    Console.Write("--");
                }
            }*/

            // Zad Bonus
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int k = n-i-1; k < n; k++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int k = n-i-1; k < n; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
