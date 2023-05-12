using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_interface.Interfaces
{
    public interface IAgenda
    {
        void Adicionar(Contato _contato);
        void Listar();
    }
}