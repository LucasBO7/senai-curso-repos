// Receber: idade, peso, sexo --> 10 pessoas
// Calcular e Imprimir: total de homens, total de mulheres, média de idade dos homens (soma de tudo / pela quantidade), média de idade das mulheres

// Número total de cada sexo
int totalHomens = 0;
int totalMulheres = 0;
// Soma da idade de todos de cada sexo
int idadeTotalHomens = 0;
int idadeTotalMulheres = 0;


for (int x = 0; x < 10; x++)
{
    Console.Write($"Insira sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write($"Insira seu peso: ");
    float peso = float.Parse(Console.ReadLine());

    Console.Write($"Insira seu sexo (m -> masculino / m -> feminino): ");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    Console.WriteLine(); // Pula a linha
    

    if (sexo == 'm')
    {
        idadeTotalHomens += idade;
        totalHomens += 1;
    }
    else if (sexo == 'f')
    {
        idadeTotalMulheres += idade;
        totalMulheres += 1;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
Total de homens: {totalHomens}.
Total de mulheres: {totalMulheres}.
Média aproximado de idade dos homens: {idadeTotalHomens / totalHomens}.
Média aproximada de idade das mulheres: {idadeTotalMulheres / totalMulheres}.
");
Console.ResetColor();