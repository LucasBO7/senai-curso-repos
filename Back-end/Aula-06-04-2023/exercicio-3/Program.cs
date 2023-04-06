// Receber um número inteiro
// Mostrar tabuada

Console.Write($"Insira um número: ");
int numero = int.Parse(Console.ReadLine());

// Tabuada
for (int x = 0; x <= 10; x++)
{
    int resultadoTabuada = numero * x;
    Console.WriteLine($"{numero} * {x} = {resultadoTabuada}");
}