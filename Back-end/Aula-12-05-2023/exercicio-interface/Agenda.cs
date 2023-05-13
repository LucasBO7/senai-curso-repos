using exercicio_interface.Interfaces;

namespace exercicio_interface
{
    public class Agenda : IAgenda
    {
        public List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            contatos.Add(_contato);

            // throw new NotImplementedException();
        }

        public void Listar()
        {
            if (contatos.Any())
            {
                foreach (var item in contatos)
                {
                    Console.WriteLine(@$"
                {item.Nome}
                {item.Email}
                {item.Telefone}
                _____________________________________
                ");

                }
            }
            else
            {
                Console.WriteLine($"Não há nenhum contato salvo.");
            }
            // throw new NotImplementedException();
        }
    }
}