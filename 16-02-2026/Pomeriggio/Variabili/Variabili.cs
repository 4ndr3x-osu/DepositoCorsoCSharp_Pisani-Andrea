using System;

class Program()
{
    static void Main(string[] args)
    {
        int contatore; // dichiarazione
        contatore=0; // assegnazione
        int somma=10; // dichiarazione + inizializzazione
        var nome="Ada"; // tipo dedotto dal compilatore ("Inferenza")
        Console.WriteLine("Contatore: " + contatore);
        Console.WriteLine("Somma: " + somma);
        Console.WriteLine("Nome: " + nome);
    }
}