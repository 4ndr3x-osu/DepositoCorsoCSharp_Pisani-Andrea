using System.Diagnostics;

public interface IVeicolo
{
    void Avvia();
    void MostraTipo();
}

public class Auto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio auto...");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Auto");
    }
}

public class Moto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio moto...");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: moto");
    }
}

public class Camion : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio camion...");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Camion");
    }
}

static class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        switch(tipo.ToLower())
        {
            case "auto": return new Auto();
            case "moto": return new Moto();
            case "camion": return new Camion();
            default: 
                Console.WriteLine("Tipo veicolo non valido");
                return null;
        }
    }
}

public sealed class RegistroVeicoli
{
    private static RegistroVeicoli? _istanza;
    private List<string> VeicoliCreati = new List<string>();

    private RegistroVeicoli()
    {
        
    }

    public static RegistroVeicoli Istanza()
    {
        if(_istanza == null) _istanza = new RegistroVeicoli();
        return _istanza;
    }

    public void Registra(IVeicolo veicolo)
    {
        VeicoliCreati.Add($"[{DateTime.Now:HH:mm:ss}] // Aggiunto al registro: {veicolo}");
    }

    public void StampaTutti()
    {
        foreach(string veicolo in VeicoliCreati)
        {
            Console.WriteLine(veicolo);
        }
    }

}