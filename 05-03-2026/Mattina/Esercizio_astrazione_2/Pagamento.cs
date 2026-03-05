public interface IPagamento//--------------------Progresso: richieste principali svolte (NO EXTRA)
{

    void EseguiPagamento(decimal importo);
    void MostraMetodo();

}



public class PagamentoCarta : IPagamento
{
    string Circuito;

    public PagamentoCarta(string circuito)
    {
        Circuito = circuito;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta {Circuito}");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: Carta di credito");
    }

}



public class PagamentoContanti : IPagamento
{

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: Contanti");
    }

}



public class PagamentoPayPal : IPagamento
{

    string EmailUtente;
    public PagamentoPayPal(string emailutente)
    {
        EmailUtente = emailutente;
    }


    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro tramite PayPal da {EmailUtente}");
    }


    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: PayPal");
    }

}