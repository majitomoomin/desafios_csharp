using System;

namespace desafio3
{
    class sumadevalores
    {
        static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer valor: ");
                int valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundp número: ");
                int valor2 = int.Parse(Console.ReadLine());
                int suma = valor1 + valor2;
                Console.WriteLine($"La Suma de los valores es: {suma}");
            }
            catch(FormatException)
            {
                Console.Error.WriteLine("Error: debes ingresar un número valido");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"Error inesperado: {e.Message}");
            }
        }

    }
}
