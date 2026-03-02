using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        #region ESERICIZIO 1
        //------------------------------------------------------------ESERCIZIO 1
        string titolo_libro = "", nome_autore = "";
        int anno_pubblicazione = 0;

        CreaLibro(out titolo_libro, out nome_autore, out anno_pubblicazione);
        Libri libro1 = new Libri(titolo_libro, nome_autore, anno_pubblicazione);

        Console.WriteLine(libro1);

        #endregion



        #region ESERCIZIO 2
        CreaLibro(out titolo_libro, out nome_autore, out anno_pubblicazione);
        Libri libro2 = new Libri(titolo_libro, nome_autore, anno_pubblicazione);

        if(libro1.Equals(libro2))
        {
            Console.WriteLine("Questi libri hanno lo stesso nome e autore ma anno di pubblicazione diversa: ");
            Console.WriteLine($"-{libro1}\n-{libro2}");
        }
        else
        {
            Console.WriteLine($"Questi sono i libri disponibili: -{libro1}\n-{libro2}");
        }
        #endregion
    }

    private static bool CheckInt(string i, int a_p)
    {
        if(int.TryParse(i, out a_p))
        {
            return true;
        }
        return false;
    }

    private static void CreaLibro(out string t, out string n, out int a)
    {
        a = 0;
        string input;

        Console.WriteLine("Inserisci il titolo del libro: ");
        t = Console.ReadLine();

        Console.WriteLine("Inserisci il nome dell'autore del libro: ");
        n = Console.ReadLine();

        do
        {
            Console.WriteLine("Inserisci l'anno di pubblicazione del libro: ");
            input = Console.ReadLine();
            if(!CheckInt(input, a))
            {
                Console.WriteLine("Inserimento non valido");
            }
        }
        while(!CheckInt(input, a));
    }
}
