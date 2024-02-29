using System;

class Program
{
    static void CalcularPromedio()
    {
        double ingresos1er, ingresos2do, ingresos3r, suma, promedio;
        string nombre;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Digite el ingreso del primer mes: ");
        ingresos1er = double.Parse(Console.ReadLine());
        
        Console.Write("Digite el ingreso del segundo mes: ");
        ingresos2do = double.Parse(Console.ReadLine());

        Console.Write("Digite el ingreso del primer mes: ");
        ingresos3r = double.Parse(Console.ReadLine());

        suma = ingresos1er + ingresos2do + ingresos3r;
        promedio = suma / 3;

        Console.WriteLine($"hola {nombre} en total ganaste {suma} y promediaste {promedio}");
    }

    static void Main(string[] args)
    {
        CalcularPromedio();
    }
}
