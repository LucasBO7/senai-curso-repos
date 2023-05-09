// 3.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.
// CLASSE --> Jogador / ATRIBUTOS --> nome, dataNascimento, nacionalidade, altura, peso / MÉTODO --> Imprimir todos os jogadores, Calcular idade do jogador, Mostrar quanto tempo falta para o jogador se apostentar.
// SUBCLASSE --> JogadorDefesa (40 anos), JogadorAtaque(35 anos), JogadorMeioCampo(38 anos)
using desafio;



// Inserção de valores
Console.Write(@$"
========================
    CADASTRO JOGADOR
====                ====

-> Nome: ");
string name = Console.ReadLine()!;

Console.Write($"-> Data de nascimento (dd/mm/yyyy): ");
string birthdateInput = Console.ReadLine()!;
var date = birthdateInput.Split('/');
DateOnly birthdate = new DateOnly(int.Parse(date[2]), int.Parse(date[2]), int.Parse(date[1]));

Console.Write("-> Nacionalidade: ");
string nationality = Console.ReadLine()!;

Console.Write("-> Altura: ");
float height = float.Parse(Console.ReadLine()!);

Console.Write("-> Peso: ");
float weight = float.Parse(Console.ReadLine()!);

Console.Write("-> Posição (d -> defesa/m -> meio-campo/a -> ataque): ");
char position = char.Parse(Console.ReadLine()!.ToLower());

Console.WriteLine($"========================");

float remainingTime = 0;
switch (position)
{
    case 'd':
        JogadorDefesa jogadorDefesa = new JogadorDefesa()
        {
            Name = name,
            Birthdate = birthdate,
            Nationality = nationality,
            Height = height,
            Weight = weight,
        };
        remainingTime = jogadorDefesa.TimeLeftRetire();
        break;

    case 'm':
        JogadorMeioCampo jogadorMeioCampo = new JogadorMeioCampo()
        {
            Name = name,
            Birthdate = birthdate,
            Nationality = nationality,
            Height = height,
            Weight = weight,
        };
        remainingTime = jogadorMeioCampo.TimeLeftRetire();
        break;

    case 'a':
        JogadorAtaque jogadorAtaque = new JogadorAtaque()
        {
            Name = name,
            Birthdate = birthdate,
            Nationality = nationality,
            Height = height,
            Weight = weight,
        };
        remainingTime = jogadorAtaque.TimeLeftRetire();
        break;

    default:
        break;
}
