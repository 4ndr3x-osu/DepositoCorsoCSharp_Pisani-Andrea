using System;

class Program
{
    static void Main(string[] args)
    {
        #region ESERCIZIO 1
        Random random = new Random();
        bool guess = false;
        int segreto = random.Next(1,11);;
        int numero;

        while(!guess)
        {
            Console.Write("Scrivi un numero da 1 a 10: ");
            if(int.TryParse(Console.ReadLine(), out numero))
            {
                if(numero == segreto)
                {
                    Console.WriteLine($"Hai indovinato! Il numero era {segreto}");
                    guess = true;
                }
                else
                {
                    Console.WriteLine("Hai sbagliato. Ritenta...");
                }

            }
            else
            {
                Console.WriteLine("Inserimento non valido");
            }
        }
        #endregion

        #region ESERCIZIO 2
        Random lancio = new Random();
        int d1;
        int d2;
        string selezione;
        bool continua = true;

        while(continua)
        {
            d1 = lancio.Next(1, 7);
            d2 = lancio.Next(1, 7);

            Console.WriteLine($"Dado 1: {d1} --- Dado 2: {d2} --- Somma: {d1 + d2}");
            do
            {
                Console.WriteLine("Continuare? \n[s] - sì \n[n] - no");
                selezione = /* string.ToLower( */Console.ReadLine()/* ) */;
                switch(selezione)
                {
                    case "s":
                        break;
                    case "n":
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            }
            while(selezione != "s" && selezione != "n" );
        }

        #endregion

        #region ESERCIZIO 3
        double min = -10.0d;
        double max = 40.0d;
        Random meteo = new Random();
        int n_giorni = InputGiorni();
        double[] temperatura = new double[n_giorni];
        
        for(int i = 1; i <= n_giorni; i++)
        {
            temperatura[i-1] = meteo.NextDouble() * (max - min) + min;
            Console.WriteLine($"Giorno {i}: {temperatura[i-1]:F2}°C");
        }

        Console.WriteLine($"Temperatura minima: {temperatura.Min():F2}°C\tTemperatura massima: {temperatura.Max():F2}°C\tTemperatura media: {temperatura.Average():F2}°C");
        #endregion

        static int InputGiorni()
        {
            int n;
            do
            {
                Console.WriteLine("Inserisci il numero di giorni da simulare: ");
                if(int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Procedo con la simulazione...");
                }
                else if(n < 0)
                {
                    Console.WriteLine($"Impossibile effettuare una simulazione da {n} giorni.");
                    n = -1;
                }
                else
                {
                    Console.WriteLine("Inserimento non valido");
                }
            }
            while(n == -1);
            return n;
        }
    }
}