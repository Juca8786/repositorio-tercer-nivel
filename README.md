using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> materias = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia"
        };

        Console.WriteLine("Lista original:");
        MostrarLista(materias);

        // Modificar un elemento
        materias[1] = "Lengua";

        Console.WriteLine("\nLista modificada:");
        MostrarLista(materias);
    }

    static void MostrarLista(List<string> lista)
    {
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
