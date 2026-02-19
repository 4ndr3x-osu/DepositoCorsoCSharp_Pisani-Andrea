using System;

class Program
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        Console.WriteLine("Inserisci un numero: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }



        //-----ESERCIZIO 2
        Console.WriteLine("Quanti numeri vuoi inserire?");
        int max = int.Parse(Console.ReadLine());

        float somma = 0;

        for(int i = 1; i <= max; i++)
        {
            Console.WriteLine($"Inserisci il {i}° numero:");
            somma += float.Parse(Console.ReadLine());
        }

        Console.WriteLine($"La media dei numeri inseriti è {somma / max}");



        //-----ESERCIZIO 3
        int f;
        
        do
        {
            Console.WriteLine("Inserisci un numero positivo: ");
            n = int.Parse(Console.ReadLine());
            f = n;

            if(n < 0)
            {
                Console.WriteLine("Errore");
            }
        }
        while(n < 0);

        for(int i = 1; i < n; i++)
        {
            Console.WriteLine($"{f} x {n - i}");    //controllo operazione
            f = f * (n - i);
        }

        Console.WriteLine($"Il fattoriale di {n} è {f}");
    }
}