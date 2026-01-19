using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);

        Console.WriteLine("Número de elementos en la lista: " + lista.ContarElementos());
    }
}
