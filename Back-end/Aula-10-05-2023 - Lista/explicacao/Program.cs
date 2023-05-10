// Crie uma classe Produto
// Com as propriedades: int codigo, string nome, floar preco
// Crie um construtor vazio
// Crie um construtor completo

using exercicio;


List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto(2563, "camiseta QuickSilver", 19.90f));
produtos.Add(new Produto(1025, "tênis Naiki", 50f));

Produto calcaDiesel = new Produto(1526, "calça Diesel Calvo Klein", 15f);
produtos.Add(calcaDiesel);

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
}
Console.ReadLine();
Console.Clear();

var produtoBuscado = produtos.Find(x => x.Codigo == 2563);

int index = produtos.IndexOf(produtoBuscado);
produtoBuscado.Preco = 199.90f;
produtos.RemoveAt(index);
produtos.Insert(index, produtoBuscado);

Console.WriteLine($"Lista atualizada");
Console.WriteLine($"****************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
}