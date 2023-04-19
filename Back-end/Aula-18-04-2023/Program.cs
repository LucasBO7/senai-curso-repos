// GERENCIADOR DE PRODUTOS
// atributos: string Nome;  float Preco;    bool Promocao --> se está em promoção ou não
// DEVE conter: CadastrarProduto;    ListarProduto;     MostrarMenu;

// Declaração de variáveis
string[] names = new string[10];
float[] prices = new float[10];
bool[] hasPromotions = new bool[10];
float[] promotionsValues = new float[10];
float[] valuesWithPromotion = new float[10];

// Métodos
void ShowMenu(string[] names, float[] prices, bool[] hasPromotions, float[] promotionsValues, float[] valuesWithPromotion)
{
    char selectedOptionMenu = 'h';

    Console.WriteLine(@$"
__________________________
------> MENU <------
|
|-- 1) Adicionar produtos
|
|-- 2) Listar produtos
    
    
|-- 0) Fechar programa");
    // Realiza um loop enquanto o valor informado não for um dos esperados (1, 2 ou 0)
    do
    {
        selectedOptionMenu = char.Parse(Console.ReadLine());
    } while (selectedOptionMenu != '1' && selectedOptionMenu != '2' && selectedOptionMenu != '0');
    Console.WriteLine($"__________________________");



    switch (selectedOptionMenu)
    {
        case '1':
            RegisterProduct(names, prices, hasPromotions, promotionsValues, valuesWithPromotion);
            break;

        case '2':
            ShowProducts(names, prices, hasPromotions, promotionsValues, valuesWithPromotion);
            break;

        case '0':
            Environment.Exit(1);
            break;

        default:
            break;
    }
}
void ShowProducts(string[] names, float[] prices, bool[] hasPromotions, float[] promotionsValues, float[] valueWithPromotion)
{
    int countElementsWithValue = names.Where(element => (!String.IsNullOrEmpty(element))).Count(); // Pega a quantidade de elementos que possuem valor
    if (countElementsWithValue == 0)
    {
        Console.WriteLine($"A lista está vazia.");
        ShowMenu(names, prices, hasPromotions, promotionsValues, valuesWithPromotion);
    }
    Console.Clear();

    Console.WriteLine(@$"
_________________________________
                         
         LISTA DE PRODUTOS   
|_______________________________|
    ");


    for (int z = 0; z < countElementsWithValue; z++)
    {
        string havePromotion = hasPromotions[z] == true ? $"Promoção disponível no valor de R$ {promotionsValues[z].ToString("F2")}" : "Não há promoções para este produto";

        Console.Write(@$"
Nome: {names[z]}
Preço: R$ {prices[z].ToString("F2")}
{havePromotion}
Preço com promoção: {valueWithPromotion[z].ToString("F2")}
");
    }
    Console.ReadLine();
    ShowMenu(names, prices, hasPromotions, promotionsValues, valuesWithPromotion);
}
void RegisterProduct(string[] names, float[] prices, bool[] hasPromotions, float[] promotionsValues, float[] valuesWithPromotion)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
    
            INSERÇÃO DE PRODUTOS
    |__________________________________]
    ");
    Console.ResetColor();

    int actualPosition = 0; // Posição de cada item do array (ou de inserção)
    int productsQuantityLimit = 3; // Quantidade limite de produtos a serem inseridos
    bool addMoreProducts = false; // Recebe se o sistema deve continuar adicionando mais produtos ou não
    do
    {
        int countElementsWithValue = names.Where(element => (!String.IsNullOrEmpty(element))).Count(); // Pega a quantidade de elementos que possuem valor

        Console.Write($"Nome do produto: ");
        string name = Console.ReadLine();

        Console.Write($"Preço (x,yy): R$ ");
        float price = float.Parse(Console.ReadLine());

        Console.Write($"Possui promoção?(sim/não): ");
        string hasPromotionsInput = Console.ReadLine().ToLower();
        bool hasPromotion = hasPromotionsInput == "sim" || hasPromotionsInput == "s" ? true : false;

        // Se o produto possuir promoções
        float promotionValue = 0;
        if (hasPromotionsInput == "sim" || hasPromotionsInput == "s")
        {
            Console.Write($"Insira o valor da promoção: ");
            promotionValue = float.Parse(Console.ReadLine());
            CalculatePromotion(price, hasPromotion, promotionValue, valuesWithPromotion, countElementsWithValue);
        }
        Console.WriteLine(); // Pula linha
        Console.WriteLine(); // Pula linha  


        // Atribuição de valores à Parâmetros/Arrays
        names[countElementsWithValue] = name;
        prices[countElementsWithValue] = price;
        hasPromotions[countElementsWithValue] = hasPromotion;
        promotionsValues[countElementsWithValue] = promotionValue;

        actualPosition++;

        // Impressão e recepção para inserção de mais produtos ou não
        if (countElementsWithValue == productsQuantityLimit - 1)
        {
            string quantityProducts = "Não é possível a inserção de mais produtos. LIMITE DE 10 PRODUTOS ATINGIDO.";
        }
        else
        {
            Console.WriteLine($"____{countElementsWithValue} para um limite de {productsQuantityLimit}____");

            string quantityProducts = $"Deseja inserir mais produtos? ({actualPosition}/{productsQuantityLimit}): ";
            Console.Write(quantityProducts);
            string addMoreProductsInput = Console.ReadLine().ToLower();
            addMoreProducts = addMoreProductsInput == "sim" || addMoreProductsInput == "s" ? true : false; // Se responder sim... true, senão... false
        }
    } while (actualPosition < productsQuantityLimit && addMoreProducts == true);
    Console.Clear();
    ShowMenu(names, prices, hasPromotions, promotionsValues, valuesWithPromotion);
}
void CalculatePromotion(float price, bool hasPromotions, float promotionValue, float[] valueWithPromotion, int elementPosition)
{
    // Se tiver promoções
    if (hasPromotions == true)
    {
        if (promotionValue > price)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERRO! o valor da promoção não deve ser maior que seu preço.");
            Console.ResetColor();
        }
        else
        {
            valueWithPromotion[elementPosition] = price - promotionValue;
        }
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

ShowMenu(names, prices, hasPromotions, promotionsValues, valuesWithPromotion);

