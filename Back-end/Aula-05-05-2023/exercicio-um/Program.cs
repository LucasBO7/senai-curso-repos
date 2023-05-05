// CLASSE --> elevador  -   PROPRIEDADES --> AndarAtual, TotalDeAndares, Capacidade, PessoasPresentesNoElevador, 
// MÉTODOS --> inicializa, --> capacidade e total de andares    /   Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço); Sair : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele); Subir : para subir um andar (não deve subir se já estiver no último andar); Descer : para descer um andar (não deve descer se já estiver no térreo); Encapsular todos os atributos da classe (criar os métodos set e get).
using exercicio_um;


// Recepção de informacoes do elevador
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
-------------------------------
|   INFORMAÇÕES DO ELEVADOR
|");
Console.Write($"|   Total de andares do predio: ");
int totalAndares = int.Parse(Console.ReadLine()!);

Console.Write($"|   Capacidade do elevador: ");
int capacidade = int.Parse(Console.ReadLine()!);

Console.Write($"|   Quantidade de pessoas dentro do elevador no momento: ");
int quantidadePessoas = int.Parse(Console.ReadLine()!);
Console.ResetColor();

Elevador elevador = new Elevador() // Inicialização da variável
{
    AndarAtual = 0,
    TotalAndares = totalAndares,
    Capacidade = capacidade,
    QntdPessoasDentro = quantidadePessoas
};


// Inicializa as variáveis
elevador.Inicializar(capacidade, totalAndares, quantidadePessoas);


// Menu
Console.Clear();
char menuSelection;
elevador.MostrarInformacoes();


// Loop enquanto não for sair do programar (selecionar 0)
do
{
    do
    {
        // =  Andar atual: {(elevador.AndarAtual < 10 ? $"0{elevador.AndarAtual}" : $"{elevador.AndarAtual}")}      =
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@$"
=========================
=  Controle de ações    =
=                       =
=  [1] Entrar           =
=  [2] Sair             =
=  [3] Subir            =
=  [4] Descer           =
=                       =
=  [0] Sair do sistema  =
=========================");
        menuSelection = char.Parse(Console.ReadLine()!.ToLower());
        Console.ResetColor();
    } while (menuSelection != '0' && menuSelection != '1' && menuSelection != '2' && menuSelection != '3' && menuSelection != '4');

    // Ações do Menu
    switch (menuSelection)
    {
        case '0':
            Environment.Exit(1); // Fecha o programa
            break;

        case '1':
            elevador.Entrar();
            break;

        case '2':
            elevador.Sair();
            break;

        case '3':
            elevador.Subir();
            break;

        case '4':
            elevador.Descer();
            break;
    }

    elevador.MostrarInformacoes();
} while (menuSelection != 0);