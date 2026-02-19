using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //                                                                                              VARIABILI
        string username = "";
        string password = "";
        string temp = "";
        string scelta;
        int count = 20;
        bool uscita = false;
        bool logged = false;
        bool registered = false;

        //                                                                                              LOOP PRINCIPALE
        
        do
        {
            Console.WriteLine("[1] - Registrati \n[2] - Accedi al sistema \n[3] - Countdown \n[4] - Esci");
            scelta = Console.ReadLine();

        //                                                                                              SWITCH SCELTA

            switch (scelta)
            {
                case "1":
        //                                                                                              UTENTE NON REGISTRATO
                    if(registered == false)
                    {
                        Console.Write("Inserisci un nome utente: ");
                        username = Console.ReadLine();

                        Console.Write("Inserisci una password: ");
                        password = Console.ReadLine();

                        Console.WriteLine("Registrazione effettuata");
                        registered = true;
                    }

        //                                                                                              UTENTE REGISTRATO
                    
                    else
                    {
                        Console.WriteLine("Hai già effettuato il login");
                    }
                    break;


        //                                                                                              LOGIN
                case "2":
                    if(registered == true && logged == false)
                    {
                        for(int i = 3; i >= 0; i--)
                        {
        //                                                                                              INSERIMENTO USERNAME
                            Console.Write("Inserire username: ");

                            if(Console.ReadLine() == username)
                            {
        //                                                                                              USERNAME CORRETTO - USR ERRATO ↓
                                Console.WriteLine("Username corretto");

                                for(int j = 3; j >= 0; j--)
                                {
        //                                                                                              INSERIMENTO PASSWORD
                                    Console.Write("Inserire password: ");

                                    if(Console.ReadLine() == password)                                  // LOGIN ESEGUITO CON SUCCESSO
                                    {
                                        logged = true;
                                        Console.WriteLine($"Benvenuto, {username}");
                                        i = -1;
                                        break;
                                    }
                                    else                                                                //TENTATIVI ESAURITI PASSWORD
                                    {
                                        Console.WriteLine($"Password errata. Tentativi rimanenti: {j}");
                                        if(j < 1)
                                        {
                                            i = -1;
                                            break;
                                        }
                                    }
                                }
                            }
                            else                                                                        //TENTATIVI ERRATI USERNAME
                            {
                                Console.WriteLine($"Username errato. Tentativi rimanenti: {i}");
                            }
                        }
                    }
                    else if(logged == true)
                    {
                        Console.WriteLine("Hai già effettuato l'accesso");
                        break;
                    }
        //                                                                                              L'UTENTE HA GIA EFFETTUATO IL LOGIN
                    else
                    {
                        Console.WriteLine("Devi registrarti prima di effettuare l'accesso");
                    }
                    break;



                case "3":
        //                                                                                              COUNTDOWN
                    if(logged == true)
                    {
                        do
                        {
                            for(int i = count; i > 0; i--)
                            {
                                if(scelta != "n")
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            Console.WriteLine("Non è sucesso niente...");

                            Console.WriteLine("Vuoi ripetere il conto alla rovescia? \n[s] Sì \n[n] - No\n"); //RIPETIZIONE COUNTDOWN
                            scelta = Console.ReadLine();
                            if(scelta == "s")
                            {
                                do                                                                            //SCELTA OPERAZIONE
                                {
                                    Console.WriteLine("Vuoi far ripartire il countdown da 20 o vuoi scegliere un altro numero? \n[1] - Da 20 \n[2] - Numero scelto \n[3] - Torna al menu principale\n");
                                    scelta = Console.ReadLine();
                                    switch(scelta)
                                    {
                                        case "1":                                                             //RIPETE IL CICLO (VEDI CONDIZ. WHILE)
                                            break;

                                        case "2":
                                            do
                                            {
                                                Console.WriteLine("Da quanto deve ripartire il countdown?");
                                                count = int.Parse(Console.ReadLine());
                                                if(count < 0)
                                                {
                                                    Console.WriteLine("Impossibile far partire il countdown da numeri negativi");
                                                }

                                            }
                                            while(count < 0);                                                   //RIPETE IL CICLO CON COUNTDOWN(VEDI PRIMO FOR)
                                            scelta = "1";
                                            break;

                                        case "3":                                                               //ESCE E RESETTA IL COUNTDOWN
                                            count = 20;
                                            scelta = "3";
                                            break;

                                        default:
                                            Console.WriteLine("Scelta non valida");
                                            break;

                                    }
                                }
                                while(scelta != "3" && scelta != "1");
                            }
                            else if(scelta != "n")
                            {
                                Console.WriteLine("Scelta non valida");
                            }
                        }
                        while(scelta != "s" && scelta != "n" && scelta != "3" && scelta == "1");                //HO RIAVVIATO TROPPE VOLTE IL PROGRAMMA PER ARRIVARE A QUESTA SOLUZIONE
                    }
                    else
                    {
                        Console.WriteLine("Devi effettuare l'accesso per vedere il countdown");
                    }
                    break;



                case "4":
                    uscita = true;
                    break;



                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
        while(!uscita);
    }
}