#region INTERFACE_PIATTO
public interface IPiatto // Garantisce che ogni piatto ha una descrizione e un metodo di preparazione
{
    string Descrizione();
    string Prepara();
}

public class Pizza : IPiatto
{
    public string Descrizione()
    {
        return "Pizza";
    }
    public string Prepara()
    {
        return "Preparando pizza...";
    }
}

public class Hamburger : IPiatto
{
    public string Descrizione()
    {
        return "Hamburger";
    }
    public string Prepara()
    {
        return "Preparando hamburger...";
    }
}

public class Insalata : IPiatto
{
    public string Descrizione()
    {
        return "Insalata";
    }
    public string Prepara()
    {
        return "Preparando Insalata...";
    }
}
#endregion
#region SINGLETON + FACTORY // (ISTANZA + GESTIONE CREAZIONE PIATTI)
public class PiattoFactory // Singleton + Factory Method
{
    private static PiattoFactory _instance;

    public static PiattoFactory GetInstance() // Gestione istanza
    {
        if(_instance == null)
        {
            _instance = new PiattoFactory();
        }
        return _instance;
    }

    public IPiatto CreaPiatto(string tipo)
    {
        switch(tipo.ToLower())
        {
            case "pizza":
                return new Pizza();
            case "hamburger":
                return new Hamburger();
            case "insalata":
                return new Insalata();
            default:
                return null;
        }
    }
}
#endregion
#region DECORATOR (INGREDIENTE EXTRA)
public abstract class ExtraIngrediente : IPiatto // Decorator
{
    protected IPiatto _piatto;

    public ExtraIngrediente(IPiatto piatto)
    {
        _piatto = piatto;
    }

    public abstract string Descrizione();
    public virtual string Prepara()
    {
        return _piatto.Prepara();
    }
}

public class ConFormaggio : ExtraIngrediente
{
    public ConFormaggio(IPiatto piatto) : base(piatto)
    {
        
    }
    public override string Descrizione()
    {
        return _piatto.Descrizione() + ", extra Formaggio";
    }
}

public class ConBacon : ExtraIngrediente
{
    public ConBacon(IPiatto piatto) : base(piatto)
    {
        
    }
    public override string Descrizione()
    {
        return _piatto.Descrizione() + ", extra Bacon";
    }
}

public class ConSalsa : ExtraIngrediente
{
    public ConSalsa(IPiatto piatto) : base(piatto)
    {
        
    }
    public override string Descrizione()
    {
        return _piatto.Descrizione() + ", extra Salsa";
    }
}
#endregion
#region STRATEGY (METODO COTTURA)
public interface IPreparazioneStrategia
{
    public string EseguiCottura(string nomePiatto);
}

public class Fritto : IPreparazioneStrategia
{
    public string EseguiCottura(string nomePiatto)
    {
        return $"Friggendo {nomePiatto}...";
    }
}

public class AlForno : IPreparazioneStrategia
{
    public string EseguiCottura(string nomePiatto)
    {
        return $"Infornando {nomePiatto}...";
    }
}

public class AllaGriglia : IPreparazioneStrategia
{
    public string EseguiCottura(string nomePiatto)
    {
        return $"Mettendo {nomePiatto} sulla griglia...";
    }
}
#endregion
#region OBSERVER
public interface IObserver
{
    void Update(IPiatto piatto); // ORDINE PRONTO PER ESSERE CUCINATO
}

public interface IOrdine
{
    void Attach(IObserver c);
    void Detach(IObserver c);
    void Notify();
}

public class OrdineSubject : IOrdine
{
    private List<IObserver> _observer = new List<IObserver>();
    private IPiatto _piattoCorrente;

    public void Attach(IObserver c)
    {
        _observer.Add(c);
    }

    public void Detach(IObserver c)
    {
        _observer.Remove(c);
    }

    public void Notify()
    {
        foreach (var obs in _observer) 
        {
            obs.Update(_piattoCorrente);
        }
    }
    public void SetPiattoPronto(IPiatto p)
    {
        _piattoCorrente = p; 
        Notify();
    }
}
#endregion

#region COORDINATORE (CHEF)
public class Chef : IObserver
{
    private IPreparazioneStrategia _strategiaCottura;

    public void SetStrategia(IPreparazioneStrategia s)
    {
        _strategiaCottura = s;
    }

    public void Update(IPiatto p)
    {
        Cucina(p);
    }

    public void Cucina(IPiatto piatto)
    {
        _strategiaCottura.EseguiCottura(piatto.Descrizione());
        Console.WriteLine(_strategiaCottura.EseguiCottura(piatto.Descrizione()));
    }
}
#endregion