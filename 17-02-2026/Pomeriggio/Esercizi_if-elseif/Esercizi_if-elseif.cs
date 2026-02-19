using System;

class Program()
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        Console.WriteLine("Scrivi un voto da 1 a 10: ");
        int voto = int.Parse(Console.ReadLine());

        if(voto >= 9 && voto <= 10)
        {
            Console.WriteLine("Ottimo");
        }
        else if(voto >= 7 && voto <= 8)
        {
            Console.WriteLine("Buono");
        }
        else if(voto >= 5 && voto <= 6)
        {
            Console.WriteLine("Sufficiente");
        }
        else if(voto >= 1 && voto <= 4)
        {
            Console.WriteLine("Ottimo");
        }
        else /* if (voto <= 0 || voto >= 11) */
        {
            Console.WriteLine("Voto non accettato");
        }

        //-----ESERCIZIO 2
        Console.WriteLine("Inserisci il tuo peso: ");
        int peso = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci la tua altezza in m: ");
        float altezza = float.Parse(Console.ReadLine());

        float bmi = (float) (peso / (altezza * altezza));

        if(bmi >= 30)
        {
            Console.WriteLine($"Obesità - BMI: {bmi}");
        }
        else if(bmi >= 25 && bmi < 30)
        {
            Console.WriteLine($"Sovrappeso - BMI: {bmi}");
        }
        else if(bmi >= 18.5f && bmi < 25)
        {
            Console.WriteLine($"Normopeso - BMI: {bmi}");
        }
        else if (bmi < 18.5f)
        {
            Console.WriteLine($"Sottopeso - BMI: {bmi}");
        }



        //-----ESERCIZIO 3
        Console.WriteLine("Inserire temperatura da convertire in °C: ");
        float gradi_c = float.Parse(Console.ReadLine());

        Console.WriteLine("Scegliere l'unità di misura di conversione: ");
        Console.WriteLine("1. Fahrenheit \n2. Kelvin \n3. Rankine");
        int scelta = int.Parse(Console.ReadLine());
        if(scelta == 1)
        {
            Console.WriteLine($"Temperatura Fahrenheit: {(gradi_c * 0.8) + 32} °F");
        }
        else if(scelta == 2)
        {
            Console.WriteLine($"Temperatura Kelvin: {gradi_c + 273.15} °K");
        }
        else if(scelta == 3)
        {
            Console.WriteLine($"Temperatura Fahrenheit: {(gradi_c * 1.8) + 491.67} °R");
        }
        else
        {
            Console.WriteLine("Scelta non valida");
        }
    }
}
