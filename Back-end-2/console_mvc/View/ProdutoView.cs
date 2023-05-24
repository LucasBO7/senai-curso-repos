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
    }
}