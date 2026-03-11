using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        PiattoFactory nuovoPiatto = PiattoFactory.GetInstance();
        Chef chef = new Chef();
        OrdineSubject sistemaOrdine = new OrdineSubject();

        string input = "";
        bool loop = true;

        sistemaOrdine.Attach(chef);

        do
        {
            Console.WriteLine("Inserisci cosa vuoi ordinare: (Pizza, Hamburger, Insalata)(Digita 0 per uscire)");
            input = Console.ReadLine();

            if(input == "0") break;
            if(input.ToLower() != "pizza" && input.ToLower() != "hamburger" && input.ToLower() != "insalata")
            {
                Console.WriteLine("Piatto non disponibile");
            }
            else
            {
                IPiatto piatto = nuovoPiatto.CreaPiatto(input);
            }

        }
        while(loop);
    }
}