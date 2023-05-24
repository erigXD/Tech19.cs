using System;
using System.ComponentModel;

int n = int.Parse(Console.ReadLine());

//Zad 1

int Hiszpańskie(int n)
{
    int jednosci = (n % 100) % 10;
    int dziesietne = (n % 100) / 10;
    int setki = n / 100;

    if (jednosci < dziesietne && jednosci < setki)
    {
        return jednosci;
    }
    if (setki < dziesietne && setki < jednosci)
    {
        return setki;
    }
    if (dziesietne < jednosci && dziesietne < setki)
    {
        return dziesietne;
    }
    return 0;
}

Console.WriteLine(Hiszpańskie(174));

//Zad 2 

int rekua(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 3;
    if (n == 3) return 5;

    return 2 * rekua(n - 1) + rekua(n - 2) + rekua(n - 3);
}

for (int i = 1; i < n + 1; i++)
{
    Console.WriteLine(rekua(i));
}

//Zad 3
StreamWriter sw = new StreamWriter(@"boki.txt");
Random r = new Random();

for (int i = 0; i < 15; i++)
{
    sw.WriteLine(r.Next(1,10) + " " + r.Next(1,10));
}
sw.Close();

string[] lines = System.IO.File.ReadAllLines(@"boki.txt");

int suma = 0;
for (int i = 0; i < 15; i++)
{
    string[] h = lines[i].Split(" ");
    int e = int.Parse(h[0]);
    int f = int.Parse(h[1]);
    Console.WriteLine(h[0] + " " + h[1]);
    suma += e * f / 2;
}

Console.WriteLine(suma);
