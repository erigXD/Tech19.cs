// Zadanie 4.1
/*StreamReader sr = new StreamReader("c:\\Zad4\\liczby_przyklad.txt");*/

string[] liczby = System.IO.File.ReadAllLines(@"C:\\Zadanie4\\liczby_przyklad.txt");

StreamWriter wynik = new(@"C:\\Zadanie4\\wyniki4.txt");

bool czyPierwsza(int n)
{
    for (int i = 2; i < n - 1; i++)
    {
        if (n % i == 0 && n < 5000 && n > 100)
        {
            return false;
        }
        return true;
    }
}

foreach (string i in liczby)
{
    if (czyPierwsza(Convert.ToInt32(i)) == true)
        {
            wynik.WriteLine(i);
        }
}

//wynik.WriteLine("Zad4.1");

foreach (string item in liczby)
{
    Console.WriteLine(item);
}

wynik.Close();
