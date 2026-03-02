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

    public override bool Equals(object obj)
    {
        if(obj is Operazioni o)
        {
            return this.Num1 == o.Num1 && this.Num2 == o.Num2;
        }
        return false;
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