// Regra de Valores --> (evita números mágicos)
int daysInEachMonth = 31; // Quantidade de anos em cada mês
int actualYear = 2013; // Ano atual
int minimumYear = 1910;

// Recepção de valores
Console.Write("Insira o dia, mês e ano de seu nascimento (dd/mm/yyyy): ");
string[] birthdateInString = Console.ReadLine().Split('/');

// Passa valores para um objeto DateOnly
int day = int.Parse(birthdateInString[0]);
int month = int.Parse(birthdateInString[1]);
int year = int.Parse(birthdateInString[2]);

// Day between 0 and 31(daysInEachMont), year less or equals to the actual year, month more than 0 and less/equals than 12
if ((day > 0) && (day <= daysInEachMonth) && (year <= actualYear) && (year >= minimumYear) && (month > 0) && (month <= 12))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Data válida!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Data inválida!");
    Console.ResetColor();
}