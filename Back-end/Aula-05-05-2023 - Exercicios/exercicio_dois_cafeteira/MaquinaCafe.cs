using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_dois_elevador
{
public class MaquinaCafe
    {
        public float AcucarDisponivel { get; set; } = 800;
        public string? TipoCafe { get; set; }
        public int VolumeCopo { get; set; }

        public void FazerCafe(float acucar)
        {
            // Enquanto pedir mais açúcar que o disponível e açúcar for menor que 0
            do
            {
                Console.WriteLine(
                    @$"Quantidade de açúcar indisponível no momento.
                Quantidade de açúcar disponível: {this.AcucarDisponivel}"
                );

                Console.Write($"Quantidade de açúcar desejada (em gramas): ");
                acucar = float.Parse(Console.ReadLine()!);
            } while (this.AcucarDisponivel < acucar && acucar < 0);

            if (acucar > 0)
            {
                this.AcucarDisponivel -= acucar;
            }
            else
            {
                Console.Write("Preparando o café com o mínimo");
            }

            // Impressão animação
Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.Write(@$"Preparando o café");

int ultimoValor = 300;
for (int i = 0; i < 4; i++) {
    int valorLoop = i < 2 ? i : 2; // Recebe i enquanto for menor que 2, se maior que 2, recebe 2
    int equacao =  + (ultimoValor + (valorLoop * 100));
    ultimoValor = equacao;

    Console.Write($".");
    Console.Beep(equacao, 500);
}
Console.WriteLine();
Console.ResetColor();


        }

        public void FazerCafe()
        {
            Console.WriteLine($"Preparando café");
        }
    }
}