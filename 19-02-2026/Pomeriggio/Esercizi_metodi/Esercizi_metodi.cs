using System;

class Program
{
    private static void StampaSaluto(string n)      //METODO ESERCIZIO 1
    {
        Console.WriteLine($"Ciao {n}, come stai?");
    }

    private static bool VerificaPari(int a)         //METODO ESERCIZIO 2
    {
        bool pari = false;
        if(a % 2 == 0)
        {
            pari = true;
        }
        return pari;
    }

    private static int Potenza(int n, int e)        //METODO ESERCIZIO 3
    {
        int p = 1;
        for(int i = 1; i <= e; i++)
        {
            p = p * n;
        }
        return p;
    }


    static void Main(string[] args)
    {
        //-----ESERCIZIO 1

        Console.Write("Scrivi il tuo nome: ");
        StampaSaluto(Console.ReadLine());



        //-----ESERCIZIO 2

        Console.Write("\nInserisci un numero intero: ");
        
        if(VerificaPari(int.Parse(Console.ReadLine())))
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("Il numero è dispari");
        }



        //-----ESERCIZIO 3

        Console.Write("Scrivi un numero intero: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Scrivi l'esponente: ");

        Console.WriteLine(Potenza(num, int.Parse(Console.ReadLine())));
    }
}