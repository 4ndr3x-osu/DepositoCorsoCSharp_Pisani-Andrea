public sealed class Logger
{
    private static Logger? _istanza;

    private Logger()
    {
        
    }

    public static Logger GetIstanza()
    {
        if(_istanza == null)
        {
            _istanza = new Logger();
        }
        return _istanza;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {messaggio}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Logger nLog = Logger.GetIstanza();
        nLog.ScriviMessaggio("Avvio programma");

        Logger altroLog = Logger.GetIstanza();
        altroLog.ScriviMessaggio("Secondo messaggio");

        if (Object.ReferenceEquals(nLog, altroLog))
        {
            Console.WriteLine("Sì! nLog e altroLog sono la stessa identica istanza.");
        }
    }
}