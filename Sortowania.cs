// Sortowania przez porównanie

// Stworzenie tablicy 20 losowych liczb <1;20>
using System;

Random r = new Random();
int[] T = new int[20];
int n = T.Length;
for (int i = 0; i < 20; i++)
{
    T[i] = r.Next(1, 20);
    Console.Write(T[i] + " ");
}

// 1. Bąbelkowe

// od prawej rosnąco

/*int n = T.Length;
int temp;
for (int i = n - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (T[j] > T[j + 1])
        {
            temp = T[j];
            T[j] = T[j + 1];
            T[j + 1] = temp;
        }
    }
}*/

// 2. Przez wybór

// wybieramy najmniejszy i wstawiamy go na początek

/*int mi;
int temp;
for (int i = 0; i < T.Length; i++)
{
    mi = i;
    for (int j = i + 1; j < T.Length; j++)
    {
        if (T[j] < T[mi])
        {
            mi = j;
        }
    }
    temp = T[i];
    T[i] = T[mi];
    T[mi] = temp;
}*/

// wybieramy najmniejszy i wstawiamy go na koniec
/*int mi;
int n = T.Length;
int temp;
for (int i = n - 1; i > 0; i--)
{
    mi = i;
    for (int j = 0; j < i; j++)
    {
        if (T[j] < T[mi])
        {
            mi = j;
        }
    }
    temp = T[i];
    T[i] = T[mi];
    T[mi] = temp;
}*/

// 3. Przez wstawianie

/*int n = T.Length;
int temp, j;
for (int i = 1; i < n; i++)
{
    temp = T[i];
    j = i - 1;
    while (j >= 0 && temp < T[j])
    {
        T[j] = T[j - 1];
        j--;
    }
    T[j] = temp;
}*/

// Sortowania w czasie liniowym

// 4. Przez zliczanie

/*int[] L = new int[20];
int j = 0;

for (int i = 0; i < T.Length; i++)
{
    L[T[i]]++;
}
Console.WriteLine("\n");
for (int i = 0; i < L.Length; i++)
{
    Console.Write(L[i] + " ");
}

for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 0)
    {
        for (int k = 0; k < L[i]; k++)
        {
            T[j] = i;
            j++;
        }
    }
}
*/

// 5. Kubełkowe

// Dziel i zwyciężaj

// 6. Przez scalanie

void Scalaj(int lewy, int prawy)
{
    int[] pom = new int[n];
    for (int a = 0; a < n; a++)
    {
        pom[a] = T[a];
    }
    int i, i_lewy, i_prawy;
    int srodek = (lewy + prawy) / 2;
    i = lewy; // indeks tabeli
    i_lewy = lewy;
    i_prawy = srodek;
    while (i_lewy <= srodek && i_prawy < prawy)
    {
        if (pom[i_lewy] < pom[i_prawy])
        {
            T[i] = pom[i_lewy];
            i_lewy++;
        }
        else
        {
            T[i] = pom[i_prawy];
            i_prawy++;
        }
        i++;
    }
    if (i_lewy > srodek)
    {
        while (i_prawy > prawy)
        {
            T[i] = pom[i_prawy];
            i_prawy++;
            i++;
        }
    }
    else
    {
        while (i_lewy < prawy)
        {
            T[i] = pom[i_lewy];
            i_lewy++;
            i++;
        }
    }
}

void Sortuj(int lewy, int prawy)
{
    int srodek = (lewy = prawy) / 2;
    if (lewy < srodek)
    {
        Sortuj(lewy, srodek);
    }
    if (srodek + 1 < prawy)
    {
        Sortuj(srodek + 1, prawy);
    }
}

// 7. Quicksort Hoare
/*int QuickSortHoare(int[] T, int lewy, int prawy)
{
    int i = lewy;
    int j = prawy;
    int pivot = T[(lewy + prawy) / 2];

    while (i <= j)
    {
        while (T[i] < pivot)
        {
            i = i + 1;
        }
        while (T[j] > pivot)
        {
            j = j - 1;
        }
        if (i <= j)
        {
            int temp = T[i];
            T[i] = T[j];
            T[j] = temp;
        }
    }
    if (lewy < j)
    {
        Console.WriteLine(QuickSortHoare(T, lewy, j));
    }
    if (prawy > i)
    {
        Console.WriteLine(QuickSortHoare(T, i, prawy));
    }
    Console.WriteLine(T);
    return 0;
}*/

// 8. Quicksort Lomuto

// Wyświetlenie posortowanej tablicy
Console.WriteLine("\n");
for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}

