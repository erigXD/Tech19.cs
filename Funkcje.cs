// Funkcje są nam znane z mat i z inf: f(x) WriteLine()

/*
typ_zwracany nazwa(parametry)
{
    instrukcje
}
*/

/*
void przywitaj()
{
    Console.WriteLine("Witam");
}
przywitaj();
przywitaj();
*/

// Napisz funkcje, która oblicza sumę przekazanych przez parametr 3 liczb

using System.ComponentModel;

void oblicz(int a, int b)
{
    Console.WriteLine(a + b);
}
oblicz(4, 7);

int suma2(int x, int y)
{
    return x + y;
}
Console.WriteLine(suma2(4, 7));

// Napisz funkcję Dajrabat(cena, rabat) na towar

double Dajrabat(double cena, int rabat)
{
    return cena * (1 - rabat / 100d);
}
Console.WriteLine(Dajrabat(100, 25));
