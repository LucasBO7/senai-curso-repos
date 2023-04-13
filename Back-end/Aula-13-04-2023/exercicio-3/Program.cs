// algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%

Console.Write($"Insira o nome do produto: ");
string productName = Console.ReadLine();

Console.Write($"Insira a quantidade: ");
int quantityBought = int.Parse(Console.ReadLine());

Console.Write($"Insira o preço unitário do produto: ");
float unitPrice = float.Parse(Console.ReadLine());

float discount = 0;
float totalPrice = quantityBought * unitPrice;
float  discountedTotalPrice = CalculateTotalValue(quantityBought, totalPrice, discount);

Console.WriteLine(@$"
Valor total sem desconto: {totalPrice.ToString("F2")}
Desconto: {discount.ToString("F2")}
Valor total com desconto: {discountedTotalPrice.ToString("F2")}
");



static float CalculateTotalValue(float quantityBought, float totalPrice, float discount)
{
    if (quantityBought <= 5)
    {
        discount = totalPrice * 0.02f;
    }
    else if (quantityBought <= 10)
    {
        discount = totalPrice * 0.03f;
    }
    else
    {
        discount = totalPrice * 0.05f;
    }
    float discountedTotalPrice = totalPrice - discount;
    return discountedTotalPrice;
}
