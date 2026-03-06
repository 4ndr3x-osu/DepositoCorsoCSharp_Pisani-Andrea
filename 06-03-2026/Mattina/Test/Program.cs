using System;

//DISCLAIMER: DOPO CHE HO FINITO DI SCRIVERE LA CLASSE ANIMALI NON ANDAVANO PIU' I TASTI INVIO E BACKSPACE, QUINDI NON SONO RIUSCITO A COMPLETARE IL MAIN NON PER UNA QUESTIONE DI TEMPO, MA PER SFORTUNA (ALMENO CREDO)  
//DISCLAIMER 2: GUARDA CASO HANNO RIPRESO A FUNZIONARE ORA, ALLE 12:43 
class Program
{
    static void Main(string[] args)
    {
        List<Animale> animali = new List<Animale>();
        animali.Add(new Gallina("Rosita", 3, 5.2), new Cane("Shadow", 5, "Siberian Husky"), new Maiale("Bob", 6, 31.3)); // POPOLAZIONE LIST ANIMALI CON 3 ANIMALI PER SPECIE (CLASSE DERIVATA)

        string input;
        bool loop;
        string nome_animale;
        int eta_animale; 

        do
        {
            Console.WriteLine("[1] - Aggiungi animale\n[2] - Rimuovi animale\n[3] - Esci");

            switch(input)
            {
                case "1": //AGGIUNTA ANIMALI
                    do
                    {
                        Console.WriteLine("[1] - Gallina\n[2] - Cane\n[3] - Maiale"); //MENU SCELTA ANIMALE
                        input = Console.ReadLine();
                    } while (input != "1" && input != "2" && input != 3);
                    //InserDatiAnimale(out nome_animale, out eta_animale);

                    switch (input)
                    {
                        case "1":
                            //AggiungiGallina();
                            break;
                        case "1":
                            //AggiungiCane();
                            break;
                        case "1":
                            //AggiungiMaiale();
                            break;
                        default:
                            break;
                    }
                    break;

                case "2": //RIMOZIONE ANIMALE 
                    break;
                    
                case "3": //USCITA DAL PROGRAMMA
                    loop = false; 
                    break;

                default:
                    break;
            }
        }
        while(loop);
    }
   /*  static bool CheckInt(string s, out int n)
    {
        if(int.TryParse(s, out n))
        {
            
        }
    } */
    //static void InserDatiAnimale(out string nome_animale, out int eta_animale)
}