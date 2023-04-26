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
            Console.Clear();
            this.Ligado = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Celular Ligado!");
            Console.ResetColor();
        }
        public void Desligar()
        {
            Console.Clear();
            this.Ligado = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Celular Desligado!");
            Console.ResetColor();
        }

        public void FazerLigacao()
        {
            Console.Clear();
            Console.WriteLine($"Ligação Realizada!");
        }
        public void EnviarMensagem()
        {
            Console.Clear();
            Console.Write($"Para quem deseja enviar a mensagem?: ");
            string destinatario = Console.ReadLine();
            
            Console.Write($"Insira a mensagem a ser enviada: ");
            string mensagem = Console.ReadLine();
            
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Mensagem enviada para {destinatario}");
            Console.ResetColor();
        }
    }
}