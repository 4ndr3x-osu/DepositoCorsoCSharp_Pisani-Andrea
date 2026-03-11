using System;

class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();
        string input="";
        bool loop=true;

        do
        {
            do
            {
                Console.WriteLine("[1] - Paga con carta di credito\n[2] - Paga con PayPal\n[3] - Paga con Bitcoin\n[4] - Esci");
                input = Console.ReadLine();

                if(input.ToLower() != "1" && input.ToLower() != "2" && input.ToLower() != "3" && input.ToLower() != "4") Console.WriteLine("Scelta non valida");
                else if(input.ToLower() == "4") 
                {
                    loop = false;
                    break;
                } 
                else context.SetStrategy(PaymentStrategyFactory.CreateStrategy(input));
            }
            while(context == null);

            if(loop != false) context.Pay(100m);
            context = new PaymentContext();
        }
        while(loop);
    }
}