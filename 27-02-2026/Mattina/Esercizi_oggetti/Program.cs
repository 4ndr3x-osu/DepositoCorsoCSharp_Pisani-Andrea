using System;


class Program
{
    public static void Main(string[] args)
    {
        //----------------------------------ESERCIZIO 1
        #region ESERCIZIO 1

        Studente s1 = new Studente("Andrea", 1, 8);
        Studente s2 = new Studente("Luca", 2, 9);

        s1.StampaStudente();
        s2.StampaStudente();

        #endregion

        //----------------------------------ESERCIZIO 2
        #region ESERCIZIO 2

        Persona p1 = new Persona("Mario", "Rossi", 1984);
        Persona p2 = new Persona("Andrea", "Pisani", 2007);

        p1.StampaPersona();
        p2.StampaPersona();
        #endregion



        //----------------------------------ESERCIZIO 3
        #region ESERCIZIO 3

        int numero1 = 0;
        int numero2 = 0;
        string input = "";

        Console.Write("Inserisci il primo numero: ");
        LoopInput(input, ref numero1);
        Console.Write("Inserisci il secondo numero: ");
        LoopInput(input, ref numero2);

        Operazioni numeri = new Operazioni(numero1, numero2);

        SvolgiOperazione(numeri, input);

        #endregion



        static bool CheckInt(string i, ref int n)
        {
            bool is_int = false;
            if(int.TryParse(i, out n))
            {
                is_int = true;
            }
            return is_int;
        }



        static void LoopInput(string inp, ref int n1)
        {
            bool isint = true;
            do
            {
                inp = Console.ReadLine();
                isint = CheckInt(inp, ref n1);

                if(!isint)
                {
                    Console.WriteLine("Il valore inserito non è un numero, ripetere l'inserimento");
                }
                else
                {
                    break;
                }
            }
            while(true);
        }

        static string SelezioneOperazione()
        {
            string i;
            do
            {
                Console.WriteLine("Quale operazione vuoi svolgere?\n[1]-Addizione\t[2]-Moltiplicazione");
                i = Console.ReadLine();
                if(i != "1" && i != "2")
                {
                    Console.WriteLine("Scelta non valida");
                }
            }
            while(i != "1" && i != "2");
            return i;
        }

        static void SvolgiOperazione(Operazioni o, string inp)
        {
            inp = SelezioneOperazione();
            if(inp == "1")
            {
                o.StampaSomma();
            }
            else
            {
                o.StampaProdotto();
            }
        }
    }
}