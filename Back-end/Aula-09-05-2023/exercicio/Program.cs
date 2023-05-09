using System.Globalization;
using exercicio;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
-----------------------------------------
/                                       /
/       CONVERSOR DE MOEDAS             /
/           dólar e real                /
/                                       /
-----------------------------------------");

// Visual e inserção de informações
char opcaoMenuSelecionada;
do
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@$"
[1] Converter Real para Dólar
[2] Converter Dólar para Real
[3] Cotação atual do Dólar e Real

[0]");

        opcaoMenuSelecionada = char.Parse(Console.ReadLine()!.ToLower());
    } while (opcaoMenuSelecionada != '1' && opcaoMenuSelecionada != '2' && opcaoMenuSelecionada != '3' && opcaoMenuSelecionada != '0');
    Console.ResetColor();

    // Execução de cada área selecionada no menu
    float moeda;
    switch (opcaoMenuSelecionada)
    {
        case '1':
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@$"
--/ Conversor de Real para Dólar /--
Insira o valor a ser convertido (R$): ");
            float valorReal = float.Parse(Console.ReadLine()!);

            moeda = Moeda.ConverterRealParaDolar(valorReal);
            Console.WriteLine(@$"R$ {valorReal.ToString("F2", new CultureInfo("pt-BR"))} equivalem a $ {moeda.ToString("F2", new CultureInfo("en-US"))}
Considerando que o valor do Real está atualmente de {Moeda.Real.ToString("F2")} dólares");

            Console.ResetColor();
            break;

        case '2':
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@$"
--/ Conversor de Dólar para Real /--
Insira o valor a ser convertido ($): ");
            float valorDolar = float.Parse(Console.ReadLine()!);

            moeda = Moeda.ConverterDolarParaReal(valorDolar);

            Console.WriteLine(@$"$ {valorDolar.ToString("F2", new CultureInfo("en-US"))} equivalem a R$ {moeda.ToString("F2", new CultureInfo("pt-BR"))}
Considerando que o valor do Dólar está atualmente de {Moeda.Real.ToString("F2")} reais");
            Console.ResetColor();
            break;

        case '3':
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            string cotacao = Moeda.RetornarCotacao();
            Console.ResetColor();
            Console.WriteLine(cotacao);
            break;

        case '0':
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Saindo do programa...");
            Thread.Sleep(2000);
            Console.ResetColor();
            Environment.Exit(1);
            break;

        default:
            break;
    }
} while (opcaoMenuSelecionada != '0');