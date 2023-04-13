// RECEBER ano atual, ano de nascimento
// IMPRIMIR se poderá ou não votar este ano (não considerar o ano de nascença).

DateOnly actualDate = DateOnly.FromDateTime(DateTime.Now);

Console.Write($"Insira o ano em que nasceu: ");
int birthdateYear = int.Parse(Console.ReadLine());

int years = actualDate.Year - birthdateYear;

if (years >= 16 && years < 18)
{
    Console.WriteLine($"Você poderá votar este ano caso queira.");
}
else
{
    if (years >= 18)
    {
        Console.WriteLine($"Você deve votar este ano.");
    }
    else
    {
        Console.WriteLine($"Você não poderá votar este ano. {years}");
    }
}