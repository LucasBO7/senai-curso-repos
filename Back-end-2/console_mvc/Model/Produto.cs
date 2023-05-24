namespace console_mvc.Model
{
    public class Produto
    {
        // Propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // Caminho da pasta e do arquivo csv
        private const string Path = "Database/Produto.csv";

        public Produto()
        {
            // Criar a lógica para gerar a pasta e o arquivo

            // obter o caminho da pasta
            string pasta = Path.Split("/")[0];

            // verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // verificar se no caminho já existe um arquivo
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(Path);

            foreach (var linha in linhas)
            {
                string[] atributos = linha.Split(";");

                Produto p = new Produto();
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);
            }
            // Retorna a lista de produtos
            return produtos;
        }

        // método para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        // método para inserir um produto na linha do csv
        public void Inserir(Produto p)
        {
            string[] linhas = { PrepararLinhasCSV(p) };

            File.AppendAllLines(Path, linhas);
        }
    }
}