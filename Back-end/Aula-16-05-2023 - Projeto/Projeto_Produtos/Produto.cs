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
            Produto novoProduto = new Produto();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"___________ CADASTRO PRODUTO ___________");
            Console.Write($"Código: ");

            // Impede a inserção de um produto com um código já existente
            do
            {
                novoProduto.Codigo = int.Parse(Console.ReadLine()!);

                if (ListaDeProdutos.Any(produto => produto.Codigo == novoProduto.Codigo))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"CÓDIGO JÁ EXISTENTE, insira um código diferente para este produto.");
                }
            } while (ListaDeProdutos.Any(produto => produto.Codigo == novoProduto.Codigo));



            Console.Write($"Nome do produto: ");
            novoProduto.Nome = Console.ReadLine()!;

            Console.Write($"Preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.ResetColor();

            Console.Write($"Código da marca: ");
            novoProduto.Marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write($"Nome da marca: ");
            novoProduto.Marca.NomeMarca = Console.ReadLine()!;

//             OK	RECEBER Código e Nome da marca
// 	SE Código existir... Salvar na Produto.Marca a Marca
// 	SE Código não existir... Cadastrar()
// SE Código for novo e Nome for Novo

            int indexPesquisado = Marca.ListaDeMarcas.FindIndex(marca => marca.Codigo == novoProduto.Marca.Codigo && marca.NomeMarca == novoProduto.Marca.NomeMarca);

            if (indexPesquisado == -1)
            {
                Console.WriteLine($"Criar nova Marca, não encontrada na lista");
            }
            else
            {
                Console.WriteLine($"Marca já existente, pegar a marca");
            }

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Pressione a tecla ENTER para prosseguir...");
            Console.ReadLine();
            Console.ResetColor();

            ListaDeProdutos.Add(novoProduto);

        }

        public void Deletar(int codigoPesquisado)
        {
            // Se tiver algo salvo
            if (ListaDeProdutos.Any())
            {
                int indexProdutoPesquisada = ListaDeProdutos.FindIndex(produto => produto.Codigo == codigoPesquisado);

                // Se achar o objeto
                if (indexProdutoPesquisada == -1)
                {
                    Console.WriteLine($"Nenhum produto do código inserido encontrado");
                }
                else
                {
                    // Remove o objeto
                    ListaDeProdutos.RemoveAt(indexProdutoPesquisada);
                    Console.WriteLine($"Produto deletado com sucesso!");
                    Thread.Sleep(1000);
                }
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
            if (!ListaDeProdutos.Any())
            {
                Console.WriteLine($"A lista está vazia!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine(@$"
 _________________________
|                         |
|    LISTA DE PRODUTOS    |
|_________________________|
");


                foreach (var item in ListaDeProdutos)
                {
                    Console.WriteLine(@$"
_____________________________________________________

Código: {item.Codigo}
Nome: {item.Nome}
Preço: {item.Preco:C2}
Data do Cadastro: {item.DataCadastro.ToShortDateString()} - {item.DataCadastro.ToLongTimeString()}
_____________________________________________________
                ");
                }
            }
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Pressione a tecla ENTER para prosseguir...");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

    }
}