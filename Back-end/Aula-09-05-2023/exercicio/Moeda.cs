using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio
{
    public class Moeda
    {
        public static float Real { get; set; } = 0.20f; // Valor do dolar em real
        public static float Dolar { get; set; } = 4.99f; // Valor do real em Dolar

        public static float ConverterRealParaDolar(float reais)
        {
            float dolares = reais * Real;
            return dolares;
        }

        public static float ConverterDolarParaReal(float dolares)
        {
            float reais = dolares * Dolar;
            return reais;
        }

        public static string RetornarCotacao()
        {
            return @$"Cotas:
Real = {Real.ToString("F2", new CultureInfo("pt-BR"))}
Dólar = {Dolar.ToString("F2", new CultureInfo("en-US"))}";
        }
    }
}