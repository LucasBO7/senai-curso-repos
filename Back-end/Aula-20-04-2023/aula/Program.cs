using aula;

// Instanciar um objeto da classe Personagem
List<Personagem> personagens = new List<Personagem>();

string? continueAdding = "não";
do
{
    Console.Write($"Informe o nome do personagem: ");
    string nome = Console.ReadLine()!;

    Console.Write($"Informe a idade do personagem: ");
    int idade = int.Parse(Console.ReadLine()!);

    Console.Write($"Informe a armadura do personagem: ");
    string armadura = Console.ReadLine()!;

    Console.Write($"Informe a IA do personagem: ");
    string ia = Console.ReadLine()!;

    personagens.Add(new Personagem
    {
        Nome = nome,
        Idade = idade,
        Armadura = armadura,
        Ia = ia
    });

    Console.WriteLine();
    Console.Write($"Deseja continuar? ");
    continueAdding = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine();
} while (continueAdding == "s" || continueAdding == "sim");

Console.WriteLine($"\tLISTA DE PERSONAGENS");
foreach (var personagem in personagens)
{
    Console.WriteLine(@$"
Nome: {personagem.Nome}
Idade: {personagem.Idade}
Armadura: {personagem.Armadura}
IA: {personagem.Ia}
");

}

