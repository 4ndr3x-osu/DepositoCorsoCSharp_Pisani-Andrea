using System;

class Program
{
    static void Main(string[] args)
    {
        Calcolatrice calcolatrice = new Calcolatrice();
        string input = "";
        bool loop = true;
        double num1 = 0;
        double num2 = 0;
        double risultato = 0;

        do
        {
            do
            {
                input = ScegliOperazione();
            }
            while(input == "");

            if (input != "5") InputNumeri(ref num1, ref num2, input);

            switch(input)
            {
                case "1":
                    calcolatrice.ImpostaStrategia(new SommaStrategia());
                    break;
                case "2":
                    calcolatrice.ImpostaStrategia(new SottrazioneStrategia());
                    break;
                case "3":
                    calcolatrice.ImpostaStrategia(new MoltiplicazioneStrategia());
                    break;
                case "4":
                    calcolatrice.ImpostaStrategia(new DivisioneStrategia());
                    break;
                case "5":
                    loop = false;
                    break;
            }
            if(input != "5") Console.WriteLine($"\nRisultato: {calcolatrice.EseguiOperazione(num1, num2)}");
        }
        while(loop);
    }

    static string ScegliOperazione()
    {
        string inp;
        Console.WriteLine("[1] - Addizione\n[2] - Sottrazione\n[3] - Moltiplicazione\n[4] - Divisione\n[5] - Esci");
        inp = Console.ReadLine();
        if(inp != "1" && inp != "2" && inp != "3" && inp != "4" && inp != "5")
        {
            Console.WriteLine("Scelta non valida");
            return "";
        }
        return inp;
    }

    static void InputNumeri(ref double n1, ref double n2, string inp)
    {
        do
        {
            Console.WriteLine("Inserisci il primo numero: ");
            inp = Console.ReadLine();
        }
        while(!CheckInt(ref n1, inp));

        do
        {
            Console.WriteLine("Inserisci il secondo numero: ");
            inp = Console.ReadLine();
        }
        while(!CheckInt(ref n2, inp));
    }

    static bool CheckInt(ref double n, string i)
    {
        if(double.TryParse(i, out n))
        {
            return true;
        }
        return false;
    }
}