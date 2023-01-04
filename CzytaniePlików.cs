using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("c:\\ok\\liczby.txt");

        int[] T = new int[500];

        /*while (!sr.EndOfStream)
        {
            Console.Write(sr.ReadLine() + " ");
        }*/

        for (int i = 0; i < 500; i++)
        {
            T[i] = int.Parse(sr.ReadLine());
        }

        /*Wersja 1*/

        /*for (int i = 0; i < 500; i++)
        {
            Console.Write(T[i] + "\t");
        }*/

        /*int[] P = new int[] { 1, 3, 9, 27, 81, 243, 729, 2197, 6561, 19683, 59049 };
        int ilość = 0;
        for (int i = 0; i < 500; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (T[i] == P[j])
                {
                    ilość++;
                    break;
                }
            }
        }
        Console.WriteLine(ilość);*/

        /*Wersja 2*/

        /*int ilość = 0;
        for (int i = 0; i < 500; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (T[i] == Math.Pow(3, j))
                {
                    ilość++;
                    break;
                }
            }
        }
        Console.WriteLine(ilość);*/

        /*Wersja 3*/

        /*int x;
        int ilość = 0;
        for (int i = 0; i < 500; i++)
        {
            x = T[i];
            while (x > 1)
            {
                if (x % 3 == 0)
                {
                    x = x / 3;
                }
                else
                {
                    break;
                }
            }
            if (x == 1)
            {
                ilość++;
            }
        }
        Console.WriteLine(ilość);*/
    }
}
