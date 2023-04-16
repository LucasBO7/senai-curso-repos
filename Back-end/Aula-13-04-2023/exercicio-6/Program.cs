// LER nomes (10 pessoas)
// ARMAZENAR em um vetor
// LER um nome para realizar a busca
// IMPRIMIR "Achei" caso estiver no vetor e "Não achei" caso não esteja no vetor

string[] names = new string[10];

for (int x = 0; x < 3; x++)
{
    Console.Write($"Insira um nome ({x + 1}/10): ");
    string name = Console.ReadLine().ToLower();
    names[x] = name;
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(@$"
|=================|
|Pesquisa de nomes|
|=================|

Insira o nome que deseja pesquisar: 
");
Console.ResetColor();
string searchedName = Console.ReadLine().ToLower();
Console.WriteLine(); // Pula linha


bool nameWasFound = false;
foreach (string item in names)
{
    // Se o nome for encontrado no vetor
    if (searchedName == item)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Achei!!!");
        Console.ResetColor();
        
        nameWasFound = true;
    }
}

// Se nome não for encontrado no vetor
if (nameWasFound == false)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Não achei!!!");
    Console.ResetColor();
}