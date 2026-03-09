using System;

class Program
{
    public static void Main(string[] args)
    {
        Logger a = Logger.Instance();
        Logger b = Logger.Instance();

        a.Log("Questa è una prova");
        a.Log("Rimossa la cartella System32");
        b.Log("Ripristinata System32");

        foreach(string entry in a.ListaLog)
        {
            Console.WriteLine(entry);
        }
    }
}