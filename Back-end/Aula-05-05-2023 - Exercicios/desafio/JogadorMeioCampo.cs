using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio
{
    public class JogadorMeioCampo : Jogador
    {
        public override float TimeLeftRetire()
        {
            DateTime actualDateTime = DateTime.Today;
            var year = actualDateTime.Year - this.Birthdate.Year;

            return 38 - year; // Retorna o tempo restante
        }

    }
}