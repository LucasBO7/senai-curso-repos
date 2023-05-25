using console_mvc.Model;

namespace console_mvc.View
{
    public class ProdutoView
    {
        // Método para exibir os dados da lista no console
        public void Listar(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}
Nome: {item.Nome}
Preço: {item.Preco:F2}");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine()!;

            Console.WriteLine($"Informe o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }
    }
}