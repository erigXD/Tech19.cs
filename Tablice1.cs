int n = 10;
int pocz = 1;
int kon = 20;
int[] T = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(pocz, kon);
}

/*for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}*/

// Zad 1
int max = pocz;
for (int i = 0; i < n; i++)
{
    if (T[i] > max)
    {
        max = T[i];
    }
}
Console.WriteLine(max);

// Zad 2
int min = kon;
for (int i = 0; i < n; i++)
{
    if (T[i] < min)
    {
        min = T[i];
    }
}
Console.WriteLine(min);

// Zad 3
int sumamax = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] > max)
    {
        sumamax += 1;
    }
}
Console.WriteLine(sumamax);

// Zad 4
int sumamin = kon;
for (int i = 0; i < n; i++)
{
    if (T[i] < min)
    {
        sumamin += 1;
    }
}
Console.WriteLine(sumamin);

// Zad 5
for (int i = 0; i < n; i++)
{
    if (T[i] > max)
    {
        max = T[i];
    }
    if (T[i] < min)
    {
        min = T[i];
    }
}
Console.WriteLine(max - min);

// Zad 6
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += T[i];
}
Console.WriteLine(suma);

// Zad 7
for (int i = 0; i < n; i++)
{
    suma += T[i];
}
Console.WriteLine(suma/n);

// Zad 8
int sumapar = 0;
int sumaniepar = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] % 2 == 0)
    {
        sumapar += 1;
    }
    else
    {
        sumaniepar += 1;
    }
}

if (sumapar > sumaniepar)
{
    Console.WriteLine("parzystych jest więcej");
}
else
{
    Console.WriteLine("nieparzystych jest więcej");
}

// Zad 9
int ilepierwszych = 0;
for (int i = 0; i < n; i++)
{
    if ()
    {
        
    }
    else
    {
        ilepierwszych += 1;
    }
}
Console.WriteLine($"Jest {ilepierwszych} w tablicy");

// Zad 10
int vicemax = 0;
int vicemin = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] > max)
    {
        max = T[i];
    }
    if (T[i] < min)
    {
        min = T[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (T[i] < max)
    {
        vicemax = T[i];
    }
    if (T[i] < min)
    {
        vicemin = T[i];
    }
}
