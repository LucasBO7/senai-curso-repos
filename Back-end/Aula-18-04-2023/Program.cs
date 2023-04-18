// GERENCIADOR DE PRODUTOS
// atributos: string Nome;  float Preco;    bool Promocao --> se está em promoção ou não
// DEVE conter: CadastrarProduto;    ListarProduto;     MostrarMenu;

// Declaração de variáveis
string[] names = new string[10];
float[] prices = new float[10];
bool[] promotions = new bool[10];

// Métodos
void ShowMenu(string[] names, float[] prices, bool[] promotions)
{
    char selectedOptionMenu = 'h';

    Console.WriteLine(@$"
------> MENU <------
|
|-- 1) Adicionar produtos
|
|-- 2) Listar produtos
    
    
|-- 0) Fechar programa

");

    while (selectedOptionMenu != '1' || selectedOptionMenu != '2' || selectedOptionMenu != '0')
    {
        selectedOptionMenu = char.Parse(Console.ReadLine());
    }


    switch (selectedOptionMenu)
    {
        case '1':
            RegisterProduct(names, prices, promotions);
            break;

        case '2':
            ShowProducts(names, prices, promotions);
            break;

        case '0':

            break;

        default:
            break;
    }


}
void ShowProducts(string[] names, float[] prices, bool[] promotions)
{
    for (int z = 0; z < names.Length; z++)
    {
        string havePromotion = promotions[z] == true ? "Promoção disponível" : "Não há promoções ativas no momento";

        Console.Write(@$"
        Nome: {names[z]}
        Preço: R$ {prices[z].ToString("F2")}
        {havePromotion}
        ");
    }
}
void RegisterProduct(string[] names, float[] prices, bool[] promotions)
{
    Console.WriteLine(@$"
    |
    |       INSERÇÃO DE PRODUTOS
    |____________________________________]
    ");

    for (int x = 0; x < names.Length; x++)
    {
        Console.Write($"Nome do produto: ");
        string name = Console.ReadLine();

        Console.Write($"Preço (x,yy): R$");
        float price = float.Parse(Console.ReadLine());

        Console.Write($"Possui promoção?(sim/não): ");
        bool promotion = bool.Parse(Console.ReadLine());

        // Atribuição de valores à Parâmetros/Arrays
        names[x] = name;
        prices[x] = price;
        promotions[x] = promotion;
    }
}


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
=================================
|                               |
|   GERENCIADOR DE PRODUTOS     |
|                               |
=================================

");
Console.ResetColor();

ShowMenu(names, prices, promotions);

