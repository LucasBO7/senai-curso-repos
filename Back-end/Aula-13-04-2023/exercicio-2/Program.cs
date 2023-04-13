// LER número de litros vendidos, tipo do combustível (A - álcool, G - gasolina)
// CALCULAR valor a ser pago (litro Gasolina = 5,30; litro Álcool = 4,90)
// ATENÇÃO A até 20 litros, 3% de desconto p/litro  /   A mais que 20 litros, 5% de desconto p/litro.   O mesmo para o G, mas um com 4% de desconto e outro com 6% de desconto

float liter_gasoline_price = 5.3f;
float liter_alcohol_price = 4.9f;



Console.Write($"Insira o total de Litros vendidos: ");
float litersSold = float.Parse(Console.ReadLine());

Console.Write($"Insira o tipo do combustível usado (A - álcool, G - gasolina): ");
char fuelType = char.Parse(Console.ReadLine().ToUpper());

float totalPrice = TotalPrice(litersSold, fuelType, liter_gasoline_price, liter_alcohol_price);
string fuelTypeName = fuelType == 'A' ? "álcool" : "gasolina";

Console.WriteLine(); // Pula linha

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
Preço total: R$ {totalPrice.ToString("F2")}
Litros do combustível: {litersSold}
Tipo do combustível: {fuelTypeName}
");
Console.ResetColor();


static float TotalPrice(float liters, char fuelType, float gasolineLiterPrice, float alcoholLiterPrice)
{
    float totalPrice = 0;
    float discount = 0; // Var que guarda o valor do desconto

    // Se for álcool
    switch (fuelType)
    {
        case 'A': // R$ 4,90
            totalPrice = (liters * alcoholLiterPrice); // Calcula o valor total

            if (liters <= 20)
            {
                discount = totalPrice * 0.03f; // Pega 3% do valor total
            }
            else
            {
                discount = totalPrice * 0.05f; // Pega 5% do valor total
            }
            totalPrice = totalPrice - discount; // Subtrai o desconto do valor total
            break;

        case 'G': // R$ 5,30
            totalPrice = (liters * gasolineLiterPrice); // Calcula o valor total

            if (liters <= 20)
            {
                discount = totalPrice * 0.04f; // Pega 4% do valor total
            }
            else
            {
                discount = totalPrice * 0.06f; // Pega 6% do valor total
            }
            totalPrice = totalPrice - discount; // Subtrai o desconto do valor total
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira os valores corretos do tipo de gasolina!!");
            Console.ResetColor();
            return 0;
            break;
    }

    return totalPrice;
}