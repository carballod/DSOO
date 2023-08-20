using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SuperHeroe superHeroe1 = new SuperHeroe("Batman", 90, 70, 0);
            SuperHeroe superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);

            string resultado1 = superHeroe1.Competir(superHeroe2);
            Console.WriteLine($"Resultado de la competencia 1: {resultado1}");

            string resultado2 = superHeroe2.Competir(superHeroe1);
            Console.WriteLine($"Resultado de la competencia 2: {resultado2}");

        }
    }
}
