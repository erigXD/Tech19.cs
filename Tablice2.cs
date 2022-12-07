using System;

class Program
{
    public static void Main(string[] args)
    {
        // Stwórz tablicę 100 losowych liczb 2-cyfrowych
        // podaj sumę liczb parzystych i ilość liczb nieparzystych
        /*int[] T = new int[100];
        Random r = new Random();

        for (int i = 0; i < T.Length; i++)
        {
            T[i] = r.Next(10, 100);
        }

        int sumapar = 0;
        int sumanpar = 0;
        for (int i = 0; i < T.Length; i++)
        {
            if (T[i] % 2 == 0)
            {
                sumapar += 1;
            }
            else
            {
                sumanpar += 1;
            }
        }*/

        // Tablice 2-Wymiarowe
        // inicjowanie tablic

        /*int[,] T2D = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(T2D[i, j] + "\t");
            }
            Console.WriteLine();
        }*/

        // Zadeklaruj macierz a'la sudoku

        /*int[,] M = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // Stwórz losową
        int[,] N = new int[4,4];
        Random r = new Random();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                N[i, j] = r.Next(10, 100);
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(N[i, j] + "\t");
            }
            Console.WriteLine();
        }*/

        // wymiary macierzy

        /*int[,] M = new int[3, 5]; // new int[x, y]
        Console.WriteLine(M.Length);
        Console.WriteLine(M.GetLength(0)); // zwraca długość każdego wymiaru, który wybierzemy
        Console.WriteLine(M.GetLength(1));*/

        // wypełnij macierz 3x5 liczbami dwucyfrowymi korzystając z GetLength()
        
        /*int[,] M = new int[3, 5];
        Random r = new Random();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                    M[i, j] = r.Next(10, 100);
            }
        }

        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {
                Console.Write(M[i, j] + "\t");
            }
        }*/

    }
}
