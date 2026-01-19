using System;
using System.Collections.Generic;

class Asignaturas
{
    public List<string> ListaAsignaturas { get; set; }

    public Asignaturas()
    {
        ListaAsignaturas = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };
    }

    public void MostrarAsignaturas()
    {
        foreach (string asignatura in ListaAsignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}

class Program
{
    static void Main()
    {
        Asignaturas asignaturas = new Asignaturas();
        Console.WriteLine("Asignaturas registradas:");
        asignaturas.MostrarAsignaturas();
    }
}
