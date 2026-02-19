using System;

class Program()
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        Console.WriteLine("Scrivi un numero da 1 a 7: ");
        int giorno = int.Parse(Console.ReadLine());

        switch(giorno)
        {
            case 1:
                Console.WriteLine("Lunedì");
                break;
            case 2:
                Console.WriteLine("Martedì");
                break;
            case 3:
                Console.WriteLine("Mercoledì");
                break;
            case 4:
                Console.WriteLine("Giovedì");
                break;
            case 5:
                Console.WriteLine("Venerdì");
                break;
            case 6:
                Console.WriteLine("Sabato");
                break;
            case 7:
                Console.WriteLine("Domenica");
                break;
            default:
                Console.WriteLine("Numero non valido");
                break;
        }



        //-----ESERCIZIO 1
        Console.WriteLine("Scegli una figura geometrica per calcolarne l'area:");
        Console.WriteLine("[1] - Quadrato \n[2] - Cerchio \n[3] - Triangolo");
        int scelta = int.Parse(Console.ReadLine());

        switch(scelta)
        {
            case 1:
                Console.WriteLine("Inserire lunghezza lato in cm: "); //Quadrato
                float l = float.Parse(Console.ReadLine());

                Console.WriteLine($"Area quadrato: {l * l} cm2");

                break;


            case 2:
                Console.WriteLine("Inserire raggio in cm: "); //Cerchio
                float r = float.Parse(Console.ReadLine());

                Console.WriteLine($"Area cerchio: {(r * r) * 3.14} cm2");

                break;


            case 3:
                Console.WriteLine("Inserire base del triangolo in cm: "); //Triangolo
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("Inserire altezza del triangolo in cm: ");
                float h = float.Parse(Console.ReadLine());

                Console.WriteLine($"Area cerchio: {(b * h) / 2} cm2");

                break;


            default:
                Console.WriteLine("Numero non valido"); //default (numero non compreso tra 1 e 3)
                break;
        }



        //-----ESERCIZIO 3
        Console.WriteLine("Inserisci un numero: ");
        int n = int.Parse(Console.ReadLine());
        bool pari = n % 2 == 0;

        switch (pari)
        {
            case (true):
                Console.WriteLine("Il numero è pari");
                if (n * n > 100)
                {
                    Console.WriteLine("Il quadrato del numero è superiore a 100");
                }
                else
                {
                    Console.WriteLine("Il quadrato del numero è inferiore a 100");
                }
                break;


            case (false):
                Console.WriteLine("Il numero è dispari");
                if (n * n > 100)
                {
                    Console.WriteLine("Il quadrato del numero è superiore a 100");
                }
                else
                {
                    Console.WriteLine("Il quadrato del numero è inferiore a 100");
                }
                break;


            default:
                Console.WriteLine("Numero non valido");
                break;
        }
    }
}
