using System;

class Program()
{
    public static readonly String Nome = "Andrea"; // Costante readonly
    const float PI_GRECO = 3.14159265359f; // Costante float
    static void Main(string[] args)
    {
//-----ESEMPIO VARIABILI E TIPI DI DATO

        int numero = 10; // Numero intero
        float decimaleFloat = 3.14f; // Numero a virgola mobile
        double decimaleDouble = 3.14d; // Numero a virgola mobile
        char lettera = 'A'; // Singolo carattere
        bool condizione = true; // Bit 0 (false) o 1 (true)
        string saluto = "Ciao a tutti!"; // Molteplici caratteri
        
        Console.WriteLine("Numero: " + numero);
        Console.WriteLine("Decimale (float): " + decimaleFloat);
        Console.WriteLine("Decimale (double): " + decimaleDouble);
        Console.WriteLine("Lettera: " + lettera);
        Console.WriteLine("Condizione: " + condizione);
        Console.WriteLine("Saluto: " + saluto);

//-----COSTANTI

        Console.WriteLine("Pi greco: " + Program.PI_GRECO);
        Console.WriteLine("Ciao, mi chiamo " + Program.Nome);
    }
}