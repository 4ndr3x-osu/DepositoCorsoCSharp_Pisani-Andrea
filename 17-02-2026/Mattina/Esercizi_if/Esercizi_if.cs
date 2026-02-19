using System;

class Program()
{
    static void Main(string[] args)
    {
        //----- ESERCIZIO 1
        const int MAGGIORE_ETA = 18;
        
        Console.WriteLine("Quanti anni hai?: ");
        int eta = int.Parse(Console.ReadLine());
        
        if (eta >= MAGGIORE_ETA)
        {
            Console.WriteLine($"Sei maggiorenne");
        }

        if (eta < MAGGIORE_ETA)
        {
            Console.WriteLine($"Sei minorenne");
        }



        //-----ESERCIZIO 2
        Console.WriteLine("Scrivi il prezzo di un prodotto: ");
        double prezzo = double.Parse(Console.ReadLine());
        if(prezzo > 100)
        {
            prezzo = prezzo * 0.9;
            Console.WriteLine("Sconto applicato!");
        }
        Console.WriteLine($"Prezzo finale: {prezzo}");



        //-----ESERCIZIO 3
        Console.WriteLine("Scrivi il primo numero: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Scrivi il secondo numero: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Scrivi il terzo numero: ");
        int c = int.Parse(Console.ReadLine());
        
        float media = (float)(a + b + c) / 3;

        if (media>=60)
        {
            Console.WriteLine($"Hai superato la prova con media: {media} punti!");
        }
        if (media<60)
        {
            Console.WriteLine($"Prova fallita con media: {media} punti");
        }
    }
}