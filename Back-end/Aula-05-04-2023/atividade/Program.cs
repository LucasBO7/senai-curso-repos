// Inicialização das variáveis
string nome;
int idade;
float salario;
char estadoCivil;

Console.WriteLine($"Insira as informações abaixo:");
do
{
    Console.Write($"Nome: ");
    nome = Console.ReadLine();
    
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Write("Salário: ");
    salario = float.Parse(Console.ReadLine());

    Console.Write("Estado civil: ");
    estadoCivil = char.Parse(Console.ReadLine().ToLower());
    Console.WriteLine();
}
while (nome == "" || idade <= 0 || idade > 100 || salario <= 0 || estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd');