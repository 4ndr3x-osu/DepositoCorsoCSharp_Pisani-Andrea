using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        #region ESERCIZIO 1

        Dictionary<string, string> rubrica = new Dictionary<string, string>();

        string nome;
        string telefono;



        for(int i = 0; i < 3; i++)
        {

            Console.Write($"Inserisci il nome del {i+1}° contatto: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Inserisci il numero di telefono del {i+1}° contatto: ");
            telefono = Console.ReadLine();

            rubrica.Add(nome, telefono);

        }



        foreach(var contatto in rubrica)
        {

            Console.WriteLine($"Nome: {contatto.Key}\tTelefono: {contatto.Value}");

        }

        #endregion



        #region ESERCIZIO 2

        Dictionary<string, int> contaparole = new Dictionary<string, int>();
        string frase;

        Console.Write("Scrivi una frase: ");
        frase = Console.ReadLine();
        string[] frase_scomposta = frase.Split(" ");
        contaparole.Add(frase_scomposta[0], 0);

        for(int i = 0; i < frase_scomposta.Length; i++)
        {

            if (contaparole.ContainsKey(frase_scomposta[i]))
            {
                contaparole[frase_scomposta[i]]++;
            }
            else
            {
                contaparole.Add(frase_scomposta[i], 1);
            }

        }

        foreach(var parola in contaparole)
        {
            Console.WriteLine($"{parola.Key}: {parola.Value} volte");
        }
        
        #endregion



        #region ESERCIZIO 3

        Dictionary<string, int> prodotti = new Dictionary<string, int>();
        bool esci = false;
        bool nuovo_prod = true;
        string input;
        string prodotto;
        bool elimina_prod = false;


        do
        {
            Console.WriteLine("[1]-Aggiungi un nuovo prodotto/Gestisci quantità\n[2]-Rimuovi un prodotto\n[3]-Mostra la quantità di un prodotto\n[4]-Stampa l'inventario completo\n[5]-Esci");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.Write("Inserisci il nome del prodotto: ");
                    prodotto = Console.ReadLine();

                    if(prodotti.Count < 1)
                    {
                        Console.WriteLine("Prodotto aggiunto!");

                        AggiungiModificaProdotto(prodotto, ref prodotti, nuovo_prod);
                    }
                    else
                    {

                        for(int i = 0; i < prodotti.Count; i++)
                        {

                            if(prodotti.ElementAt(i).Key == prodotto)
                            {

                                nuovo_prod = false;
                                Console.WriteLine("Prodotto trovato");
                                AggiungiModificaProdotto(prodotto, ref prodotti, nuovo_prod);

                            }
                            else if(i == prodotti.Count-1)
                            {

                                nuovo_prod = true;
                                Console.WriteLine($"Prodotto \"{prodotto}\" non trovato");

                                do
                                {

                                    Console.WriteLine($"Vuoi aggiungere il prodotto \"{prodotto}\"?\n[s]-Sì\t[n]-No");
                                    input=Console.ReadLine();

                                    switch(input.ToLower())
                                    {

                                        case "s":
                                            Console.WriteLine("Prodotto aggiunto!");
                                            AggiungiModificaProdotto(prodotto, ref prodotti, nuovo_prod);
                                            break;

                                        case "n":
                                            break;

                                        default:
                                            Console.WriteLine("Scelta non valida");
                                            break;

                                    }
                                }
                                while(input.ToLower() != "s" && input.ToLower()!= "n");
                                break;
                            }
                        }
                    }
                    break;



                case "2":
                    Console.Write("Scrivi il nome del prodotto da rimuovere: ");
                    prodotto = Console.ReadLine();

                    for(int i = 0; i < prodotti.Count; i++)
                    {

                        if(prodotti.ElementAt(i).Key == prodotto)
                        {
                            elimina_prod = true;
                        }
                        else if(prodotti.ElementAt(i).Key != prodotto && i == prodotti.Count-1)
                        {
                            Console.WriteLine($"Prodotto \"{prodotto}\" non trovato");
                        }

                    }

                    if(elimina_prod == true)
                    {
                        prodotti.Remove(prodotto);
                    }
                    break;



                case "3":
                    Console.Write("Scrivi il nome del prodotto da cercare: ");
                    prodotto = Console.ReadLine();

                    for(int i = 0; i < prodotti.Count; i++)
                    {
                        
                        if(prodotti.ElementAt(i).Key == prodotto)
                        {
                            Console.WriteLine($"{prodotti.ElementAt(i).Key}\t{prodotti.ElementAt(i).Value}");
                        }

                        else if(prodotti.ElementAt(i).Key != prodotto && i == prodotti.Count-1)
                        {
                            Console.WriteLine($"Prodotto \"{prodotto}\" non trovato");

                        }
                    }
                    break;



                case "4":
                    Console.WriteLine("Inventario: ");
                    
                    foreach(var prod in prodotti)
                    {
                        Console.WriteLine($"{prod.Key}\t{prod.Value}");
                    }
                    break;



                case "5":
                    esci = true;
                    break;



                default:
                Console.WriteLine("Scelta non valida");
                    break;
            }
        }
        while(!esci);

        #endregion

        #region METODI ESERCIZIO 3

        static bool CheckInt(string i)
        {
            bool parse_possible = false;
            int test;
            if(int.TryParse(i, out test))
            {
                parse_possible = true;
            }
            return parse_possible;
        }

        void AggiungiModificaProdotto(string p, ref Dictionary<string, int> pro, bool nuovo)
        {
            string i;
            bool loop;

            do
            {
                Console.WriteLine($"Inserisci la quantità per il prodotto \"{p}\"");
                i = Console.ReadLine();
                loop = !CheckInt(i) || int.Parse(i) < 0;

                if(!CheckInt(i))
                {
                    Console.WriteLine("Quantità non valida");
                }
                else
                {
                    if(int.Parse(i)<0)
                    {
                        Console.WriteLine("Impossibile impostare una quantità negativa");
                    }
                    else if(int.Parse(i)>=0 && nuovo)
                    {
                        pro.Add(p, int.Parse(i));
                    }
                    else
                    {
                        pro[p] += int.Parse(i);
                    }
                }
            }
            while(loop);
        }

        #endregion
    }
}