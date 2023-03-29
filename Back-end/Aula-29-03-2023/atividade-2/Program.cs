Console.WriteLine("Insira o ano de seu Nascimento: ");
int anoDeNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Today.Year;
int idadeEmAnos = anoAtual - anoDeNascimento;
int idadeEmSemanas = idade * 52;

Console.WriteLine($"Seu ano de nascimento: {anoDeNascimento}.   Idade em Anos: {idadeEmAnos}, Idade em semanas: {idadeEmSemanas}");