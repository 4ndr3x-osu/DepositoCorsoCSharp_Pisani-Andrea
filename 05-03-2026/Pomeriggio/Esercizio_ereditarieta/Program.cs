using System;

class Program
{
    static void Main(string[] args)
    {
        List<Veicolo> veicoli = new List<Veicolo>();
        string input = "";
        bool loop = true;

        do
        {

            Console.WriteLine("[1] - Aggiungi veicolo\n[2] - Visualizza veicoli\n[3] - Esci");
            input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    MenuVeicolo(ref input); // Richiama il metodo MenuVeicolo

                    if(input == "1")
                        AggiungiAuto(ref veicoli); // Richiama il metodo AggiungiAuto

                    else
                        AggiungiMoto(ref veicoli); // Richiama il metodo AggiungiMoto

                    break;



                case "2":
                    foreach(Veicolo v in veicoli) // Il foreach stampa tutti gli elementi della List, andando a usare il metodo in base all'oggetto corrente all'interno della lista
                    {
                        v.StampaInfo();
                    }
                    break;



                case "3": // Uscita dal programma
                    loop = false;
                    break;



                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }

        }
        while(loop);
    }



    static bool CheckInt(string inp, out int num) // Controlla se il numero in input è un intero
    {
        if(int.TryParse(inp, out num))
        {
            return true;
        }
        return false;
    }



    static void MenuVeicolo(ref string inp) // Menu per scegliere il tipo di veicolo da aggiungere
    {
        do
        {
            Console.WriteLine("[1] - Aggiungi auto\n[2] - Aggiungi moto");
            inp = Console.ReadLine();
        }
        while(inp != "1" && inp != "2");
    }



    static void AggiungiAuto(ref List<Veicolo> veic) // Metodo per l'aggiunta di un veicolo di tipo "Auto"
    {
        string marc, mod, num_porte;
        int n_porte = 0;

        Console.WriteLine("Inserisci la marca dell'auto: ");
        marc = Console.ReadLine();

        Console.WriteLine("Inserisci il modello dell'auto: ");
        mod = Console.ReadLine();

        do
        {
            Console.WriteLine("Inserisci il numero di porte: ");
            num_porte = Console.ReadLine();
        }
        while(!CheckInt(num_porte, out n_porte));               //Controllo su num_porte per verificare se è un intero

        veic.Add(new Auto(marc, mod, n_porte));
    }



    static void AggiungiMoto(ref List<Veicolo> veic) // Metodo per l'aggiunta di un veicolo di tipo "Moto"
    {
        string marc, mod, tipo_man;

        Console.WriteLine("Inserisci la marca della moto: ");
        marc = Console.ReadLine();

        Console.WriteLine("Inserisci il modello della moto: ");
        mod = Console.ReadLine();

        Console.WriteLine("Inserisci il tipo di manubrio: ");
        tipo_man = Console.ReadLine();

        veic.Add(new Moto(marc, mod, tipo_man));
    }
}