class WriteAllText
{
    public static async Task ExampleAsync()
    {
        string Writetext = "A class is the most powerful data type in C#. Like a structure";

        File.WriteAllText(@"C:\Users\uczen\ok.txt", Writetext);
    }
}

class ReadFromFile
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText(@"C:\Users\uczen\ok.txt");
        Console.WriteLine(text);
    }
}
