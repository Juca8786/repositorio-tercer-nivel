using System;
using System.Collections.Generic;

class Loteria
{
    public List<int> Numeros { get; set; }

    public Loteria()
    {
        Numeros = new List<int>();
    }

    public void IngresarNumeros()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            Numeros.Add(int.Parse(Console.ReadLine() ?? "0"));
        }
    }

    public void MostrarOrdenados()
    {
        Numeros.Sort();
        Console.WriteLine("Números ordenados:");
        Console.WriteLine(string.Join(", ", Numeros));
    }
}

class Program
{
    static void Main()
    {
        Loteria loteria = new Loteria();
        loteria.IngresarNumeros();
        loteria.MostrarOrdenados();
    }
}
