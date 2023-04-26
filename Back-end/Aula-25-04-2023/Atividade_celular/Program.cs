// CLASSE Celular --> cor, modelo, tamanho, estáLigado
// MÉTODOS ligar, desligar, fazerLigação, Enviarmensagem
// EXECUTAR métodos somente, se celular ligado
using Atividade_celular;


Console.Write(@$"
-----------------------------
    CADASTRO DO CELULAR
-----------------------------
");

// Leitura de valores
Console.Write($"Modelo: ");
string modelo = Console.ReadLine()!;

Console.Write($"Cor: ");
string cor = Console.ReadLine()!;

Console.Write($"Tamanho (em polegadas): ");
float tamanho = float.Parse(Console.ReadLine()!);

// Instanciação do objeto
Celular celular = new Celular()
{
    Modelo = modelo,
    Cor = cor,
    Tamanho = tamanho
};

Menu(celular);


static void Menu(Celular celular)
{
    bool abrirMenu = false;
    char opcaoSelecionada;

    do
    {
        // Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        // Se o celular estiver desligado
        if (celular.Ligado == false)
        {
            Console.WriteLine(@$"
    O celular está desligado. Ligue-o para realizar operações com o celular.
    
    ===| MENU |===
    ______________

    1) Ligar celular
    2) Desligar celular
    
    0) Sair
    ");
        }
        else
        {
            Console.WriteLine(@$"    
    ===| MENU |===
    ______________

    1) Ligar celular
    2) Desligar celular
    3) Fazer ligação
    4) Enviar Mensagem
    
    0) Sair
    ");
        }

        Console.ResetColor();

        opcaoSelecionada = char.Parse(Console.ReadLine()!);
        // Se o celular estiver Desligado
        if (celular.Ligado == false)
        {
            switch (opcaoSelecionada)
            {
                case '1':
                    // Se o celular estiver ligado, imprimir na tela. Se estiver desligado, ligar, marcar como opção válida e imprimir
                    celular.Ligar();
                    abrirMenu = true;
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine($"O celular já está desligado.");
                    abrirMenu = true;
                    break;

                case '0':
                    abrirMenu = true;
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine($"Opção selecionada não correspondente, selecione como mostrado no Menu.");
                    break;
            }
        }
        else // Se o celular estiver ligado
        {
            switch (opcaoSelecionada)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine($"O celular já está ligado");
                    break;

                case '2':
                    celular.Desligar();
                    abrirMenu = true;
                    break;

                case '3':
                    celular.FazerLigacao();
                    abrirMenu = true;
                    break;

                case '4':
                    celular.EnviarMensagem();
                    abrirMenu = true;
                    break;

                case '0':
                    abrirMenu = false;
                    Environment.Exit(1); // Fecha o programa
                    break;

                default:
                    Console.WriteLine($"Opção selecionada não correspondente, selecione como mostrado no Menu.");
                    break;
            }

        }


    } while (abrirMenu == true);

}