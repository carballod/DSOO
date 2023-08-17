// En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos.
// El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados.
// Debe mostrar el nombre y el puntaje total de cada participante.
// Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.

using System;

namespace Ejercicio02
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
                    Console.WriteLine("El participante " + nombre + " tiene un puntaje total de " + puntajeTotal);
                }
                else
                {
                    Console.WriteLine("El participante " + nombre + " no supera los 80 puntos.");
                }

                Console.WriteLine();

            } while (nombre.ToLower() != "fin");

            Console.Write("Fin del programa");
        }
    }
}
