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

            Console.WriteLine(@$"
            ---/ Formulário Evento /---
            ");


            Console.Write($"Nome do evento: ");
            evento.Nome = Console.ReadLine()!;

            Console.Write($"Descrição: ");
            evento.Descricao = Console.ReadLine()!;

            Console.Write($"Data: ");
            evento.Data = Console.ReadLine()!;

            return evento;
        }

        public Evento Excluir()
        {
            Evento eventoPesquisa = new Evento();

            Console.WriteLine(@$"
            ---/ Excluir Evento /---
            ");

            Console.Write($"Nome do evento: ");
            eventoPesquisa.Nome = Console.ReadLine()!;

            Console.Write($"Data: ");
            eventoPesquisa.Data = Console.ReadLine()!;

            Console.WriteLine($"Deseja realmente excluir este evento? (s/n): ");
            string resp = Console.ReadLine()!;

            if (resp == "n")
            {
                Environment.Exit(1);
            }

            return eventoPesquisa;
        }
    }
}