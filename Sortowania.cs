// Sortowania przez porównanie

// Stworzenie tablicy 20 losowych liczb <1;20>
Random r = new Random();
int[] T = new int[20];
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

int n = T.Length;
int temp, j;
for (int i = 1; i < n; i++)
{
    temp = T[i];
    j = i - 1;
    while (j > 0 && temp < T[j])
    {
        T[j] = T[j - 1];
        j--;
    }
    T[j] = temp;
}

// Sortowania w czasie liniowym

// 4. Przez zliczanie

// 5. Kubełkowe

// Dziel i zwyciężaj 

// 6. Przez scalanie

// 7. Quicksort Hoare

// 8. Quicksort Lomuto

// Wyświetlenie posortowanej tablicy
Console.WriteLine("\n");
for (int i = 0; i < 20; i++)
{
    Console.Write(T[i] + " ");
}
