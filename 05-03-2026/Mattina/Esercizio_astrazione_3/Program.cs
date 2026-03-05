using System;

class Program //--------------------Progresso: richieste principali svolte (NO EXTRA)
{
    static void Main(string[] args)
    {
        List<Corso> corsi = new List<Corso>();
        corsi.Add(new CorsoInPresenza("Aula 5", 15, "Programmazione in C#", 120));
        corsi.Add(new CorsoOnline("Google Meet", "meet.google.com/123-456-789", "Come usare Unity", 60));

        foreach(Corso c in corsi)
        {
            c.ErogaCorso();
            c.StampaDettagli();
        }
    }
}