using System;

class Program
{
    static void Main(string[] args)
    {
        char carattere = 'A';
        Console.WriteLine(char.IsLetter(carattere));
        Console.WriteLine(char.IsDigit(carattere));
        Console.WriteLine(char.ToLower(carattere));
        carattere = char.ToLower(carattere);
        Console.WriteLine(carattere);

        char simbolo = '@';
        if(char.IsPunctuation(simbolo))
        {
            Console.WriteLine($"{simbolo} è un simbolo");
        }

        Console.WriteLine(char.GetNumericValue(simbolo));
    }
}