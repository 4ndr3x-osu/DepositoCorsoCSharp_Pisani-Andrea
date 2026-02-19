using System;

class Program
{
    static void Main (string[] args)
    {
        string giorno = "lunedi";

        switch (giorno)
        {
            case "lunedi":
                Console.WriteLine("Inizio settimana");
                break;
            case "venerdi":
                Console.WriteLine("Quasi weekend");
                break;
            default:
                Console.WriteLine("Altro giorno");
                break;
        }
    }
}