using System;

class Program
{
    static void Main(string[] args)
    {
        int[] voti = new int[5];

        for (int i = 0; i < voti.Length; i++)
        {
            Console.WriteLine($"Inserisci il voto {i + 1}: ");
            voti[i] = int.Parse(Console.ReadLine());
        }

        int somma = 0;
        for (int i = 0; i < voti.Length; i++)
        {
            somma += voti[i];
        }

        float media = somma / voti.Length;
        Console.WriteLine($"La media dei voti è: {media}");

        Console.WriteLine("Scrivi una parola: "); //ARRAY DI LETTERE
        string parola = Console.ReadLine();
        foreach (char carattere in parola)
        {
            Console.WriteLine(carattere);
        }

        Console.WriteLine("Lista dei voti: "); //ARRAY DI NUMERI
        foreach(int num in voti)
        {
            Console.WriteLine(num);
        }
    }
}