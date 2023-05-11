// instância do objeto carrinho
using Projeto_Produto_iInterface;

Carrinho carrinho = new Carrinho();

// instanciar objeto(s) da classe produto
Produto produto1 = new Produto(1, "GTA 5", 52.9f);
Produto produto2 = new Produto(2, "Detroit: Become Human", 120.50f);
Produto produto3 = new Produto(3, "Forza Horizon", 100f);

carrinho.Adicionar(produto1);
carrinho.Adicionar(produto2);
carrinho.Adicionar(produto3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine(@$"
---------------------------------
Após a remoção de um item");

carrinho.Remover(produto2);
carrinho.Remover(produto3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine(@$"
---------------------------------
Agora vamos atualizar um objeto");

// criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa 2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);
carrinho.Listar();
carrinho.TotalCarrinho();