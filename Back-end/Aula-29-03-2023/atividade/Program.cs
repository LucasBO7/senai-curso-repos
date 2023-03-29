Console.WriteLine("Insira sua idade: ");
int idade = int.Parse(Console.ReadLine());

int idadeEmMeses = idade * 12; // idade + 1 ano em meses
int idadeEmDias = idade * 365; // idade + 1 ano em dias
long idadeEmHoras = idade * (24 * 8760); // Idade + 1 ano em horas --> 24 * 365
long idadeEmMinutos = idade * 525600; // idade + 1 ano em minutos --> 60 * 24 * 365

Console.WriteLine($"Idade em meses: {idadeEmMeses}, idade em dias: {idadeEmDias}, idade em horas: {idadeEmHoras}, idade em minutos: {idadeEmMinutos}");