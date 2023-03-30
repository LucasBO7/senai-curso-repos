Console.Write("Informe a medida do lado 1 do triângulo: ");
float ladoA = float.Parse(Console.ReadLine());

Console.Write("Informe a medida do lado 2 do triângulo: ");
float ladoB = float.Parse(Console.ReadLine());

Console.Write("Informe a medida do lado 3 do triângulo: ");
float ladoC = float.Parse(Console.ReadLine());

Console.WriteLine(); // Pula linha


// Se o Lado 1 = lado 2 = lado 3 --> Equilátero
if (ladoA == ladoB && ladoA == ladoC)
{
    Console.WriteLine("Este é um triângulo Equilátero.");
}
// Se o lado 1 = lado 2 e diferente do lado 3 --> Isóscele
// OU lado 2 = lado 3 e diferente do lado 1 --> Isóscele
// OU lado 3 = lado 1 e diferente do lado 2 --> Isóscele
else if ((ladoA == ladoB) && (ladoA != ladoC) || (ladoB == ladoC) && (ladoB != ladoA) || (ladoC == ladoA) && (ladoC != ladoB))
{
    Console.WriteLine($"Este é um triângulo Isóscele.");
}
// Se todos tiverem medidas diferentes
else if ((ladoA != ladoB) && (ladoA  != ladoC))
{
    Console.WriteLine("Este é um triângulo Escaleno.");
}