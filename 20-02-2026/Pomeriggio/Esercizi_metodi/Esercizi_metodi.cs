using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        #region ESERCIZIO 1

        string intS;
        int num = 0;

        do
        {
            Console.WriteLine("Inserisci un intero: ");
            intS = Console.ReadLine();

            if(int.TryParse(intS, out num))
            {
                Console.WriteLine($"Valore attuale: {num}");
                Raddoppia(ref num);
                Console.WriteLine($"Valore raddoppiato: {num}");
            }
            else
            {
                Console.WriteLine("Inserimento non valido");
            }
        }
        while(!(int.TryParse(intS, out num)));
        #endregion



        //-----ESERCIZIO 2
        #region ESERCIZIO 2

        int giorno = 1;
        int mese = 1;
        int anno = 0;
        int temp = 0;
        string scelta;
        string input;

        do
        {
            Console.WriteLine("Cosa vuoi aumentare? \n[1] - Giorni \n[2] - Mesi \n[3] - Anni \n[4] - Esci");
            scelta = Console.ReadLine();

            switch(scelta)
            {
                case "1":
                    do
                    {
                        Console.Write("Inserisci il numero di giorni da aumentare: ");
                        input = Console.ReadLine();
                        if(!(int.TryParse(input, out temp)))
                        {
                            Console.WriteLine("Scelta non valida\n");
                        }
                        else
                        {
                            giorno += temp;
                            AggiustaData(ref giorno, ref mese, ref anno);
                            Console.WriteLine($"Ora la data è {giorno}/{mese}/{anno}");
                        }
                    }
                    while(!(int.TryParse(input, out temp)));
                    break;



                case "2":
                    do
                    {
                        Console.Write("Inserisci il numero di mesi da aumentare: ");
                        input = Console.ReadLine();
                        if(!(int.TryParse(input, out temp)))
                        {
                            Console.WriteLine("Scelta non valida\n");
                        }
                        else
                        {
                            mese += temp;
                            AggiustaData(ref giorno, ref mese, ref anno);
                            Console.WriteLine($"Ora la data è {giorno}/{mese}/{anno}");
                        }
                    }
                    while(!(int.TryParse(input, out temp)));
                    break;



                case "3":
                    do
                    {
                        Console.Write("Inserisci il numero di anni da aumentare: ");
                        input = Console.ReadLine();
                        if(!(int.TryParse(input, out temp)))
                        {
                            Console.WriteLine("Scelta non valida\n");
                        }
                        else
                        {
                            anno += temp;
                            AggiustaData(ref giorno, ref mese, ref anno);
                            Console.WriteLine($"Ora la data è {giorno}/{mese}/{anno}");
                        }
                    }
                    while(!(int.TryParse(input, out temp)));
                    break;



                case "4":
                    break;



                default:
                    Console.WriteLine("Scelta non valida\n");
                    break;
            }
        }
        while(scelta != "4");
        #endregion



        //-----ESERCIZIO 3
        #region ESERCIZIO 3

        float num1 = 0.0f;
        float num2 = 0.0f;
        float quoziente = 0.0f;
        float resto = 0.0f;
        string temp1 = "";

        do
        {
            Console.Write("Inserisci il primo numero: ");
            temp1 = Console.ReadLine();

            if(!(float.TryParse(temp1, out num1)))
            {
                Console.WriteLine("Numero non valido");
            }
        }
        while(!(float.TryParse(temp1, out num1)));

        do
        {
            Console.Write("Inserisci il secondo numero: ");
            temp1 = Console.ReadLine();

            if(!float.TryParse(temp1, out num2))
            {
                Console.WriteLine("Numero non valido");
            }
        }
        while(!(float.TryParse(temp1, out num2)));

        CalcoloQuoziente(num1, num2, out quoziente, out resto);
        Console.WriteLine($"Il risultato di {num1} / {num2} è {quoziente} ||| Il resto di {num1} / {num2} è {resto}");

        #endregion



        //-----ESERCIZIO 4
        #region ESERCIZIO 4

        string parola;
        int n_vocali;
        int n_consonanti;
        int n_spazi;

        Console.Write("Scrivi una frase o una parola: ");
        parola = Console.ReadLine();
        AnalizzaParola(parola, out n_vocali, out n_consonanti, out n_spazi);
        Console.WriteLine($"Analisi completata!\nN° vocali: {n_vocali}\tN° consonanti: {n_consonanti}\tN° spazi: {n_spazi}\t");

        #endregion
    
    
    
        //-----ESERCIZIO 5
        #region ESERCIZIO 5

        int turni = 3;
        int punteggio;
        int totale = 0;
        int bonus = 0;
        float media = 0.0f;
        //string temp1 = "";

        for(int i = 0; i < turni; i++)
        {
            do
            {
                Console.Write($"\nScrivi il punteggio del turno {i + 1}: ");
                temp1 = Console.ReadLine();

                if(!int.TryParse(temp1, out punteggio))
                {
                    Console.WriteLine("Il punteggio inserito non è valido");
                }

                AggiornaPunteggio(ref punteggio, ref totale, ref bonus, out media, i, turni);
                Console.WriteLine($"\nDati attuali: \tTurno: {i + 1}\tSomma punti: {totale}\tBonus: {bonus}");
            }
            while(!int.TryParse(temp1, out punteggio));
        }
        Console.WriteLine($"Dati finali: \nTotale punti: {totale}(Bonus: {bonus}) || Media punti per turno: {media}");

        #endregion
    
    
    
        //-----ESERCIZIO 6
        #region ESERCIZIO 6

        int voto1;
        int voto2;
        double mediaVoti;
        bonus = 0;
        //string temp1;

        do
        {
            Console.Write("\nScrivi il primo voto: ");
            temp1 = Console.ReadLine();

            if(!int.TryParse(temp1, out voto1))
            {
                Console.WriteLine("Il voto inserito non è valido");
            }
        }
        while(!int.TryParse(temp1, out voto1));

        do
        {
            Console.Write("\nScrivi il secondo voto: ");
            temp1 = Console.ReadLine();
            
            if(!int.TryParse(temp1, out voto2))
            {
                Console.WriteLine("Il voto inserito non è valido");
            }
        }
        while(!int.TryParse(temp1, out voto2));
        
        bool promosso = ElaboraStudente(voto1, voto2, ref bonus, out mediaVoti);

        if(promosso)
        {
            Console.WriteLine($"Studente promosso con media: {mediaVoti} e bonus totale {bonus}: ");
        }
        else
        {
            Console.WriteLine($"Studente bocciato con media: {mediaVoti} e bonus totale {bonus}: ");
        }

        #endregion
    }



    #region METODI



    //METODO ESERCIZIO 1
    #region METODO ESERCIZIO 1
    static void Raddoppia(ref int n)
    {
        n *= 2;
    }

    #endregion



    //METODO ESERCIZIO 2
    #region METODO ESERCIZIO 2
    static void AggiustaData(ref int g, ref int m, ref int a)
    {
        do
        {
            if(g > 30)
            {
                g = g - 30;
                m++;
            }
            else if(g <= 0)
            {
                g = 30 - g;
                m--;
            }
        }
        while(g > 30 && g <= 0);
        do
        {
            if(m > 12)
            {
                m = m - 12;
                a++;
            }
            else if(m <= 0)
            {
                m = 12 - m;
                a--;
            }
        }
        while(m > 12);
    }
    #endregion



    //METODO ESERCIZIO 3
    #region METODO ESERCIZIO 3
    static void CalcoloQuoziente(float n1, float n2, out float q, out float r)
    {
        q = n1 / n2;
        r = n1 % n2;
    }
    #endregion



    //METODO ESERCIZIO 4
    #region METODO ESERCIZIO 4
    static void AnalizzaParola(string par, out int voc, out int cons, out int sp)
    {
        voc = 0;
        cons = 0;
        sp = 0;
        string[] v = new string[]{"a","e","i","o","u"};
        string[] co = new string[]{"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","t","v","w","x","y","z"};
        foreach(char c in par)
        {
            for(int i = 0; i < v.Length; i++)
            {
                if(char.ToLower(c) == char.Parse(v[i]))
                {
                    voc++;
                    break;
                }
            }
            for(int i = 0; i < co.Length; i++)
            {
                if(char.ToLower(c) == char.Parse(co[i]))
                {
                    cons++;
                    break;
                }
            }
            if(c == ' ')
            {
                sp++;
            }
        }
    }
    #endregion



    //METODO ESERCIZIO 5
    #region METODO ESERCIZIO 5

    static void AggiornaPunteggio(ref int p, ref int tot, ref int b, out float m, int t, int max_t)
    {
        m = 0;
        if(p >= 10)
        {
            b += 3;
            Console.WriteLine("Bonus: 3 punti");
        }
        else if(p < 10 && p > 6)
        {
            b += 2;
            Console.WriteLine("Bonus: 2 punti");
        }
        else if(p < 6 && p > 3)
        {
            b += 1;
            Console.WriteLine("Bonus: 1 punto");
        }
        tot += p;
        if (t == max_t-1)
        {
            tot += b;
            m = tot / max_t;
        }
    }

    #endregion



    //METODO ESERCIZIO 6
    #region METODO ESERCIZIO 6
    static bool ElaboraStudente(int v1, int v2, ref int b, out double m)
    {
        bool p = false;
        int[] voti = new int[]{v1, v2};
        for(int i = 0; i < voti.Length; i++)
        {
            if(voti[i] < 10 && voti[i] >= 7)
            {
                b += 1;
                Console.WriteLine("Bonus: 1 punto\n");
            }
            else if(voti[i] < 7 && voti[i] >=4)
            {
                b += 2;
                Console.WriteLine("Bonus: 2 punti\n");
            }
            else if(voti[i] < 4 && voti[i] >=0)
            {
                b += 3;
                Console.WriteLine("Bonus: 3 punti\n");
            }
        }
        m = (v1 + v2 + b) / 2;
        if(m >= 6.0d)
        {
            p = true;
        }
        return p;
    }
    #endregion
#endregion
}