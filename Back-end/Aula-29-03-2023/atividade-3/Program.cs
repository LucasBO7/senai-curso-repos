Console.WriteLine("Insira o nome do aluno:");
string nome = Console.ReadLine();

Console.WriteLine($"Insira a nota1 do aluno:");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota2 do aluno:");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota3 do aluno:");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota4 do aluno:");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota5 do aluno:");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"A média do aluno {nome} é de {media}.   Por meio das notas: {nota1}, {nota2}, {nota3}, {nota4}, {nota5}");