namespace Projeto_Produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public Marca? Marca { get; set; }
        public Usuario? AutoriaCadastro { get; set; }
        List<Produto> ListaDeProdutos = new List<Produto>();


        public void Cadastrar()
        {
            Produto produto = new Produto();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"___________ CADASTRO PRODUTO ___________");
            Console.Write($"Código: ");
            produto.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write($"Nome do produto: ");
            produto.Nome = Console.ReadLine()!;

            Console.Write($"Preço: ");
            produto.Preco = float.Parse(Console.ReadLine()!);
            Console.ResetColor();

            ListaDeProdutos.Add(produto);
        }

        public void Deletar(int codigoPesquisado)
        {
            // Se tiver algo salvo
            if (ListaDeProdutos.Any())
            {
                var produtoPesquisado = ListaDeProdutos.Find(produto => produto.Codigo == codigoPesquisado);
                ListaDeProdutos.Remove(produtoPesquisado);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não há nenhum produto salvo.");
                Console.ResetColor();
            }
        }

        public void Listar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"
__________________________
    LISTA DE PRODUTOS
");


            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine(@$"
__________________________________________
Código: {item.Codigo}
Nome: {item.Nome}
Preço: {item.Preco:C2}
Data do Cadastro: {item.DataCadastro.ToLongDateString()} - {item.DataCadastro.ToLongTimeString()}
__________________________________________
                ");
                Console.ResetColor();
            }
        }

    }
}