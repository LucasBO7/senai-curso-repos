//              ALGORÍTMO
// RECEBER renda
// CALCULAR IMPOSTO: (até 1500 - nada / 1501 a 3500 - 20% / mais de 6000 - 35%)
// IMPRIMIR valor do imposto referente à renda


Console.Write($"Insira a renda a ser calculada: ");
float renda = float.Parse(Console.ReadLine());
Console.WriteLine(); // Pula a linha

float imposto = CalcularImposto(renda);

Console.Write($"O imposto será de R$ ");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(imposto.ToString("N2"));
Console.ResetColor();

Console.Write(" sobre a renda de R$ ");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(renda.ToString("F2"));
Console.ResetColor();



static float CalcularImposto(float rendimentoBruto)
{
    float imposto = 0;

    if (rendimentoBruto <= 1500)
    {
        imposto = 0;
    }
    else
    {
        if (rendimentoBruto > 1500 && rendimentoBruto <= 3500 && rendimentoBruto <= 6000)
        {
            imposto = 0.2f * rendimentoBruto; // Recebe 20% da renda
        }
        else
        {
            if (rendimentoBruto > 6000)
            {
                imposto = 0.35f * rendimentoBruto; // Recebe 35% da renda
            }
        }
    }
    return imposto;
}