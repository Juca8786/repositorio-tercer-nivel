class ListaEnlazada
{
    private Nodo cabeza;

    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        cabeza = anterior;
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}
