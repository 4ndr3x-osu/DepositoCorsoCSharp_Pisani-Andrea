class Veicolo //----------------------------------------------- Classe base
{
    public string Marca;
    public string Modello;

    public Veicolo(string marca, string modello) // Costruttore classe Veicolo (Classe base)
    {
        Marca = marca;
        Modello = modello;
    }

    public virtual void StampaInfo() // Metodo StampaInfo classe base
    {
        Console.WriteLine($"{Marca} {Modello}");
    }
}

class Auto : Veicolo //---------------------------------------- Classe derivata Auto
{
    int NumeroPorte;

    public Auto(string marca, string modello, int numeroporte) : base(marca, modello) // Costruttore classe derivata Auto
    {
        NumeroPorte = numeroporte;
    }

    public override void StampaInfo() // Override del metodo StampaInfo per la classe derivata Auto
    {
        base.StampaInfo();
        Console.WriteLine($"Numero porte: {NumeroPorte}\n");
    }
}

class Moto : Veicolo //---------------------------------------- Classe derivata Moto
{
    string TipoManubrio;

    public Moto(string marca, string modello, string tipomanubrio) : base(marca, modello) // Costruttore classe derivata Moto
    {
        TipoManubrio = tipomanubrio;
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"Tipo manubrio: {TipoManubrio}\n"); // Override del metodo StampaInfo per la classe derivata Moto
    }
}