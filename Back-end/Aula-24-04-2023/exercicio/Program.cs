// Cadastro de alunos
// Classe Aluno --> Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade --> VerMediaFinal() e VerMensalidade()
// se bolsista... fazer cálculo:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
using exercicio;

Console.WriteLine(@$"
___________________________
    Cadastro de Alunos

___________________________

");

Console.Write($"Nome: ");
string name = Console.ReadLine();

Console.Write($"Nome do curso: ");
string courseName = Console.ReadLine();

Console.Write($"Idade: ");
int age = int.Parse(Console.ReadLine());

Console.Write($"RG(Registro Geral): ");
int rg = int.Parse(Console.ReadLine());

Console.Write($"É bolsista? (s/n): ");
bool isScholarship = Console.ReadLine() == "s" ? true : false;

Console.Write($"Média final: ");
float finalAverage = float.Parse(Console.ReadLine()); // Média final

Console.Write($"Valor da mensalidade: ");
float monthlyFee = float.Parse(Console.ReadLine()); // Valor da mensalidade

float discount = 0;

// Inicialização da variável
Student student = new Student()
{
    Name = name,
    Course = courseName,
    Age = age,
    RG = rg,
    IsScholarshipStudent = isScholarship,
    FinalAverage = finalAverage,
    MonthlyFee = monthlyFee
};

// Calcula o desconto
student.CalculateDiscount(isScholarship, finalAverage, monthlyFee, discount);
Menu(student);

static void Menu(Student student)
{
    Console.WriteLine(@$"
     ______MENU______
    |
    | 1) Visualizar a média
    | 2) Visualizar o valor da Mensalidade
    | 3) Cadastrar usuários
    |
    | 0) Sair
     ________________

    ");
    int selectedMenu = int.Parse(Console.ReadLine());

    switch (selectedMenu)
    {
        case 1:
            student.ShowFinalAverage(student, student.FinalAverage);
            Menu(student);
            break;

        case 2:
            student.ShowMonthlyFee(student, student.MonthlyFee);
            Menu(student);
            break;

        case 3:
            break;

        case 0:
            Environment.Exit(1);
            break;

        default:

            break;
    }
}