public interface IVeicolo
    {
        void Avvia();
        void MostraTipo();
    }

    // 2. Le classi concrete dentro il namespace
    public class Auto : IVeicolo
    {
        public void Avvia() => Console.WriteLine("Avvio dell'auto");
        public void MostraTipo() => Console.WriteLine("Tipo: Auto");
    }

    public class Moto : IVeicolo
    {
        public void Avvia() => Console.WriteLine("Avvio della moto");
        public void MostraTipo() => Console.WriteLine("Tipo: Moto");
    }

    public class Camion : IVeicolo
    {
        public void Avvia() => Console.WriteLine("Avvio del camion");
        public void MostraTipo() => Console.WriteLine("Tipo: Camion");
    }

    // 3. La Factory dentro il namespace
    public class VeicoloFactory
    {
        public static IVeicolo? CreaVeicolo(string? tipo)
        {
            switch (tipo.ToLower())
            {
                case "auto": 
                    return new Auto();
                case "moto": 
                    return new Moto();
                case "camion": 
                    return new Camion();
                default:
                    Console.WriteLine("Tipo veicolo non riconosciuto.");
                    return null;
            }
        }
    }