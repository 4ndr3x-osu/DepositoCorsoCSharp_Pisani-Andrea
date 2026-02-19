﻿using System;

class Program()
{
    static void Main(string[] args)
    {
        int a = 10, b = 15;
        /* if (condizione == true)
        {
            esegui codice all'interno delle graffe
        } */
        if (a > b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }
        else
        {
            Console.WriteLine($"{a} è minore di {b}");
        }
    }
}