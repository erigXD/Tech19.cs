// rekurencja:

// typ_wyniku nazwa (arg)
// {
//   instrukcje
//   return  
// }
using System;
using System.Collections;

void przywitaj()
{
    Console.WriteLine("Cześć");
}

przywitaj();

// funkcja obliczająca sumę 2 podanych liczb

void suma(int a, int b)
{
    Console.WriteLine(a + b);
}

suma(4, 6);

// funkcja odwracająca stringa

void odwrocStringa(string napis)
{
    char[] chars = napis.ToCharArray();
    Array.Reverse(chars);
    Console.WriteLine(new string(chars));
}
odwrocStringa("KOT");

// funkcja, która przyjmuje dowolną ilość argumentów

// suma wszystkich argumetów (tyle ile ich jest)
void bigSuma(int[] T)
{
    int suma = 0;
    foreach (int item in T)
    {
        suma += item;
    }
    Console.WriteLine(suma);
}

bigSuma(new int[] { 4, 7, 8, 9 });

// dla sportu można porobić wszystkie zadania kart pracy w wersji funkcji
