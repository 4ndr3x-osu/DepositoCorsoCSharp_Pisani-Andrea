using System;

class Program()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dammi un numero: ");
        string n1 = Console.ReadLine();

        Console.WriteLine("Dammi un'altro numero: ");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1); // Conversione da stringa a int
        int numero2 = int.Parse(n2);

        Console.WriteLine($"Somma: {numero1 + numero2}");
    }
}
