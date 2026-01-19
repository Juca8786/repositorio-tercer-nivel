using System;
using System.Collections.Generic;

class Nota
{
    public string Asignatura { get; set; }
    public double Valor { get; set; }
}

class RegistroNotas
{
    public List<Nota> Notas { get; set; }

    public RegistroNotas()
    {
        Notas = new List<Nota>();
    }

    public void IngresarNotas(List<string> asignaturas)
    {
        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Ingrese la nota de {asignatura}: ");
            double valor = double.Parse(Console.ReadLine() ?? "0");
            Notas.Add(new Nota { Asignatura = asignatura, Valor = valor });
        }
    }

    public void MostrarNotas()
    {
        foreach (var nota in Notas)
        {
            Console.WriteLine($"En {nota.Asignatura} ha obtenido {nota.Valor}");
        }
    }
}

class Program
{
    static void Main()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        RegistroNotas registro = new RegistroNotas();
        registro.IngresarNotas(asignaturas);
        registro.MostrarNotas();
    }
}
