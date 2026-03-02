using System;

class Libri
{
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public Libri(string titolo, string autore, int annopubblicazione)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = annopubblicazione;
    }

    public override string ToString()
    {
        return $"\"{Titolo}\" di {Autore} ({AnnoPubblicazione})";
    }

    public override bool Equals(object obj)
    {
        if(obj is Libri l2)
        {
            return this.Titolo == l2.Titolo && this.Autore == l2.Autore;
        }
        return false;
    }
}