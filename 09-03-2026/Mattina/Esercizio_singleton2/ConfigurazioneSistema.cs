public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema? _istanza;
    Dictionary<string, string> System_KeyValue = new Dictionary<string, string>();

    private ConfigurazioneSistema()
    {
        
    }

    public static ConfigurazioneSistema Instance()
    {
        if(_istanza == null)
        {
            _istanza = new ConfigurazioneSistema();
        }
        return _istanza;
    }

    public void Imposta(string key, string value)
    {
        System_KeyValue[key] = value;
    }

    public void Leggi(string key)
    {
        Console.WriteLine($"Valore all'indirizzo {key}: {System_KeyValue[key]}");
    }

    public void StampaTutte()
    {
        foreach(var k in System_KeyValue)
        {
            Console.WriteLine($"{k.Key}: {k.Value}");
        }
    }
}