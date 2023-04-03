Console.Write("Insira a quantidade de maçãs compradas: ");
int quantiaComprada = int.Parse(Console.ReadLine());

// R$ 0,30
float precoMacaMenosQueDuzia = 0.3f;

// R$ 0,25
float precoMaiorQueDuzia = 0.25f;

float valorTotal;

if (quantiaComprada < 12)
{
    valorTotal = precoMacaMenosQueDuzia * quantiaComprada;
    Console.WriteLine($"Valor total da compra: R$ {valorTotal.ToString("N2")}");
}
else
{
    valorTotal = precoMaiorQueDuzia * quantiaComprada;
    Console.WriteLine($"Valor total da compra: R$ {valorTotal.ToString("N2")}");
}