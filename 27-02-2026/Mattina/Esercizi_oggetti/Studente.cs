using System;

//-----------------------------------Classe Esercizio 1
public class Studente
{
    public string Nome;
    public int Matricola;
    public double MediaVoti;

    public Studente(string nome, int matricola, double mediavoti)
    {
        Nome = nome;
        Matricola = matricola;
        MediaVoti = mediavoti;
    }

    public void StampaStudente()
    {
        Console.WriteLine($"Nome: {Nome}, Matricola: {Matricola}, Media Voti: {MediaVoti}");
    }
}