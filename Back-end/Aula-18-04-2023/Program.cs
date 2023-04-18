// GERENCIADOR DE PRODUTOS
// atributos: string Nome;  float Preco;    bool Promocao --> se está em promoção ou não
// DEVE conter: CadastrarProduto;    ListarProduto;     MostrarMenu;

// Declaração de variáveis
string[] names = new string[10];
float[] prices = new float[10];
bool[] promotions = new bool[10];


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
 ===============================
|                               |
|   GERENCIADOR DE PRODUTOS     |
|                               |
|===============================|

");
Console.ResetColor();


void RegisterProduct (string[] names, float[] prices, bool[] promotions)
{
    Console.WriteLine(@$"
    |
    |       INSERÇÃO DE PRODUTOS
    |____________________________________]
    ");
    
    
    Console.Write($"Nome do produto: ");
    string name = Console.ReadLine();
    
    Console.Write($"Preço (x,yy): R$");
    float price = float.Parse(Console.ReadLine());

    
    bool promotion = bool.Parse(Console.ReadLine());
}
