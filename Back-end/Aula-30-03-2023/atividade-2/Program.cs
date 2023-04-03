// Inputs time A (nome e numero de gols)
Console.Write("Informe o nome do primeiro time: ");
string nomeTimeA = Console.ReadLine();

Console.Write("Informe a quantia de gols do primeiro time: ");
int golsTimeA = int.Parse(Console.ReadLine());

Console.WriteLine(); // Pula linha

// Inputs time B (nome e numero de gols)
Console.Write("Informe o nome do segundo time: ");
string nomeTimeB = Console.ReadLine();

Console.Write("Informe a quantia de gols do segundo time: ");
int golsTimeB = int.Parse(Console.ReadLine());


if (golsTimeA > golsTimeB)
{
    Console.WriteLine($"O time {nomeTimeA} venceu");
}
else if (golsTimeA == golsTimeB)
{
    Console.WriteLine($"Os times empataram");
}
else
{
    Console.WriteLine($"O time {nomeTimeB} venceu");
}