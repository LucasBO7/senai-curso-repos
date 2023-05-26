namespace console_mvc_fixacao.Model
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string Data { get; set; }
        private const string Path = "Database/Event.csv";

        public Evento()
        {
            // Obtém o caminho do banco de dados
            string pasta = Path.Split("/")[0];

            // Criar pasta se não existir
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Verificar se o arquivo já existe
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }

        // Lê os valores do banco de dados e retorna em uma lista de Eventos
        public List<Evento> LerDadosBC()
        {
            List<Evento> eventos = new List<Evento>();

            // Pega todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(Path);

            // Guarda cada valor da linha em uma lista
            foreach (var linha in linhas)
            {
                // Pega os atributos de cada linha
                string[] atributos = linha.Split(";");

                // Cria um novo evento com os atributos da linha
                Evento evento = new Evento();
                evento.Nome = atributos[0];
                evento.Descricao = atributos[1];
                evento.Data = atributos[2];

                // Insere o objeto evento na lista de eventos
                eventos.Add(evento);
            }

            return eventos;
        }

        public string PrepararDadosParaLinha(Evento evento)
        {
            return $"{evento.Nome};{evento.Descricao};{evento.Data}";
        }

        public void Inserir(Evento evento)
        {
            // Recebe o dado inserido já convertido em linha
            string[] linhas = { PrepararDadosParaLinha(evento) };

            // PrepararDadosParaLinha(evento);
            File.AppendAllLines(Path, linhas);
        }

        public void Remover(Evento evento)
        {
            // Recebe os dados do banco de dados
            List<Evento> eventos = LerDadosBC();

            // Pesquisa um objeto
            int indexEventoPesquisado = eventos.FindIndex(e => e.Nome == evento.Nome && e.Data == evento.Data);

            // Remover evento pesquisado
            eventos.RemoveAt(indexEventoPesquisado);
        }

    }
}