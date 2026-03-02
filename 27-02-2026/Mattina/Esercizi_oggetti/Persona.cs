using System;

//-----------------------------------Classe Esercizio 2
public class Persona
{
    public string Nome;
    public string Cognome;
    public int AnnoNascita;

    public override string ToString()
    {
        return($"Nome: {Nome}, Cognome: {Cognome}, Anno nascita: {AnnoNascita}");
    }

    public Persona(string nome, string cognome, int annonascita)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annonascita;
    }
}