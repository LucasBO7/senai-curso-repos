// IMPRIMIR tabuada dos números 1 a 10, sendo cada tabuada de 10 números

for (int i = 1; i <= 10; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"--- Tabuada do {i} ---");
    Console.ResetColor();
    
    for (int x = 1; x <= 10; x++)
    {
        float result = i * x;
        Console.WriteLine($"{i} * {x} = {result}");
    }
    Console.WriteLine(); // Pula linha
}