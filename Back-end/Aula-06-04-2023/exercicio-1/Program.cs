int nota = 0;
do
{
    Console.Write($"Insira uma nota entre 0 e 10: ");
    nota = int.Parse(Console.ReadLine());
    if (nota < 0 || nota > 10)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(); // Pula linha        
        Console.WriteLine($"Valor inserido inválido.");
        Console.ResetColor();

        Console.WriteLine(); // Pula linha
    }
}
while (nota < 0 || nota > 10);