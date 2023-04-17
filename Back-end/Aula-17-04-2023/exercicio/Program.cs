// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

// Métodos
static void LoginUser(bool accessStats, string passwordRegistered)
{
    do
    {
        Console.Write($"Insira a senha: ");
        string password = Console.ReadLine();

        if (password == passwordRegistered)
        {
            accessStats = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Senha correta! Liberado. \n");
            Console.ResetColor();
        }
        else
        {
            accessStats = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Senha incorreta! Tente novamente. \n");
            Console.ResetColor();
        }
    } while (accessStats == false);
}
static void RegisterTicket(string[] passengerName, string[] origin, string[] destiny, DateOnly[] flightDate)
{
    char registerMoreTickets = 'n';

    Console.WriteLine(@$"
         ______________________________
        |                              |
        | CADASTRO DE PASSAGENS AÉREAS |
        |______________________________|
        
        ");

    int actualPosition = 0; // Busca o índex dos arrays
    do
    {
        Console.Write($"Nome do passageiro: ");
        passengerName[actualPosition] = Console.ReadLine();

        Console.Write($"Origem: ");
        origin[actualPosition] = Console.ReadLine();

        Console.Write($"Destino: ");
        destiny[actualPosition] = Console.ReadLine();

        Console.Write($"Data do vôo: ");
        string[] flightDateInString = Console.ReadLine().Split('/');

        flightDate[actualPosition].AddDays(int.Parse(flightDateInString[0])); // Dias
        flightDate[actualPosition].AddMonths(int.Parse(flightDateInString[1])); // Mêses
        flightDate[actualPosition].AddYears(int.Parse(flightDateInString[2])); // Anos
        Console.WriteLine(); // Pula linha
        

        Console.Write($"Deseja cadastrar uma nova passagem?(s/n): ");
        registerMoreTickets = char.Parse(Console.ReadLine().ToLower());

        Console.WriteLine(); // Pula linha
        Console.WriteLine(); // Pula linha
        

        actualPosition++;
    } while (registerMoreTickets == 's' && actualPosition < 5);

    Menu(passengerName, origin, destiny, flightDate);
}
static void ListTickets(string[] passengerName, string[] origin, string[] destiny, DateOnly[] flightDate)
{
    if (passengerName.Any())
    {
        for (int x = 0; x < passengerName.Count(); x++)
        {
            Console.WriteLine(@$"
            Nome do passageiro: {passengerName[x]}
            Origem: {origin[x]}
            Destino: {destiny[x]}
            Data de vôo: {flightDate[x]}
            ");
        }
    }
    else
    {
        Console.WriteLine($"A lista esta vazia, deseja cadastrar alguma passagem? (s/n): ");
        char registerAnyTicket = char.Parse(Console.ReadLine());
    }
}
static void Menu(string[] passengerName, string[] origin, string[] destiny, DateOnly[] flightDate)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(@$"
_________________________
    
     ____________
    |            |
    |    MENU    |
    |____________|
    
Utilize os respectivos números para cada função
1 - Cadastrar passagem
2 - Listar passagens
0 - Sair
");
Console.ResetColor();
    char menu = char.Parse(Console.ReadLine());
    switch (menu)
    {
        case '1':
            RegisterTicket(passengerName, origin, destiny, flightDate);
            break;

        case '2':
            ListTickets(passengerName, origin, destiny, flightDate);
            break;

        case '0':
            Console.WriteLine($"Acabou essa merda! Sai daqui!!");
            Environment.Exit(5);
            break;
    }
}

bool accessAllowed = false;
string passwordRegistered = "123456";

string[] passengerName = new string[5];
string[] origin = new string[5];
string[] destiny = new string[5];
DateOnly[] flightDate = new DateOnly[5];


LoginUser(accessAllowed, passwordRegistered);
Menu(passengerName, origin, destiny, flightDate);