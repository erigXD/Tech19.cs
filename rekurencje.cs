// Idea

/*for (int i = 1; i <= 5; i++)
{
    Console.Write(i + " ");
}*/

/*Console.WriteLine();
Console.WriteLine();
void reku1(int n)
{
    if (n > 5) return;
    Console.Write(n + " ");
    reku1(n + 1);
}
reku1(1);

void reku2(int n)
{
    if (n == 6) return; // 6 tu się skończy
    reku2(n + 1); // dochodzi do tego i czeka aż się wykona i rośnie 1,2,3,4,5 aż w końcu 6 da returna i to wróci do 5 potem do 4 itd.
    Console.Write(n + " "); // żeby mogło się wykonać i wyjdzie 5 4 3 2 1
}

reku2(1);

void reku3(int n)
{
    if (n == 0) return;
    Console.WriteLine(n + " "); // 4 3 2 1
    reku3(n - 1);
    Console.WriteLine(n + " "); // 1 2 3 4
}
reku3(4);*/

// 3. Napisz algorytm sumujący cyfry iteracyjnie i rekurencyjnie

/*int suma = 0;

for (int i = 0; i < 10; i++)
{
    suma += i;
}

int r3(int n)
{
    if (n == 0) return 0;
    return r3(n - 1) + n;
}
Console.WriteLine(r3(9));*/

// 4. Napisz algorytm sumujący liczby dwucyfrowe parzyste iteracyjnie i rekurencyjnie

/*int suma = 0;

for (int i = 10; i < 100; i += 2)
{
    suma += i;
}
Console.WriteLine(suma);

int r4(int n)
{
    if (n < 10) return 0;
    return r4(n - 2) + n;
}

Console.WriteLine(r4(98));*/

// 5. Oblicz sumę n pierwszych wyrazów ciągów:
// a) 3, 6, 9, 12, 15, 18, 21 ... <=> 3+6+9+12 = 3(1+2+3+4)

// Sposób 1 - od razu policzę sumę w rekurencji

/*int n = 4;

int r5a1(int n)
{
    if (n == 1) return 3;
    return r5a1(n - 1) + 3 * n;
}
Console.WriteLine(r5a1(n));

// Sposób 2

int r5a2(int n)
{
    if (n == 1) return 3;
    return r5a2(n - 1) + 3;
}
Console.WriteLine(r5a2(n));

int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma += r5a2(i);
}
Console.WriteLine(suma);*/

// b) 12, 23, 34, 45, 56 ...

/*int n = 4;
int r5b(int n)
{
    if (n == 1) return 12;
    return r5b(n - 1) + 11;
}

int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma += r5b(i);
}
Console.WriteLine(suma);*/

// c) 2, 6, 18, 54 ...

/*int n = 4;

int r5c(int n)
{
    if (n == 1) return 2;
    return r5c(n - 1) * 3;
}

int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma += r5c(i);
}
Console.WriteLine(suma);*/

// d)

/*int n = 5;

int r5d(int n)
{
    if (n == 1) return 2;
    return r5d(n - 1) + 2 * (n - 1) + 1;
}

int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma += r5d(i);
}
Console.WriteLine(suma);*/

// 6. Wypisz n pierwszych wyrazów ciągu:
// a) 1,5 1 0,5 -0,5 -2 -4,5 -8,5 -15

int n = 4;
double r6a(int n)
{
    if (n == 1) return 1.5;
    if (n == 2) return 1;
    if (n == 3) return 0.5;
    return r6a(n - 1) * 2 - r6a(n-3);
}

for (int i = 1; i < 10; i++)
{
    Console.Write(r6a(i) + " ");
}
