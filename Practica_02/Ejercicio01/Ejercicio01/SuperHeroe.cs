using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    internal class SuperHeroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.nombre = nombre;
            this.fuerza = fuerza;
            this.resistencia = resistencia;
            this.superpoderes = superpoderes;
        }

        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public int Fuerza
        {
            get { return fuerza; }
            private set { fuerza = ValidateAttributeValue(value); }
        }

        public int Resistencia
        {
            get { return resistencia; }
            private set { resistencia = ValidateAttributeValue(value); }
        }

        public int Superpoderes
        {
            get { return superpoderes; }
            private set { superpoderes = ValidateAttributeValue(value); }
        }

        private int ValidateAttributeValue(int value)
        {
            if (value < 0)
                return 0;
            else if (value > 100)
                return 100;
            else
                return value;
        }

        public string Competir(SuperHeroe oponente)
        {
            int triunfos = 0;

            if (this.Fuerza > oponente.Fuerza)
                triunfos++;
            if (this.Resistencia > oponente.Resistencia)
                triunfos++;
            if (this.Superpoderes > oponente.Superpoderes)
                triunfos++;

            if (triunfos >= 2)
                return "TRIUNFO";
            else if (triunfos == 1)
                return "EMPATE";
            else
                return "DERROTA";
        }

    }
}
