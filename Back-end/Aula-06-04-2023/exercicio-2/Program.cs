string nome;
string senha;
do
{
    Console.Write($"Insira seu nome: ");
    nome = Console.ReadLine().ToLower();

    Console.Write($"Insira sua senha: ");
    senha = Console.ReadLine().ToLower();

    if (senha == nome)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"A sua senha não deve ser igual ao seu nome!");
        Console.WriteLine();
        Console.ResetColor();
    }
}
while (senha == nome);