using System;

class Palindromo
{
    public static bool EsPalindromo(string texto)
    {
        string inverso = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            inverso += texto[i];
        }
        return texto.ToLower() == inverso.ToLower();
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine() ?? "";

        if (Palindromo.EsPalindromo(palabra))
            Console.WriteLine("La palabra es un palíndromo.");
        else
            Console.WriteLine("La palabra no es un palíndromo.");
    }
}
