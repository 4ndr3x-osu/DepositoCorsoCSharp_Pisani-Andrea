using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        const int PASSWORD = 727;
        int pass;
        int tentativi = 0;

        do
        {
            Console.WriteLine("Inserire la password: ");
            pass = int.Parse(Console.ReadLine());

            if(pass == PASSWORD)
            {
                Console.WriteLine("Password corretta");
                tentativi = 3;
            }
            else
            {
                Console.WriteLine("Password errata");
                tentativi++;
            }
        }
        while(tentativi < 3);



        //-----ESERCIZIO 2
        int n;
        int somma = 0;
        int count = 0;

        do
        {
            Console.WriteLine("Inserire un numero intero: ");
            n = int.Parse(Console.ReadLine());

            if(n == 0)
            {
                Console.WriteLine($"Fine del ciclo. \nSomma: {somma} || Numeri inseriti: {count}");
            }
            else
            {
                somma += n;
                count++;
            }
        }
        while(n != 0);



        //-----ESERCIZIO 3
        float n1;
        float n2;
        string scelta;

        do
        {
            Console.WriteLine("Inserisci il primo numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero: ");
            n2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Scegli l'operazione da svolgere: ");
            Console.WriteLine("[1] - Addizione \n[2] - Sottrazione \n[3] - Moltiplicazione \n[4] - Divisione");
            scelta = Console.ReadLine();

            switch(scelta)
            {
                case "1":
                    Console.WriteLine($"La somma di {n1} e {n2} è {n1 + n2}");
                    break;
                case "2":
                    Console.WriteLine($"La differenza di {n1} e {n2} è {n1 - n2}");
                    break;
                case "3":
                    Console.WriteLine($"Il prodotto di {n1} e {n2} è {n1 * n2}");
                    break;
                case "4":
                    Console.WriteLine($"Il quoziente di {n1} e {n2} è {n1 / n2}, con resto {n1 % n2}");
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    scelta = "";
                    break;
            }
            while(scelta != "s" && scelta != "" && scelta != "n")
            {
                Console.WriteLine("Vuoi svolgere un'altra operazione?");
                Console.WriteLine("[s] - Sì \n[n] - No");
                scelta = Console.ReadLine();
                if(scelta != "s" && scelta != "n")
                {
                    Console.WriteLine("Scelta non valida");
                }
            }
        }
        while(scelta != "n");
    }
}