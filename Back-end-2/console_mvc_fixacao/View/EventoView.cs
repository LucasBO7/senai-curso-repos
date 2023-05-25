using console_mvc_fixacao.Model;

namespace console_mvc_fixacao.View
{
    public class EventoView
    {
        public void Listar(List<Evento> eventos)
        {
            foreach (var evento in eventos)
            {
                Console.WriteLine(@$"
Nome: {evento.Nome}
Descrição: {evento.Descricao}
Data: {evento.Data}");
            }

        }

        public Evento Cadastrar()
        {
            Evento evento = new Evento();

            Console.WriteLine($"Nome do evento: ");
            evento.Nome = Console.ReadLine()!;

            Console.WriteLine($"Nome do evento: ");
            evento.Descricao = Console.ReadLine()!;

            Console.WriteLine($"Nome do evento: ");
            evento.Data = Console.ReadLine()!;

            return evento;
        }
    }
}