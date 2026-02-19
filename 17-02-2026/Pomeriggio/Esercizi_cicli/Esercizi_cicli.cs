using System;

class Program
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        bool negativo = false;
        int n;
        int somma = 0;

        while (!negativo)
        {
            Console.WriteLine("Inserisci un numero positivo: ");
            n = int.Parse(Console.ReadLine());
            if(n >= 0)
            {
                somma += n;
            }
            else
            {
                negativo = true;
                Console.WriteLine($"Fine ciclo. Risultato: {somma}");
            }
        }



        //-----ESERCIZIO 2
        bool trovato = false;
        const int SEGRETO = 727;
        int num;

        while (!trovato)
        {
            Console.WriteLine("Inserisci un numero: ");
            num = int.Parse(Console.ReadLine());
            if(num != SEGRETO)
            {
                if(num > SEGRETO)
                {
                    Console.WriteLine("Il numero inserito è maggiore del numero segreto. Ritenta");
                }
                else
                {
                    Console.WriteLine("Il numero inserito è minore del numero segreto. Ritenta");
                }
            }
            else
            {
                Console.WriteLine("Hai indovinato il numero segreto");
                trovato = true;
            }
        }



        //-----ESERCIZIO 3
        bool esecuzione = true;
        string scelta;
        float saldo = 0.0f;
        float operazione;

        while (esecuzione)
        {
            Console.WriteLine("[1] - Visualizza saldo \n[2] - Deposita denaro \n[3] - Preleva denaro \n[4] - Esci");
            scelta = Console.ReadLine();

            switch(scelta)
            {
                case "1":                                                                       //VISUALIZZA SALDO
                    Console.WriteLine($"Saldo attuale: {saldo}");
                    break;



                case "2":                                                                       //DEPOSITA DENARO
                    Console.WriteLine("Inserire l'importo da depositare: ");
                    operazione = float.Parse(Console.ReadLine());
                    if(operazione < 0)
                    {
                        Console.WriteLine("Impossibile depositare una somma inferiore a 0.");
                    }
                    else
                    {
                        saldo += operazione;
                        Console.WriteLine($"Deposito effettuato. Saldo attuale: {saldo}");
                    }
                    break;


                    
                case "3":                                                                       //PRELEVA DENARO
                    Console.WriteLine("Inserire l'importo da prelevare: ");
                    operazione = float.Parse(Console.ReadLine());

                    if(operazione > saldo)
                    {
                        Console.WriteLine("Impossibile prelevare una somma maggiore del saldo.");
                    }
                    else if(operazione < 0.0f)
                    {
                        Console.WriteLine("Impossibile prelevare una somma inferiore a 0.");
                    }
                    else
                    {
                        saldo -= operazione;
                        Console.WriteLine($"Prelievo eseguito. Saldo attuale: {saldo}");
                    }
                    break;



                case "4":                                                                        //ESCI
                    Console.WriteLine($"Arrivederci");
                    esecuzione = false;
                    break;



                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
    }
}