// Recebe o salário
Console.Write("Informe o salário recebido: ");
float salary = float.Parse(Console.ReadLine());

// Recebe o valor gasto
Console.Write("Valor total gasto: ");
float moneySpent = float.Parse(Console.ReadLine());


// Retorna se os gastos estouraram ou não

// if (moneySpent <= salary)
//     Console.WriteLine("Gastos dentro do orçamento");
// else
//     Console.WriteLine("Orçamento estourado");
string printedResult = moneySpent <= salary ? "Gastos dentro do orçamento" : "Orçamento estourado";
Console.WriteLine(printedResult);