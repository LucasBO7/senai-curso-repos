using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_celular
{
    public class Celular
    {
        public string? Cor;
        public string? Modelo;
        public float Tamanho;
        public bool Ligado = false;

        public void Ligar()
        {
            this.Ligado = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Celular Ligado!");
            Console.ResetColor();
        }
        public void Desligar()
        {
            this.Ligado = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Celular Desligado!");
            Console.ResetColor();
        }

        public void FazerLigacao()
        {

        }
        public void EnviarMensagem()
        {

        }
    }
}