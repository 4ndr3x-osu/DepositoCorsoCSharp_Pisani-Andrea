using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        bool loop = true;
        string input = "";
        IVeicolo veicoli = null;
        RegistroVeicoli ls_veicoli = RegistroVeicoli.Istanza();
        do
        {
            do
            {
                Console.WriteLine("[1] - Aggiungi veicolo\n[2] - Mostra veicoli\n[3] - Esci");
                input = Console.ReadLine();
            } 
            while (!CheckMenu(input));

            switch(input)
            {
                case "1":
                    do
                    {
                        Console.WriteLine("Quale veicolo vuoi creare? (auto, moto, camion)");
                    input = Console.ReadLine();
                    veicoli = VeicoloFactory.CreaVeicolo(input);
                    } 
                    while (veicoli == null);
                    ls_veicoli.Registra(veicoli);
                    ls_veicoli.StampaTutti();
                    break;

                case "2":
                    ls_veicoli.StampaTutti();
                    break;

                case "3":
                loop = false;
                    break;

                default:
                    break;
            }
        } while (loop);
    }

    static bool CheckMenu(string inp)
    {
        if(inp == "1" || inp == "2" || inp == "3")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Inserimento non valido");
        }
        return false;
    }
}