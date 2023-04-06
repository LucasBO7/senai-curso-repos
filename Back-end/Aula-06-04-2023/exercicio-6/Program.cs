// Tabuada de 1 a 10 dos números de 1 a 10

for (var num1 = 1; num1 <= 10; num1++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@$"
        ___________________________________
            Tábuada do {num1} de 1 a 10    
            
        ");
    Console.ResetColor();

    for (var num2 = 1; num2 <= 10; num2++)
    {
        int result = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {result}");
    }
}