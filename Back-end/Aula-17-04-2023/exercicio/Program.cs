﻿// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

// Métodos
// int count = 0;
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
        int countElementsWithValue = passengerName.Where(element => (!String.IsNullOrEmpty(element))).Count(); // Pega a quantidade de elementos que possuem um valor --> 
        int lastElementWithoutValue = countElementsWithValue;


        Console.Write($"Nome do passageiro: ");
        passengerName[lastElementWithoutValue] = Console.ReadLine();

        Console.Write($"Origem: ");
        origin[lastElementWithoutValue] = Console.ReadLine();

        Console.Write($"Destino: ");
        destiny[lastElementWithoutValue] = Console.ReadLine();

        Console.Write($"Data do vôo: ");
        var flightDateInString = Console.ReadLine().Split('/');

        // Divide cada valor da data em variáveis locais
        int day = Convert.ToInt16(flightDateInString[0]);
        int month = Convert.ToInt16(flightDateInString[1]);
        int year = Convert.ToInt16(flightDateInString[2]);
        DateOnly date = new DateOnly(year, month, day); // Cria um objeto DateOnly para receber as datas
        flightDate[lastElementWithoutValue] = date; // Passa o objeto para o flightDate

        Console.WriteLine(); // Pula linha


        Console.Write($"Deseja cadastrar uma nova passagem?(s/n): ");
        registerMoreTickets = char.Parse(Console.ReadLine().ToLower());

        Console.WriteLine(); // Pula linha
        Console.WriteLine(); // Pula linha


        actualPosition++;
        // count++;
    } while (registerMoreTickets == 's' && actualPosition < 5);

    Menu(passengerName, origin, destiny, flightDate);
}
static void ListTickets(string[] passengerName, string[] origin, string[] destiny, DateOnly[] flightDate)
{
    /*
    countElementsWithValue = count;

        Professor, encontrei duas formas de fazer esta lógica, a primeira que é o código que está acima + a variavel count
        e seu incremento dentro da classe "RegisterTicket" e a segunda que, é por meio do código abaixo: 
    */
    int countElementsWithValue = passengerName.Where(element => (!String.IsNullOrEmpty(element))).Count(); // Pega a quantidade de elementos que possuem um valor    

    if (countElementsWithValue > 0)
    {
        Console.WriteLine(@$"
         ________________________________
        |                                |            
        |        Lista de usuários       |
        |________________________________|
        
        ");


        for (int x = 0; x < countElementsWithValue; x++)
        {
            Console.WriteLine(@$"
Nome do passageiro: {passengerName[x]}
Origem: {origin[x]}
Destino: {destiny[x]}
Data de vôo: {flightDate[x].Day}/{flightDate[x].Month}/{flightDate[x].Year}
            ");
        }
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"A lista esta vazia, deseja cadastrar alguma passagem? (s/n): ");
        char registerAnyTicket = char.Parse(Console.ReadLine());

        if (registerAnyTicket == 's')
        {
            RegisterTicket(passengerName, origin, destiny, flightDate);
        }
    }
    Menu(passengerName, origin, destiny, flightDate);
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sistema finalizado!");
            Console.ResetColor();
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