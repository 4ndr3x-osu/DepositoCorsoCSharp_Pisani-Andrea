using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        IBevanda ordine = null;
        bool loop = true;
        string input = "";

        do
        {
            Console.WriteLine("[1] - Nuovo ordine\n[2]  - Esci");
            input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    do
                    {
                        ordine = SelezionaBevanda(input);
                    }
                    while(ordine == null);

                    do
                    {
                        ordine = SelezionaAggiunte(ref input, ordine);

                        if(input.ToLower() == "niente") break;

                        Console.WriteLine("Digita \"1\" per aggiungere qualcos'altro, altrimenti digita qualcosa diverso da 1 e premi invio");
                        input = Console.ReadLine();
                        if(input != "1") loop = false;
                    }
                    while(loop);

                    loop = true;
                    Console.WriteLine($"Riepilogo ordine: {ordine.Descrizione()} - {ordine.Costo()}");
                    break;
                case "2":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
        while(loop);
    }

    static IBevanda SelezionaBevanda(string inp)
    {
        Console.WriteLine("Scegli una bevanda tra caffé e te: ");
        inp = Console.ReadLine();
        switch(inp.ToLower())
        {
            case "caffé":
                return new Caffe();
            case "te":
                return new Te();
            default:
                Console.WriteLine("Scelta non valida");
                return null;
        }
    }

    static IBevanda SelezionaAggiunte(ref string inp, IBevanda ord)
    {
        Console.WriteLine("Scegli cosa aggiungere:\nLatte - 0.25€\nCioccolato - 0.75€\nPanna - 0.5€\nNiente");
        inp = Console.ReadLine();

        switch(inp.ToLower())
        {
            case "latte":
                return new ConLatte(ord);
            case "cioccolato":
                return new ConCioccolato(ord);
            case "panna":
                return new ConPanna(ord);
            case "niente":
                return ord;
            default:
                Console.WriteLine("Scelta non valida");
                return ord;
        }
    }
}