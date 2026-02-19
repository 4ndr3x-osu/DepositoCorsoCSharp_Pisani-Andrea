using System;

class Program()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dammi un numero: ");
        string n1 = Console.ReadLine();

        Console.WriteLine("Dammi un'altro numero: ");
        string n2 = Console.ReadLine();

        int a = int.Parse(n1); // Conversione da stringa a int
        int b = int.Parse(n2);

        Console.WriteLine("Operatori aritmetici: ");
        Console.WriteLine($"a={a}, b={b}");
        Console.WriteLine($"Addizione: a + b = {a + b}");
        Console.WriteLine($"Sottrazione: a - b = {a - b}");
        Console.WriteLine($"Moltiplicazione: a * b = {a * b}");
        Console.WriteLine($"Divisione: a / b = {a / b}");
        Console.WriteLine($"Modulo (resto): a % b = {a % b}");
        Console.WriteLine("Operatori assegnamento:");
        Console.WriteLine($"Incremento: a++ = {a++}");
        Console.WriteLine($"Ora a = {a}");
        Console.WriteLine($"Decremento: b-- ={b--}");
        Console.WriteLine($"Ora b = {b}");
    }
}
