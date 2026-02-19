using System;

class Program
{
    static void Main(string[] args)
    {
        string scelta;
        int dimensione;
        do
        {
            Console.WriteLine("Scegli il tipo di array per l'operazione: \n[1] - Stringhe \n[2] - Interi \n[3] - Esci");
            scelta = Console.ReadLine();
            do
            {
                Console.WriteLine("Scrivi la dimensione dell'array: ");
                dimensione = int.Parse(Console.ReadLine());
            }
            while(dimensione < 1 && scelta !="3");
            switch (scelta)
            {
                case "1":
                    string[] arr_stringhe = new string[dimensione];

                    for(int i = 0; i < arr_stringhe.Length; i++)
                    {
                        Console.WriteLine($"Stringa n° {i}");
                        Console.Write("Scrivi il contenuto della stringa: ");
                        arr_stringhe[i] = Console.ReadLine();
                    }

                    foreach(string parola in arr_stringhe)
                    {
                        foreach(char carattere in parola)
                        {
                            Console.WriteLine(carattere);
                        }
                        Console.WriteLine("\n");
                    }
                    break;



                case "2":
                    int[] arr_int = new int[dimensione];

                    for(int i = 0; i < arr_int.Length; i++)
                    {
                        Console.Write($"Scrivi il numero per l'indice {i}: ");
                        arr_int[i] = int.Parse(Console.ReadLine());
                    }

                    foreach(int n in arr_int)
                    {
                        Console.WriteLine(n);
                    }
                    break;
                case "3":
                    break;
                default:
                    break;
            }
            if(scelta != "3" && scelta == "1" || scelta == "2")
            {
                while(scelta == "1" && scelta == "2");
                {
                    Console.WriteLine("Vuoi ripetere l'operazione? \n[1] - Sì \n[2] - No\n");
                    scelta = Console.ReadLine();
                    if(scelta != "1" && scelta != "2")
                    {
                        Console.WriteLine("Scelta non valida");
                    }
                    else if(scelta == "2")
                    {
                        scelta = "3";
                    }
                }


            }
        }
        while(scelta != "3");
    }
}