using console_mvc.Controller;
using console_mvc.Model;
using console_mvc.View;

Produto program = new Produto();
ProdutoController controller = new ProdutoController();
controller.ListarProdutos();
controller.CadastrarProduto();