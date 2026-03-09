using System;

class Program
{
    public static void Main(string[] args)
    {
        ConfigurazioneSistema ModuloA = ConfigurazioneSistema.Instance();
        ModuloA.Imposta("Lingua tastiera", "Italiano");
        ModuloA.Imposta("Lingua tastiera", "Italiano");

        ConfigurazioneSistema ModuloB = ConfigurazioneSistema.Instance();
        ModuloB.Imposta("Versione", "23.2.2475 23H2");

        ModuloB.Leggi("Versione");

        ModuloA.StampaTutte();
    }
}