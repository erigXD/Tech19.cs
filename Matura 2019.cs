// Zadanie 4.1
/*StreamReader sr = new StreamReader("c:\\Zad4\\liczby_przyklad.txt");*/

string[] liczby = System.IO.File.ReadAllLines(@"C:\\Zadanie4\\liczby_przyklad.txt");

StreamWriter wynik = new(@"C:\\Zadanie4\\wyniki4.txt");

bool czyPierwsza(int n)
{
    for (int i = 2; i < n/2+1; i++)
    {
        if (n%i == 0)
        {
            return false;
        }
    }
}

foreach (string i in liczby)
{
    for (int j = 2; j < i - 1; j++)
    {
        if (i % j == 0)
        {
            wynik.WriteLine(i);
        }
    }
}

wynik.WriteLine("Zad4.1");

foreach (string item in liczby)
{
    Console.WriteLine(item);
}

wynik.Close();
