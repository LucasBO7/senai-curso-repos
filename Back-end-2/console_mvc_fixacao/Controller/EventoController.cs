using console_mvc_fixacao.Model;
using console_mvc_fixacao.View;

namespace console_mvc_fixacao.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> eventos = evento.LerDadosBC(); // Pega os dados do banco de dados

            eventoView.Listar(eventos);
        }

        public void CriarEvento()
        {
            Evento novoEvento = eventoView.Cadastrar();
            evento.Inserir(novoEvento);

            ListarEventos();
        }

        public void RemoverEvento()
        {
            Evento eventoASerRemovido = eventoView.Cadastrar();
            evento.Remover(eventoASerRemovido);

            ListarEventos();
        }
    }
}