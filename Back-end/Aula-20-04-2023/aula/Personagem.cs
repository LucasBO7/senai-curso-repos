using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Armadura { get; set; }
        public string Ia { get; set; }

        public void Add(string nome, int idade, string armadura, string ia, List<Personagem> personagens)
        {
            personagens.Add(new Personagem
            {
                Nome = nome,
                Idade = idade,
                Armadura = armadura,
                Ia = ia
            });
        }

        public void Atacar()
        {
            Console.WriteLine($"O persongem atacou !!!");
        }
        public void Defender()
        {
            Console.WriteLine($"O persongem defendeu !!!");
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"Armadura restaurada !!!");
        }

    }
}