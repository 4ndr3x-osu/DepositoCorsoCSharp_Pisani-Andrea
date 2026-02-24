using System;

class Program
{
    static void Main(string[] args)
    {
        #region ESERCIZIO 1
        int n_righe = 0;
        int n_colonne = 0;
        bool input_matrice = false;
        int somma_righe = 0;
        int somma_colonne = 0;

        Console.WriteLine("Inserisci il numero di righe della matrice: ");
        n_righe = InputMatrice(ref n_righe, input_matrice);
        
        Console.WriteLine("Inserisci il numero di colonne della matrice: ");
        n_colonne = InputMatrice(ref n_colonne, input_matrice);

        int[,] matrice = new int[n_righe, n_colonne];

        for(int i = 0; i < n_righe; i++)
        {
            for(int j = 0; j < n_colonne; j++)
            {
                Console.Write($"Inserisci il numero per la cella {i}-{j}: ");
                matrice[i,j] = InputMatrice(ref matrice[i,j], input_matrice);
            }
        }
        for(int i = 0; i < n_righe; i++)
        {
            for(int j = 0; j < n_colonne; j++)
            {
                somma_righe += matrice[i,j];
                somma_colonne += matrice[j,i];
            }
            Console.WriteLine($"Somma riga {i}: {somma_righe}");
            Console.WriteLine($"Somma colonna {i}: {somma_colonne}");
            somma_righe = 0;
            somma_colonne = 0;
        }
        #endregion

        #region ESERCIZIO 2
        int[,] matrice1 = new int[4,4];
        int[,] matrice2 = new int[4,4];
        int[] esito = new int[2]{0, 0};
        int matrice_size = 4;
        int somma_matrice1 = 0;
        int somma_matrice2 = 0;
        Random random = new Random();

        for(int i = 0; i < matrice_size; i++)
        {
            for(int j = 0; j < matrice_size; j++)
            {
                matrice1[i,j] = random.Next(1, 51);
                matrice2[i,j] = random.Next(1, 51);
            }
        }

        Console.WriteLine("Matrice 1: ");
        StampaMatrice(matrice1, matrice_size);

        Console.WriteLine("Matrice 2: ");
        StampaMatrice(matrice2, matrice_size);

        for(int i = 0; i < matrice_size; i++)
        {
            for(int j = 0; j < matrice_size; j++)
            {
                somma_matrice1 += matrice1[i,j];
                somma_matrice2 += matrice2[i,j];
            }

            if(somma_matrice1 == somma_matrice2)
            {
                Console.WriteLine($"Confronto sulla riga {i}: Pareggio");
            }
            else if(somma_matrice1 > somma_matrice2)
            {
                Console.WriteLine($"Confronto sulla riga {i}: Matrice 1 > Matrice 2");
                esito[0]++;
            }
            else
            {
                Console.WriteLine($"Confronto sulla riga {i}: Matrice 1 < Matrice 2");
                esito[1]++;
            }

            somma_matrice1 = 0;
            somma_matrice2 = 0;
        }

        if(esito[0] > esito[1])
        {
            Console.WriteLine("Matrice 1 vince il confronto");
        }
        else if(esito[0] < esito[1])
        {
            Console.WriteLine("Matrice 2 vince il confronto");
        }
        else
        {
            Console.WriteLine("Pareggio");
        }
        #endregion

        #region ESERCIZIO 3
        int[,] matrice_diagonale = new int[5,5];
        int size = 5;
        int diagonale1 = 0;
        int diagonale2 = 0;
        Random rand_diagonale = new Random();
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                matrice_diagonale[i,j] = rand_diagonale.Next(1, 21);
            }
        }
        Console.WriteLine("Matrice: ");
        StampaMatrice(matrice_diagonale, size);
        for(int i = 0, j = size-1; i < size; i++, j--)
        {
            Console.WriteLine($"{i} // {j}");
            diagonale1 += matrice_diagonale[i , i];
            diagonale2 += matrice_diagonale[j, i];
        }
        Console.WriteLine($"Somma diagonale principale: {diagonale1}");
        Console.WriteLine($"Somma diagonale secondaria: {diagonale2}");
        if(diagonale1 > diagonale2)
        {
            Console.WriteLine("La diagonale principale è più grande della diagonale secondaria");
        }
        else if(diagonale1 < diagonale2)
        {
            Console.WriteLine("La diagonale secondaria è più grande della diagonale primaria");
        }
        else
        {
            if(diagonale1 > diagonale2)
        {
            Console.WriteLine("Entrambe le diagonali sono uguali");
        }
        }
        #endregion
    }


        #region METODI ESERCIZIO 1
        static int InputMatrice(ref int a, bool m)
        {
            do
            {
                ControlloMatrice(ref a, m);
            }
            while(a <= 0);
            return a;
        }

        static void ControlloMatrice(ref int n, bool i)
        {
            if(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Inserimento non valido");
            }
            else if(n <= 0 && !i)
            {
                Console.WriteLine($"Impossibile assegnare un valore inferiore a 1.");
            }
        }

        #endregion
        #region METODI ESERCIZIO 2
        static void StampaMatrice(int[,] m, int s)
        {
            for(int i = 0; i < s; i++)
            {
                for(int j = 0; j < s; j++)
                {
                    Console.Write($"{m[i,j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        #endregion
    }
