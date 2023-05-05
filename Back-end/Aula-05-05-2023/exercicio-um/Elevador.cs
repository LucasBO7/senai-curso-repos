using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_um
{
    public class Elevador
    {
        public int AndarAtual { get; set; }
        public int TotalAndares { get; set; }
        public int Capacidade { get; set; }
        public int QntdPessoasDentro { get; set; }
        public int AndarEscolhido { get; set; }
        public int AndarInicial { get; private set; } = 0; // Seu valor sempre será 0 --> o programa sempre começará do 0
        // public int QuantidadePessoasEntraram { get; set; }
        // public int QuantidadePessoasSairam { get; set; }

        public void Inicializar(int capacidade, int total_andares, int quantidade_pessoas_dentro)
        {
            Capacidade = capacidade;
            TotalAndares = total_andares;
            QntdPessoasDentro = quantidade_pessoas_dentro;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"
            ====================================================================================
            | O prédio possui {total_andares} andares e capacidade de até {capacidade} pessoas |
            ====================================================================================");
            Console.ResetColor();
        }

        // Mostra as informações
        public void MostrarInformacoes()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@$"
________________________________
           INFORMAÇÕES

Andar atual: {this.AndarAtual}
Número total de andares: {this.TotalAndares} 

Quantidade de pessoas dentro: {this.QntdPessoasDentro} 
Capacidade: {this.Capacidade} 
________________________________");
            Console.ResetColor();
        }

        // Acrescenta uma pessoa do elevador
        public void Entrar()
        {
            // Se tiver menos pessoas que a capacidade do elevador, entrar
            if (this.QntdPessoasDentro < this.Capacidade)
            {
                this.QntdPessoasDentro += 1;
                Console.ForegroundColor = ConsoleColor.Red;

                // Animação de descida do elevador
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($".");
                    // Console.Beep(800, 500);
                }
                Console.WriteLine($"___Uma pessoa entrou no elevador___");
                // Console.Beep(800, 1000);
                Thread.Sleep(500);
                Console.Clear();

                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Limite de pessoas antigido!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        // Tira uma pessoa do elevador
        public void Sair()
        {
            // Se tiver alguém no elevador, sair
            if (this.QntdPessoasDentro > 0)
            {
                this.QntdPessoasDentro -= 1;
                Console.ForegroundColor = ConsoleColor.Red;

                // Animação de descida do elevador
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($".");
                    // Console.Beep(800, 500);
                }
                Console.WriteLine($"___Uma pessoa saiu do elevador___");
                // Console.Beep(800, 1000);
                Thread.Sleep(500);
                Console.Clear();

                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não há ninguém no elevador, fantasminha??");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        // Sobe um andar
        public void Subir()
        {
            // Se não estiver no último andar e escolher um andar menor que o máximo
            if (this.AndarAtual < this.TotalAndares)
            {
                this.AndarAtual += 1;
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($".");
                    // Console.Beep(800, 500);
                }
                Console.WriteLine($" ___O elevador subiu um andar___");
                // Console.Beep(800, 1000);
                Thread.Sleep(500);
                Console.Clear();
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você já está no último andar ({this.AndarAtual})");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        // Desce um andar
        public void Descer()
        {
            if (this.AndarAtual != 0)
            {
                this.AndarAtual -= 1;
                Console.ForegroundColor = ConsoleColor.Red;

                // Animação de descida do elevador
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($".");
                    // Console.Beep(800, 500);
                }
                Console.WriteLine($"___O elevador desceu um andar___");
                // Console.Beep(800, 1000);
                Thread.Sleep(500);
                Console.Clear();

                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você já está no térreo");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}