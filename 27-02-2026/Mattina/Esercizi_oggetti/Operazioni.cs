using System;
using System.Reflection.Metadata;

//-----------------------------------Classe Esercizio 3
public class Operazioni
{
    int Num1;
    int Num2;

    public Operazioni(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    public void StampaSomma()
    {
        Console.WriteLine($"La somma di {Num1} e {Num2} è {Num1+Num2}");
    }

    public void StampaProdotto()
    {
        Console.WriteLine($"Il prodotto di {Num1} e {Num2} è {Num1*Num2}");
    }
}