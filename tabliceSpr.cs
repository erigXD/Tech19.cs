// Zad 1

int[] T = new int[20];
Random r = new Random();
int i = 0;

while (T[19] > 0)
{
    int liczba = r.Next(100, 1000);
    int jednosci = liczba % 100 % 10;
    int dziesiatki = liczba % 100 / 10;
    int setki = liczba / 100;
    int suma_cyfr = jednosci + dziesiatki + setki;


    if (suma_cyfr >= 18 && liczba % 2 != 0 || liczba % 7 != 0)
    {
        T[i] = liczba;
        i += 1;
    }
}

foreach (var item in T)
{
    Console.Write(item + " ");
}

for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i]);
}

// Zad 2
int[] T1 = new int[90];
int[] L = new int[90];
Random r = new Random();

for (int i = 0; i < T1.Length; i++)
{
    T1[i] = r.Next(10, 100);
    L[T1[i]] += 1;
}

for (int i = 0; i < L.Length; i++)
{
    L[i] = 0;
}


int suma = 0;
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 0)
    {
        suma += T1[i];
    }
}

Console.WriteLine($"Suma liczb których nie ma w tej tablicy: {suma}");

// Zad 3
Random r = new Random();
int[,] M = new int[15, 15];

for (int i = 0; i < 15; i++)
{
    for (int j = 0; j < 15; j++)
    {
        M[i, j] = r.Next(0, 10);
    }
}

int suma = 0;
for (int i = 0; i < 15; i++)
{
    for (int j = 0; j < 15; j++)
    {
        if (i == 0 || j == 0)
        {
            suma += M[i, j];
            M[i, j] = 0;
        }
        if (i == 14 || j == 14)
        {
            suma += M[i, j];
            M[i, j] = 0;
        }
    }
}

Console.WriteLine($"suma cyfr na ramce: {suma}");
