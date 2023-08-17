// Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos,
// es decir, puede ser un número de dos dígitos como un número de 6 dígitos.
// Tomá la codificación anterior e introducí los cambios que sean necesarios.

using System;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero no negativo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                int numeroOriginal = numero;
                int suma = 0;

                Console.Write($"{numeroOriginal % 10}");
                suma += numeroOriginal % 10;
                numeroOriginal /= 10;

                while (numeroOriginal > 0)
                {
                    Console.Write($" + {numeroOriginal % 10}");
                    suma += numeroOriginal % 10;
                    numeroOriginal /= 10;
                }

                Console.WriteLine($" = {suma}");
            }
            else
            {
                Console.WriteLine("El número ingresado debe ser no negativo.");
            }
        }
    }
}
