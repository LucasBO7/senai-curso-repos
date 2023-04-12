// MÉTODOS
// Soma 2 números
static float Sum(float n1, float n2)
{
    float result_sum = n1 + n2;
    return result_sum;
}

// Subtrai 2 números
static float Subtract(float n1, float n2)
{
    float result_subtract = n1 - n2;
    return result_subtract;
}

// Multiplica 2 números
static float Multiply(float n1, float n2)
{
    float result_multiplicacao = n1 * n2;
    return result_multiplicacao;
}

// Divide 2 números
static float Divide(float n1, float n2)
{
    float result_division = n1 / n2;
    return result_division;
}


float result;
string continueExecutingProgram = "sim";

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(@$"
CALCULADORA SIMPLES

Use os seguintes operadores para o tipo da operação:
(+  -->  adição)
(-  -->  subtração)
(*  -->  multiplicação)
(/  -->  divisão)

");
Console.ResetColor();

do
{
    Console.WriteLine($"Insira o tipo de operação que deseja realizar: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    char operationType = char.Parse(Console.ReadLine());
    Console.ResetColor();

    Console.WriteLine(); // Pula linha


    // Inputs
    Console.Write($"Insira o primeiro número: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    float first_number = float.Parse(Console.ReadLine());
    Console.ResetColor();

    Console.Write($"Insira o segundo número: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    float second_number = float.Parse(Console.ReadLine());
    Console.ResetColor();


    switch (operationType)
    {
        case '+':
            result = Sum(first_number, second_number);
            Console.WriteLine($"{first_number} + {second_number} = {result}");
            break;

        case '-':
            result = Subtract(first_number, second_number);
            Console.WriteLine($"{first_number} - {second_number} = {result}");
            break;

        case '/':
            result = Divide(first_number, second_number);
            Console.WriteLine($"{first_number} / {second_number} = {result}");
            break;

        case '*':
            result = Multiply(first_number, second_number);
            Console.WriteLine($"{first_number} * {second_number} = {result}");
            break;

        default:
            Console.WriteLine($"Não há nenhuma operação possível no padrão escolhido. use apenas (soma, subtração, divisão ou multiplicação)!!");
            break;
    }

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Deseja realizar outra conta? (sim/não): ");
    continueExecutingProgram = Console.ReadLine();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"_________________________________________");
    Console.ResetColor();
    

    Console.WriteLine();
    Console.WriteLine();

} while (continueExecutingProgram == "sim" || continueExecutingProgram == "s");