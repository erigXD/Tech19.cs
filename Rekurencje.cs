// Rekurencja - uwaga, nie uruchamiać!
void Rekurencja()
{
    Console.WriteLine("Yo");
    Rekurencja();
}

// Rekurencja();

/*void reku1(int n)
{
    if (n == 0) return;
    Console.WriteLine(n);
    reku1(n - 1);
}

reku1(5);*/

/*void reku1(int n)
{
    if (n == 0) return;
    reku1(n - 1);
    Console.WriteLine(n);
}

reku1(5);*/

int reku1(int n)
{
    int w;
    if (n == 1) return 1;
    w = reku1(n / 2);
    if (n % 2 == 0) w = w * 2;
    else w = w * 3;
    return w;

}

/*
r(1) => 1
r(2) => 2
r(4) => 4
r(9) => 12
r(18) => 24
r(37) => 72
r(75) => 216
*/
