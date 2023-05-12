using exercicio_interface.Interfaces;

namespace exercicio_interface
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }
    }
}