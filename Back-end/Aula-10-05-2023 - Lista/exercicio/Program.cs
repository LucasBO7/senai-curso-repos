// Criar um projeto de console
// Criar uma classe Carro
// - Marca - Cor
// Criar um Construtor vazio e outro completo
// Receber dados no console para adicionar 2 objetos em uma lista

using exercicio;


List<Carro> carros = new List<Carro>();

char menu_option;
do
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@$"
 ______________________________
|              MENU            |
|                              |
| [1] Adicionar um carro       |
| [2] Procurar carros          |
|                              |
| [0] Sair                     |
|______________________________|");
    menu_option = char.Parse(Console.ReadLine()!.ToLower());
    Console.ResetColor();

    switch (menu_option)
    {
        case '1':
            // Adicionar um carro à lista
            Console.Clear();
            Carro carro = new Carro();

            Console.Write($"Marca do carro: ");
            carro.Marca = Console.ReadLine()!.ToLower();

            Console.Write($"Cor do carro: ");
            carro.Cor = Console.ReadLine()!.ToLower();

            carros.Add(carro);
            break;

        case '2':
            Console.WriteLine(@$"
 ______________________________
|              MENU            |
|                              |
| [1] Buscar por marca         |
| [2] Buscar por cor           |
|______________________________|");
            break;
    }



    char tipo_busca;
    do
    {
        Console.Clear();
        Console.Write($"Como deseja realizar a busca? Por marca(m) ou por cor(c)?: ");
        tipo_busca = char.Parse(Console.ReadLine()!.ToLower());

    } while (tipo_busca != 'm' && tipo_busca != 'c');

    switch (tipo_busca)
    {
        case 'm':
            Console.Write($"Insira a marca que deseja buscar: ");
            string marca = Console.ReadLine()!.ToLower();
            break;
        case 'c':
            Console.Write("Insira a cor do carro que deseja buscar: ");
            string cor = Console.ReadLine()!.ToLower();
            break;

        default:
            break;
    }
} while ();