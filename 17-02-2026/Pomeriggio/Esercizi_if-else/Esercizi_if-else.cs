using System;

class Program()
{
    static void Main(string[] args)
    {
        //----- ESERCIZIO 1
        Console.WriteLine("Dammi un numero: ");
        int n1 = int.Parse(Console.ReadLine());
        
        if(n1 % 2 == 0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("Il numero è dispari");
        }



        //-----ESERCIZIO 2
        const int PASSWORD = 12345678;
        Console.WriteLine("Inserire password: ");
        int pass = int.Parse(Console.ReadLine());

        if(pass == PASSWORD)
        {
            Console.WriteLine("Accesso consentito");
        }
        else
        {
            Console.WriteLine("Accesso negato");
        }



        //-----ESERCIZIO 3
        Console.WriteLine("Inserire un numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserire un'altro numero: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserire un'operatore (+ oppure -): ");
        char op = char.Parse(Console.ReadLine());
        if(op != '+' && op != '-')
        {
            Console.WriteLine("Operatore non valido!");
        }
        if(op == '+')
        {
            Console.WriteLine($"La somma è: {a + b}");
        }
        if(op == '-')
        {
            Console.WriteLine($"La differenza è: {a - b}");
        }
    }
}
