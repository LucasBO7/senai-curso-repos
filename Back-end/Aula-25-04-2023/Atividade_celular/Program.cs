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

Console.WriteLine($"O celular está desligado, deseja ligá-lo?(s/n): ");
char ligarCelular = char.Parse(Console.ReadLine()!.ToLower() == "sim" ? "s" : "n");

// Se desligado
if (celular.Ligado == false)
{
    Console.WriteLine(@$"
    O celular está desligado, deseja ligá-lo?
    
    ===| MENU |===
    ______________

    1) Ligar celular
    2) Desligar celular
    3) Fazer ligação
    4) Enviar Mensagem
    
    0) Sair
    ");
    bool opcaoValida = false;
    char opcaoSelecionada;
    do
    {
        opcaoSelecionada = char.Parse(Console.ReadLine()!);

        if (opcaoSelecionada != 1 && opcaoSelecionada != 2 && opcaoSelecionada != 3 && opcaoSelecionada != 4 && opcaoSelecionada != 5 && opcaoSelecionada != 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção indisponível. Ligue o celular primeiro ou insira os números mostrados acima para cada opção.");
            Console.ResetColor();
            opcaoValida = false;
        }
        else
        {
            opcaoValida = true;
        }
    } while (opcaoValida);

    switch (opcaoSelecionada)
    {
        case '1':
            // Se o celular estiver ligado, imprimir na tela. Se estiver desligado, ligar, marcar como opção válida e imprimir
            if (celular.Ligado)
            {
                Console.WriteLine($"O celular já está ligado");
            }
            else
            {
                celular.Ligar();
                Console.WriteLine($"Celular ligado.");
                opcaoValida = true;
            }
            break;

        case '2':
            celular.Desligar();
            break;

        case '3':
            celular.FazerLigacao();
            break;

        case '4':
            celular.EnviarMensagem();
            break;

        case '0':
            Environment.Exit(1);
            break;

        default:

            break;
    }
}
else
{

}