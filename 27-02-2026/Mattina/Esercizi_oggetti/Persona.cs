using System;

//-----------------------------------Classe Esercizio 2
public class Persona
{
    public string Nome;
    public string Cognome;
    public int AnnoNascita;

    public Persona(string nome, string cognome, int annonascita)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annonascita;
    }

    public void StampaPersona()
    {
        Console.WriteLine($"{Nome} {Cognome} è nato nel {AnnoNascita}");
    }
}