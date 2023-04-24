using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_04_2023
{
    public class Calculadora
    {
        public float Numero1 { get; set; }
        public float Numero2 { get; set; }

        public float Somar()
        {
            return Numero1 + Numero2;
        }

        public float Subtrair()
        {
            return Numero1 - Numero2;
        }

        public float Dividir()
        {
            return Numero1 / Numero2;
        }

        public float Multiplicar()
        {
            return Numero1 * Numero2;
        }
    }
}