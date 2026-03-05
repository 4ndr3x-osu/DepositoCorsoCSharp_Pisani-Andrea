abstract class Corso//--------------------Progresso: richieste principali svolte (NO EXTRA)
{

    public string Titolo;
    private int _Durata_ore;

    public int Durata_ore
    {

        get{return _Durata_ore;}
        set
        {
            if(value > 0)
            {

                _Durata_ore = value;

            }

            else
            {

                Console.WriteLine("Impossibile creare un corso con durata inferiore a 1 ora");
                _Durata_ore = 1;

            }
        }
    }


    public Corso(string titolo, int durata_ore)
    {
        Titolo = titolo;
        Durata_ore = durata_ore;
    }


    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}

class CorsoInPresenza : Corso
{
    public string Aula;
    private int _NumeroPosti;

    public int NumeroPosti
    {

        get{return _NumeroPosti;}
        set
        {
            if(value > 1)
            {
                _NumeroPosti = value;
            }

            else
            {
                Console.WriteLine("Impossibile creare un corso con numero posti inferiore a 1");
                _NumeroPosti = 1;
            }
        }
    }


    public CorsoInPresenza(string aula, int numeroposti, string titolo, int durata_ore) : base(titolo, durata_ore)
    {
        Aula = aula;
        NumeroPosti = numeroposti;
    }


    public override void ErogaCorso()
    {
        Console.WriteLine("Tipo: Corso in presenza");
    }


    public override void StampaDettagli()
    {
        Console.WriteLine($"{Titolo}\nDurata: {Durata_ore}\nAula: {Aula}\nNum. posti: {NumeroPosti}\n");
    }

}

class CorsoOnline : Corso
{
    public string Piattaforma;
    public string Link;


    public CorsoOnline(string piattaforma, string link, string titolo, int durata_ore) : base(titolo, durata_ore)
    {
        Piattaforma = piattaforma;
        Link = link;
    }


    public override void ErogaCorso()
    {
        Console.WriteLine("Tipo: Corso online");
    }


    public override void StampaDettagli()
    {
        Console.WriteLine($"{Titolo}\nDurata: {Durata_ore}\nPiattaforma: {Piattaforma}\nLink: {Link}\n");
    }
}