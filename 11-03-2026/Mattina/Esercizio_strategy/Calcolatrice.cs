public interface IStrategiaOperazione
{
    double Calcola(double a, double b);
}

public class SommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }
}

public class SottrazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a - b;
    }
}

public class MoltiplicazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a * b;
    }
}

public class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a / b;
    }
}

public class Calcolatrice
{
    private IStrategiaOperazione _strategia;

    public void ImpostaStrategia(IStrategiaOperazione nuovaStrategia)
    {
        _strategia = nuovaStrategia;
    }

    public double EseguiOperazione(double a, double b)
    {
        return _strategia.Calcola(a, b);
    }
}