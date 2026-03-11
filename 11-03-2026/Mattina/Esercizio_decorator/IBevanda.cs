using System.Runtime;

public interface IBevanda
{
    string Descrizione();
    double Costo();
}

public class Caffe : IBevanda
{
    public string Descrizione()
    {
        return "Caffé";
    }

    public double Costo()
    {
        return 1.00;
    }
}

public class Te : IBevanda
{
    public string Descrizione()
    {
        return "Te";
    }

    public double Costo()
    {
        return 1.50;
    }
}

abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda _bevanda;

    public DecoratoreBevanda(IBevanda bevanda)
    {
        _bevanda = bevanda;
    }

    public virtual string Descrizione()
    {
        return _bevanda.Descrizione();
    }

    public virtual double Costo()
    {
        return _bevanda.Costo();
    }
}

class ConLatte : DecoratoreBevanda
{
    public ConLatte(IBevanda bevanda) : base(bevanda)
    {
        
    }
    public override string Descrizione()
    {
        return _bevanda.Descrizione() + ", con latte";
    }

    public override double Costo()
    {
        return _bevanda.Costo() + 0.25d;
    }
}

class ConCioccolato : DecoratoreBevanda
{
    public ConCioccolato(IBevanda bevanda) : base(bevanda)
    {
        
    }
    public override string Descrizione()
    {
        return _bevanda.Descrizione() + ", con cioccolato";
    }

    public override double Costo()
    {
        return _bevanda.Costo() + 0.75d;
    }
}

class ConPanna : DecoratoreBevanda
{
    public ConPanna(IBevanda bevanda) : base(bevanda)
    {
        
    }
    public override string Descrizione()
    {
        return _bevanda.Descrizione() + ", con panna";
    }

    public override double Costo()
    {
        return _bevanda.Costo() + 0.50d;
    }
}