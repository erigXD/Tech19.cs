using System;

class Program
{
    public static void Main(string[] args)
    {
        // Zad 2
        /*int suma = 0;
        for (int i = 100; i < 1000; i++)
        {
            if (i % 8 == 0 && i % 16 == 0)
            {
                suma += 1;
            }
        }
        Console.WriteLine(suma);*/

        // Zad 3
        /*int podzielnik = 0;
        for (int i = 99; i > 9; i--)
        {
            if (i % 7 == 0)
            {
                podzielnik = i;
                break;
            }
        }

        int suma = 0;
        for (int j = 100; j < 1000; j++)
        {
            if (j % podzielnik == 0)
            {
                suma += j;
            }
        }
        Console.WriteLine(suma);*/

        // Zad 4

        /*int suma = 0;
        int cd = 0;
        int cj = 0;
        for (int i = 10; i < 100; i++)
        {
            cd = i / 10;
            cj = i % 10;

            if (cd >= 2 * cj)
            {
                suma += 1;
            }
        }
        Console.WriteLine(suma);*/

        // Zad 5
        /*int suma = 0;
        int ilosc = 0;
        int cd = 0;
        int cj = 0;
        int cs = 0;
        for (int i = 100; i < 1000; i++)
        {
            cs = i / 100;
            cd = i % 100 / 10;
            cj = i % 10;

            if (cs > (cd + cj))
            {
                suma += i;
                ilosc += 1;
            }
        }
        Console.WriteLine(suma);
        Console.WriteLine(ilosc);*/

        // Zad 7
        /*int suma = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 100 + (37 * n); i < 100; i--)
        {
            if (i % 37 == 0)
            {
                suma += i;
            }
        }*/

        // Zad 8

        /*int suma = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <+ n; i++)
        {
            suma = suma + ((3 * i - 1) * ((int)Math.Pow(-1, i - 1)));
        }
        Console.WriteLine(suma);*/

    }
}
