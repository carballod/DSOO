// Modifica la salida de la resolución del punto 2.
// Se pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no.

using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            do
            {

                Console.Write("Ingresa el nombre del participante (o 'FIN' para terminar): ");
                nombre = Console.ReadLine();

                if (nombre.ToLower() == "fin") break;

                double puntajeTotal = 0;

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Ingresa el puntaje del jurado " + i + ": ");
                    double puntaje = Convert.ToDouble(Console.ReadLine());
                    puntajeTotal += puntaje;
                }

                if (puntajeTotal > 80)
                {
                    Console.WriteLine("El participante " + nombre + " llego a la ultima etapa.");
                }
                else
                {
                    Console.WriteLine("El participante " + nombre + " no llegó a la última etapa.");
                }

                Console.WriteLine();

            } while (nombre.ToLower() != "fin");

            Console.Write("Fin del programa");
        }
    }
}
