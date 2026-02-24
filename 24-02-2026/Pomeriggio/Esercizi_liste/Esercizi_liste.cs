using System;
using System.Reflection.Metadata;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        #region ESERCIZIO 1
        List<int> interi = new List<int>();
        int temp;
        string input;
        bool cancella = true;
        bool remove = false;

        for(int i = 0; i < 5; i++)
        {

            Console.Write($"Inserisci il {i+1}° numero della lista: ");

            if(int.TryParse(Console.ReadLine(), out temp))
            {

                interi.Add(temp);

            }

            else
            {

                Console.WriteLine("Inserimento non valido");
                i--;

            }

        }

        Console.WriteLine("Vuoi cancellare un numero?\n[s] - si\t[n] - no");

        do
        {

            input = Console.ReadLine();
            switch(input.ToLower())

            {

                case "s":
                    do
                    {

                        Console.Write("Digita il numero da cancellare: ");
                        input = Console.ReadLine();

                        if(!int.TryParse(input, out temp))
                        {

                            Console.WriteLine("Input non valido");
                            break;

                        }
                        else
                        {

                            foreach(int n in interi)
                            {

                                if(n == temp)
                                {

                                    remove = true;
                                    break;

                                }

                            }

                            if(remove)
                            {

                                interi.Remove(temp);
                                Console.WriteLine($"Rimosso il numero {temp}");

                            }
                            else
                            {

                                Console.WriteLine($"Numero {temp} non trovato");

                            }

                            do
                            {

                                Console.WriteLine("Vuoi cancellare un altro numero?\n[s] - si\t[n] - no");
                                input = Console.ReadLine();
                                input = input.ToLower();

                                if(input == "s")
                                {

                                    break;

                                }
                                else if(input == "n")
                                {

                                    cancella = false;

                                }
                                else
                                {

                                    Console.WriteLine("Scelta non valida");

                                }

                            }
                            while(input != "s" && input != "n");

                        }

                    }

                    while(cancella);
                    break;

                case "n":
                    cancella = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida");
                    break;

            }

        }
        while(cancella);

        Console.WriteLine("Lista:");

        foreach(int n in interi)
        {

            Console.WriteLine(n);

        }

        #endregion



        #region ESERCIZIO 2
        List<int> lista_pari = new List<int>();
        Random rand = new Random();
        bool trovato = false;
        List<int> indici_pari = new List<int>();
        int contatore_pari = 0;
        //string input;
        //int temp;

        for(int i = 0; i < 100; i++)
        {

            lista_pari.Add(rand.Next(1, 101));

        }

        Console.WriteLine("Lista: ");

        foreach(int n in lista_pari)
        {

            Console.WriteLine(n);

        }

        do
        {
            Console.WriteLine("Cerca un numero: ");
            input = Console.ReadLine();

            if(!int.TryParse(input, out temp))
            {

                Console.WriteLine("Inserimento non valido");

            }

        }
        while(!int.TryParse(input, out temp));

        foreach(int n in lista_pari)
        {

            if(n == temp)
            {

                Console.WriteLine($"Numero trovato! Indice: {lista_pari.IndexOf(n)}");
                trovato = true;

            }

            if(n % 2 == 0)
            {

                contatore_pari++;
                indici_pari.Add(lista_pari.IndexOf(n));

            }

        }

        if(!trovato)
        {

            Console.WriteLine("Numero non trovato");

        }

        Console.WriteLine($"Numeri pari: {contatore_pari}");

        foreach(int n in indici_pari)
        {

            Console.WriteLine($"{lista_pari.ElementAt(n)}");

        }



        #endregion



        #region ESERCIZIO 3
        List<int> lista_originale = new List<int>();
        Random duplicati = new Random();
        List<int> indici_duplicati = new List<int>();



        for(int i = 0; i < 15; i++)
        {
            lista_originale.Insert(i, duplicati.Next(1, 21));
        }
        Console.WriteLine("Lista originale: ");

        foreach(int n in lista_originale)
        {
            Console.WriteLine(n);
        }

        for(int i = 0; i < lista_originale.Count; i++)
        {

            Console.WriteLine($"Indice: {i}\t{lista_originale.ElementAt(i)}");

            for(int j =  0; j < lista_originale.Count; j++)
            {

                if(lista_originale[i] == lista_originale[j] && i != j)
                {

                    indici_duplicati.Add(j);

                }

            }

        }



        Console.WriteLine("Lista senza duplicati: ");

        for(int i = 0; i < indici_duplicati.Count; i++)
        {

            Console.WriteLine($"Indice: {i}\t{lista_originale.ElementAt(i)}");

        }
        #endregion

    }
}