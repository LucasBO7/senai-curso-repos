// LER 10 números
// IMPRIMIR o maior e o menor

float[] numbers = new float[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Insira 10 números ({i + 1}/10): ");
    float number = float.Parse(Console.ReadLine());
    numbers[i] = number;
}

numbers.Order(); // Ordena os números em ordem crescente

Console.WriteLine(@$"
____________________________
O maior número é: {numbers.Last()}
O menor número é: {numbers.First()}
");