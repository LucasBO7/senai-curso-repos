// Inicialização das variáveis
string nome;
int idade;
float salario;
char estadoCivil;

// filtros para idade máxima e mínima 
int idademaxima = 100;
int idademinima = 1;

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
while (nome == "" || idade < idademinima || idade > idademaxima || salario <= 0 || estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd');