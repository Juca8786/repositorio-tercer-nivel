using System;
using System.Collections.Generic;

class Estudiante
{
    public List<string> Asignaturas { get; set; }

    public Estudiante()
    {
        Asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };
    }

    public void MostrarMensaje()
    {
        foreach (var asignatura in Asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}

class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante();
        estudiante.MostrarMensaje();
    }
}
