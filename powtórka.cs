// Euklides odejmowanie

int EuklidesOdejmowanie(int a, int b)
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

Console.WriteLine(EuklidesModulo(x, y));

// Sortowanie Bąbelkowe

void SortBubble(int[] T)
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
}
