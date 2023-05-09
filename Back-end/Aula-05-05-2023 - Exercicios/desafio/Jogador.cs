using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public abstract class Jogador
    {
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Nationality { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        // Imprime todos os jogadores de uma lista
        public void PrintPlayers(List<Jogador> jogadores)
        {
            foreach (var jogador in jogadores)
            {
                Console.WriteLine(jogador);
            }
        }

        // Calcula a idade do jogador por meio de sua data de nascimento
        public int CalculateAge()
        {
            DateTime actualDateTime = DateTime.Today;
            var year = actualDateTime.Year - this.Birthdate.Year;

            return year;
        }

        // Tempo restante para apostentar
        public abstract float TimeLeftRetire();
    }
}