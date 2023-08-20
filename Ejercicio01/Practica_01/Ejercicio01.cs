
// El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio,
// por lo tanto, el algoritmo debe calcular el precio final a abonar por un cliente.
// Se ingresa el precio del producto y como resultado muestra el precio de venta.

using System;

namespace Practica_01
{
    internal class Ejercicio01
    {
        static void Main(string[] args)
        {
            bool AgregarProducto = true;

            while (AgregarProducto)
            {
                Console.Write("Ingresa el precio del producto: ");
                double precioProducto = Convert.ToDouble(Console.ReadLine());

                double precioVenta = precioProducto * 1.15;

                Console.WriteLine("El precio de venta es: " + precioVenta);

                Console.Write("¿Queres seguir agregando productos? (S/N): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                {
                    AgregarProducto = false;
                }
            }

            Console.Write("Fin del programa");

        }
    }
}
