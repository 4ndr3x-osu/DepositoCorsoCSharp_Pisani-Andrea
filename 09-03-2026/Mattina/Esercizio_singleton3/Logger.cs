public sealed class Logger
{
    private static Logger? _istanza;
    public List<string> ListaLog = new List<string>();
    private Logger()
    {
        
    }

    public static Logger Instance()
    {
        if(_istanza == null)
        {
            _istanza = new Logger();
        }
        return _istanza;
    }

    public void Log(string messaggio)
    {
        ListaLog.Add(messaggio);
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] // Aggiunto al log: {messaggio}");
    }
}