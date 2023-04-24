
// Calculadora
// 4 Operações matemáticas --> método para cada uma
// Menu de opções
// LER 2 números
using Aula_24_04_2023;


char[] operadores = { '+', '-', '/', '*' };

Console.WriteLine(@$"
________________________________
+           CALCULADORA        +
________________________________

Utilize os sinais abaixo para as operações:
|   + adicao
|   - subtração
|   / divisão
|   * multiplicação

");

// Console.Write($"Insira a operação: ");
// string inputOperacao = Console.ReadLine();
// string operacao;

// // Pega a operação / o separador do input
// foreach (var separador in operadores)
// {
//     if (inputOperacao.Contains(separador))
//     {
//         operacao = separador;
//         break;
//     }
// }

// // Splita os números
// string[] numeros = inputOperacao.Split(operacao);

// // Inicializa var da Classe com os números
// Calculadora calculadora = new Calculadora()
// {
//     Numero1 = int.Parse(numeros[0]),
//     Numero2 = int.Parse(numeros[1])
// };

// string operacaoSimbol = Console.ReadLine();

// Console.Write($"Insira o primeiro número: ");
// float numero1 = float.Parse(Console.ReadLine());

// Console.Write($"Insira o segundo número: ");
// float numero2 = float.Parse(Console.ReadLine());

// Calculadora calculadora = new Calculadora()
// {
//     Numero1 = numero1,
//     Numero2 = numero2
// };

var input = Console.ReadLine();
char operadorUsado = 'n';
// Checa qual operador existente na operação apresentada pelo usuário
foreach (var operador in operadores)
{
    // Testa se há o operador daquela posição no texto do input
    if (input.Contains(operador))
    {
        operadorUsado = operador;
        input.Split(operador);
    }
}

Calculadora calculadora = new Calculadora()
{
    Numero1 = input[0],
    Numero2 = input[1]
};
float resultado = 0;
switch (operadorUsado)
{
    case '+':
        resultado = calculadora.Somar();
        break;

    case '-':
        resultado = calculadora.Subtrair();
        break;

    case '/':
        resultado = calculadora.Dividir();
        break;

    case '*':
        resultado = calculadora.Multiplicar();
        break;
}

Console.WriteLine($"{calculadora.Numero1} {operadorUsado} {calculadora.Numero2} = {resultado}");
