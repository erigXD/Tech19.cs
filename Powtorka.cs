// Euklides odejmowanie

using System.Collections;
using System.Diagnostics.CodeAnalysis;

/*int EuklidesOdejmowanie(int a, int b)
{
    while (a != b)
    {
        if (a > b) a -= b;
        if (b > a) b -= a;
    }
    return b;
}

int x, y;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

Console.WriteLine(EuklidesOdejmowanie(x, y));

// Euklides modulo

int EuklidesModulo(int a, int b)
{
    int temp;
    while (b > 0)
    {
        temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

Console.WriteLine(EuklidesModulo(x, y));*/

// Sortowanie Bąbelkowe

/*void SortBubble(int[] T)
{
    int n = T.Length;
    int pom;
    for (int i = n - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (T[j] > T[j+1])
            {
                pom = T[j];
                T[j] = T[j+1];
                T[j + 1] = pom;
            }
        }
    }
}

Random r = new Random();
int n = 20;
int[] T = new int[20];
for (int i = 0; i < n; i++)
{
    T[n] = r.Next(1, 100);
}

for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");
SortBubble(T);

for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}*/

// wypisz wszystkie pary liczb zaprzyjaźnionych z przedziału od 1 do 10000

/*int SumaDzielnikówWłaściwych(int n)
{
    int suma = 0;
    for (int i = 0; i < n / 2; i++)
    {
        if (n % i == 0)
        {
            suma += i;
        }
    }
    return suma;
}

int pom;
for (int i = 0; i < 10000; i++)
{
    pom = SumaDzielnikówWłaściwych(i);
    if (i == SumaDzielnikówWłaściwych(pom) && i != pom)
    {
        Console.WriteLine(i + " " + pom);
    }
}
*/
// Listy - Tablice - w tablicy 30 losowych liczb trzycyfrowych znajdź ilość wielokrotności liczby 17 (zapisz te liczby do listy wynikowej)

/*Random r = new Random();
int n = 30;
int[] T = new int[30];
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(100, 1000);
}

for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");

List<int> list = new List<int>();
foreach (var t in T)
{
    if (t % 17 == 0) list.Add(t);
}
foreach (var l in list)
{
    Console.Write(l + " ");
}
*/
// Macierz - wypisz sumy kolejnych ramek w macierzy kwadratowej o n parzystym

Random r = new Random();
int n = 8;
int[,] M = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        M[i, j] = r.Next(1, 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(M[i, j] + " ");
    }
    Console.WriteLine("");
}

// Sposób 1 - sumami

List<int> S = new List<int>();
int suma;
for (int i = 1;i <= n/2; i++)
{
    suma = 0;
    for (int j = n/2 - i; j < n/2 + i; j++)
    {
        for (int k = n / 2 - i; k < n / 2 + i; k++)
        {
            suma = suma + M[j, k];
        }
    }
    S.Add(suma);
}
Console.WriteLine("\n");
foreach (var s in S)
{
    Console.WriteLine(s);
}
int[] T = S.ToArray();
for (int i = 0; i < S.Count; i++)
{
    Console.WriteLine(T[i] - T[i - 1]);
}
