public abstract class Animale //CLASSE ANIMALE
{
    string Nome;
    private int _Eta;
    int Eta
    {
        get{return _Eta;}
        set
        {
            if(value < 0) Console.WriteLine("Impossibile assegnare età minore di 0");
            else _Eta = value;
        }
    }



    public Animale(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }
    public abstract void Verso();

    public virtual void MostraInfo()
    {
        Console.WriteLine($"\nNome: {Nome}\nEta: {Eta}");
    }
}





//----------------------------------------------------CLASSE GALLINA
public class Gallina : Animale
{
    private float _AvgUova;
    float AvgUova
    {
        get{return _AvgUova;}
        set
        {
            if(value < 0) Console.WriteLine("Impossibile assegnare media uova minore di 0");
            else _AvgUova = value;
        }
    }



    public Gallina(string nome, int eta, float avguova) : base(nome, eta)
    {
        AvgUova = avguova;
    }

    public override void Verso()
    {
        Console.WriteLine("Coccodé (sono una gallina)");
    }

    public new void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Media uova/giorno: {AvgUova}");
    }
}





//----------------------------------------------------CLASSE CANE
public class Cane : Animale
{
    private string _Razza;
    string Razza
    {
        get{return _Razza;}
        set
        {
            if(value =="") _Razza = "Sconosciuta";
            else _Razza = value;
        }
    }



    public Cane(string nome, int eta, string razza) : base(nome, eta)
    {
        Razza = razza;
    }

    public override void Verso()
    {
        Console.WriteLine("Bau bau (sono un cane)");
    }

    public new void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Razza: {Razza}");
    }
}




//----------------------------------------------------CLASSE MAIALE
public class Maiale : Animale
{
    private decimal _Peso;
    decimal Peso
    {
        get{return _Peso;}
        set
        {
            if(value < 0) Console.WriteLine("Impossibile assegnare peso minore di 0");
            else _Peso = value;
        }
    }



    public Maiale(string nome, int eta, decimal peso) : base(nome, eta)
    {
        Peso = peso;
    }

    public override void Verso()
    {
        Console.WriteLine("Oink oink (sono un maiale)");
    }

    public new void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Peso: {Peso}");
    }
}