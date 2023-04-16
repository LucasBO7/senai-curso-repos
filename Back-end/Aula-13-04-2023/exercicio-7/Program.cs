// LER 15 números
// ARMAZENAR números no vetor
// IMPRIMIR 15 números na ordem inversa das inserções

float[] numbers = new float[15];

for (int x = 0; x < 15; x++)
{
    Console.Write($"Insira um número ({x + 1}/15): ");
    float number = float.Parse(Console.ReadLine());
    numbers[x] = number;
}

Console.WriteLine(); // Pula linha
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Números na ordem inversa: ");

// Começar do último número e ir até o primeiro número (0)
for (int i = numbers.Count() - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}
Console.ResetColor();