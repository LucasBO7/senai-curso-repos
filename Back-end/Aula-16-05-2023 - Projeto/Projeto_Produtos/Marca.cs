namespace Projeto_Produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string? NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public List<Marca> ListaDeMarcas = new List<Marca>();

        public Marca() { }

        public Marca(int _codigo, string _nomeMarca)
        {
            Codigo = _codigo;
            NomeMarca = _nomeMarca;
            Cadastrar();
        }

        public void Cadastrar()
        {
            Marca _marca = new Marca();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"___________ CADASTRO MARCA ___________");
            Console.Write($"Código: ");
            _marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write($"Nome da marca: ");
            _marca.NomeMarca = Console.ReadLine()!;
            Console.WriteLine($"Cadastro realizado com sucesso!");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Pressione a tecla ENTER para prosseguir...");
            Console.ReadLine();
            Console.ResetColor();

            // Adiciona na lista de marcas
            ListaDeMarcas.Add(_marca);
        }

        public void Listar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            if (!ListaDeMarcas.Any())
            {
                Console.WriteLine($"A lista está vazia!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine(@$"
 _________________________
|                         |
|     LISTA DE MARCA      |
|_________________________|
");


                foreach (var item in ListaDeMarcas)
                {
                    Console.WriteLine(@$"
_____________________________________________________

Código: {item.Codigo}
Nome: {item.NomeMarca}
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

        public void Deletar(int codigoPesquisado)
        {
            // Se tiver algo salvo
            if (ListaDeMarcas.Any())
            {
                int indexMarcaPesquisada = ListaDeMarcas.FindIndex(marca => marca.Codigo == codigoPesquisado); // Pesquisa Index da Marca por código

                // Se achar o objeto
                if (indexMarcaPesquisada == -1)
                {
                    Console.WriteLine($"Nenhum produto do código inserido encontrado");
                }
                else
                {
                    // Remove o objeto
                    ListaDeMarcas.RemoveAt(indexMarcaPesquisada);
                    Console.WriteLine($"Marca deletada com sucesso!");
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

    }
}