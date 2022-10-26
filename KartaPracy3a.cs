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

            // Zad 3
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine("*");
            }*/

            // Zad 5
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (j == n / 2 + 1)
                    {
                        Console.Write("*");
                    }
                    else if (i == n / 2 + 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/

            // Zad 6
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == n - j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            // Zad 7
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == 1 || j == 1 || j == n || i == n || (i == n/2 + 1 && j == n/2 + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/

            // Zad Bonus
            /*int n = int.Parse(Console.ReadLine());
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
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int k = n - i - 1; k < n; k++)
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
                for (int k = n - i - 1; k < n; k++)
                {
                    Console.Write(" ");
                }
            }*/

            /*int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + i; j++)
                {
                    if (i <= n - j + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + i; j++)
                {
                    if (n - j < i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/

            
            Console.ReadKey();
        }
    }
}
