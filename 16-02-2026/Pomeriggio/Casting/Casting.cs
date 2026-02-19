using System;

class Program()
{
    static void Main(string[] args)
    {
        // Implicito (nessuna perdita di dati)
        int intero = 42;
        float numeroLungo = intero; // widening - da più piccolo a più grande

        // Esplicito (perdita di dati o eccezioni)
        float pi = 3.14f;
        int circaPi = (int)pi; //narrowing - da più grande a più piccolo

        Console.WriteLine("Intero: " + intero);
        Console.WriteLine("Numero Lungo (+ 0.6): " + numeroLungo + 0.6);
        Console.WriteLine("Pi greco: " + pi);
        Console.WriteLine("Pi greco arrotondato: " + circaPi);
    }
}
