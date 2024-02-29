using System;
using System.Security.Cryptography.X509Certificates;

class calculadora
{
    public int suma(int NUM1, int NUM2)
    { return NUM1 + NUM2; }

    public int resta(int NUM1, int NUM2)
    { return NUM1 - NUM2; }

    public int multiplicar(int NUM1, int NUM2)
    { return NUM1 * NUM2; }

    public int division(int NUM1, int NUM2)
    { return NUM1 / NUM2; }

    static void Main(String[] args)
    {
        calculadora calc = new calculadora();

        Console.WriteLine("Ingrese el primer número: ");
        int NUM1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        int NUM2 = int.Parse(Console.ReadLine());

        Console.WriteLine("La suma de ambos números es: " + calc.suma(NUM1, NUM2));
        Console.WriteLine("La resta de ambos números es: " + calc.resta(NUM1, NUM2));
        Console.WriteLine("La multiplicación de ambos números es: " + calc.multiplicar(NUM1, NUM2));
        Console.WriteLine("La división de ambos números es: " + calc.division(NUM1 , NUM2));
    }
}

