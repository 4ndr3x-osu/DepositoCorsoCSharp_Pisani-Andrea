using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main()
    {
        bool loop = true;
        using var db = new ProdottoContext();
        string input = "";
        string query = "";
        decimal prezzo = 0.0m;
        int id = 0;
            
        Console.WriteLine("Connessione al database in corso...");
        db.Database.EnsureCreated();

        do
        {
            Console.WriteLine("[1] - Inserisci prodotto\n[2] - Visualizza prodotti\n[3] - Rimuovi prodotto\n[0] - Esci");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("Inserisci il nome del prodotto: ");
                    input = Console.ReadLine();

                    Console.WriteLine("Inserisci il prezzo del prodotto: ");
                    if(!CheckDecimal(Console.ReadLine(), ref prezzo)) break;
                    else
                    {
                        var nuovo_prod = new Prodotto{Nome = input, Prezzo = prezzo};
                        db.Prodotti.Add(nuovo_prod);
                        db.SaveChanges();

                        Console.WriteLine($"Aggiunto prodotto con id: {nuovo_prod.Id}");
                    }
                    break;

                case "2":
                    var lista = db.Prodotti.ToList();
                    foreach (var s in lista)
                    {
                        Console.WriteLine($"{s.Id} - {s.Nome} --- {s.Prezzo:F2} Euro");
                    }
                    break;
                case "3":
                    Console.WriteLine("Inserisci l'id del prodotto da rimuovere: ");
                    if(!CheckInt(Console.ReadLine(), ref id)) break;
                    else
                    {
                        var remove_prod = db.Prodotti.Find(id);
                        if(remove_prod != null)
                        {
                            db.Prodotti.Remove(remove_prod);
                            db.SaveChanges();
                            Console.WriteLine($"Prodotto \"{remove_prod.Nome}\" rimosso con successo");
                        }
                        else Console.WriteLine("Nessun prodotto trovato");
                    }
                    break;

                case "0":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
            } while (loop);
    }



    public static bool CheckDecimal(string s, ref decimal n)
    {
        if(!decimal.TryParse(s, out n))
        {
            Console.WriteLine("Prezzo non valido");
            return false;
        }
        return true;
    }

    public static bool CheckInt(string s, ref int n)
    {
        if(!int.TryParse(s, out n))
        {
            Console.WriteLine("Id non valido");
            return false;
        }
        return true;
    }
}