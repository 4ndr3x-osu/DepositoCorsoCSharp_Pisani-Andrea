using System;

class Program()
{
    static void Main(string[] args)
    {
        //----- ESERCIZIO 1
        int a;
        int b;
        
        Console.WriteLine("Dammi un numero: ");
        string n1 = Console.ReadLine();
        
        Console.WriteLine("Dammi un'altro numero: ");
        string n2 = Console.ReadLine();

        a = int.Parse(n1);
        b = int.Parse(n2);
        
        Console.WriteLine($"Somma dei due numeri: {a+b}");



        //-----ESERCIZIO 2
        double prezzo;

        Console.WriteLine("Scrivi il prezzo: ");
        string p = Console.ReadLine();

        prezzo = double.Parse(p);

        Console.WriteLine($"Prezzo con sconto del 20% applicato (prezzo finale): {prezzo * 0.8}");



        //-----ESERCIZIO 3
        float numero;

        Console.WriteLine("Dammi un numero con la virgola: ");
        string n = Console.ReadLine();

        numero = float.Parse(n);

        Console.WriteLine($"Il numero è positivo? {a>0}");



        //-----ESERCIZIO 4
        Console.WriteLine("Dammi un numero intero: ");
        n1 = Console.ReadLine();
        Console.WriteLine("Dammi un numero con la virgola: ");
        n2 = Console.ReadLine();

        int num1 = int.Parse(n1);
        float num2 = float.Parse(n2);

        Console.WriteLine($"Somma dei due numeri: {num1 + num2}");



        //-----ESERCIZIO 5
        Console.WriteLine("Scrivi la tua età: ");
        n1 = Console.ReadLine();
        Console.WriteLine("Scrivi la tua altezza: ");
        n2 = Console.ReadLine();

        int eta = int.Parse(n1);
        float altezza = float.Parse(n2);

        Console.WriteLine($"Somma di eta' e altezza: {eta + (int)altezza}");



        //-----ESERCIZIO 6
        Console.WriteLine("Dammi un numero per x: ");
        n1 = Console.ReadLine();
        Console.WriteLine("Dammi un numero per y: ");
        n2 = Console.ReadLine();

        int x = int.Parse(n1);
        int y = int.Parse(n2);

        bool risultato = (x > y || !(x > y) && x > 15);

        Console.WriteLine($"x è maggiore di y oppure è diverso da y e maggiore di 15? {risultato}");
    }
}