using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        string input = "";
        bool loop = true;
        ShapeCreator forma = null;
        do
        {
            do
            {
                Console.WriteLine("Scegli la forma da disegnare (quadrato o cerchio): ");
                input = Console.ReadLine();
                if(input == "quadrato")
                {
                    forma = new SquareCreator();
                }
                if(input == "cerchio")
                {
                    forma = new CircleCreator();
                }
            }
            while(forma == null);

            IShape forma1 = forma.CreateShape(input);
            forma1.Draw();

            Console.WriteLine("Digita 0 per uscire");
            input = Console.ReadLine();
            if(input == "0") loop = false;
        }
        while(loop);
    }
}