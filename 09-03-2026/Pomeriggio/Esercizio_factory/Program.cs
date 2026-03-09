using System;

class Program
{
    public static void Main(string[] args)
    {
        string? input = "";
        IVeicolo veicolo;

        do
        {
            Console.WriteLine("Quale veicolo vuoi creare? (auto, moto, camion)");
            input = Console.ReadLine();
            veicolo = VeicoloFactory.CreaVeicolo(input);
        }
        while(veicolo == null);

        veicolo.Avvia();
        veicolo.MostraTipo();
    }
}