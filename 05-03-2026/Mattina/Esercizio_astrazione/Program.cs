using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>();
        dispositivi.Add(new Computer("Acer Nitro"));
        dispositivi.Add(new Stampante("HP Inkjet"));

        foreach(DispositivoElettronico de in dispositivi)
        {
            de.MostraInfo();
            de.Accendi();
            de.Spegni();
        }
    }
}