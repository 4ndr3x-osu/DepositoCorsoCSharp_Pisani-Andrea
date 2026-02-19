using System;

class Program
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        int count=0;
        Console.WriteLine("Scrivi una frase: ");
        string frase = Console.ReadLine();

        foreach(char carattere in frase)
        {
            if(char.IsDigit(carattere))
            {
                count++;
            }
        }
        Console.WriteLine($"Nella frase ci sono {count} cifre");



        //-----ESERCIZIO 2
        Console.WriteLine("Scrivi una frase: ");
        frase = Console.ReadLine();
        string frase2 = "a";

        foreach(char carattere in frase)
        {
            if(!char.IsWhiteSpace(carattere))
            {
                frase2 += carattere;
            }
        }
        Console.WriteLine($"Frase senza spazi: {frase2}");



        //-----ESERCIZIO 3
        Console.WriteLine("Scrivi una frase: ");
        frase = Console.ReadLine();
        string voc = "a e i o u à è é ì ò ù";
        string[] vocali = voc.Split(" ");
        count = 0;
        foreach(char carattere in frase)
        {
            for(int i = 0; i < vocali.Length; i++)
            {
                if(carattere == char.ToLower(char.Parse(vocali[i])))
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Nella frase ci sono {count} vocali");



        //-----ESERCIZIO 5
        int[] numero = new int[4]; // rispettivamente: n. di parole, caratteri alfabetici, spazi e segni di punteggiatura

        Console.WriteLine("Scrivi una frase: ");
        frase = Console.ReadLine();

        string[] frase_arr = frase.Split(" ");
        numero[0] = frase_arr.Length;

        foreach(char carattere in frase)
        {
            if(char.IsLetter(carattere))
            {
                numero[1] = numero[1] + 1;
            }
            if(char.IsWhiteSpace(carattere))
            {
                numero[2] = numero[2] + 1;
            }
            if(char.IsPunctuation(carattere))
            {
                numero[3] = numero[3] + 1;
            }
        }

        Console.WriteLine($"N° parole: {numero[0]}");
        Console.WriteLine($"N° lettere: {numero[1]}");
        Console.WriteLine($"N° spazi vuoti: {numero[2]}");
        Console.WriteLine($"N° punteggiatura: {numero[3]}");

    }
}