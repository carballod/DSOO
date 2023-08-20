// Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos.
// Por ejemplo, la suma de los dígitos del 3433 es 13.  Para darle un poco más de emoción,
// el programa no se limitará a escribir el resultado de la suma,
// sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.

using System;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero no negativo de 4 dígitos: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1000 && numero <= 9999)
            {
                int digito1 = numero / 1000;
                int digito2 = (numero / 100) % 10;
                int digito3 = (numero / 10) % 10;
                int digito4 = numero % 10;

                int suma = digito1 + digito2 + digito3 + digito4;

                Console.Write($"{digito1} + {digito2} + {digito3} + {digito4} = {suma}");
            }
            else
            {
                Console.WriteLine("El número ingresado no tiene 4 dígitos.");
            }
        }
    }
}
