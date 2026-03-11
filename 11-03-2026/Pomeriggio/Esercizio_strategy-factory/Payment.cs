public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagato importo di {amount}€ --- Metodo: Carta di credito");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagato importo di {amount}€ --- Metodo: PayPal");
    }
}

public class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagato importo di {amount}€ --- Metodo: Bitcoin");
    }
}

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public void SetStrategy(IPaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }

    public void Pay(decimal amount)
    {
        if(_paymentStrategy == null)
        {
            Console.WriteLine("Nessun metodo di pagamento selezionato");
            return;
        }
        _paymentStrategy.Pay(amount);
    }
}

public class PaymentStrategyFactory
{
    public static IPaymentStrategy CreateStrategy(string i)
    {
        switch(i)
        {
            case "1":
                return new CreditCardPayment();
            case "2":
                return new PayPalPayment();
            case "3":
                return new BitcoinPayment();
            default:
                return null;
        }
    }
}