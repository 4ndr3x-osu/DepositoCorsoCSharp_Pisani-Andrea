using System;

class Program()
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 15;

        Console.WriteLine("Operatori logici: ");
        Console.WriteLine($"AND: {a > b && a >= 10}"); //TRUE
        Console.WriteLine($"OR: {a > b || a >= 10}"); //TRUE
        Console.WriteLine($"NOT: {!(a < b)}"); //FALSE
    }
}
