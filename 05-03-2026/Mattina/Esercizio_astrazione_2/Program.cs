using System;

class Program//--------------------Progresso: richieste principali svolte (NO EXTRA)
{
    static void Main(string[] args)
    {
        List<IPagamento> pagamenti = new List<IPagamento>();
        pagamenti.Add(new PagamentoCarta("MasterCard"));
        pagamenti.Add(new PagamentoContanti());
        pagamenti.Add(new PagamentoPayPal("andreap2007@proton.me"));
        Random importo = new Random();

        foreach(IPagamento pagamento in pagamenti)
        {
            pagamento.EseguiPagamento(35.00);
            pagamento.MostraMetodo();
        }
    }
}