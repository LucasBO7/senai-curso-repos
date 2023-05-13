using exercicio_interface;

Agenda agenda = new Agenda();

List<Contato> contatos = new List<Contato>();

ContatoComercial contato_comercial = new ContatoComercial();
ContatoPessoal contato_pessoal = new ContatoPessoal();

MenuPrincipal(contatos, contato_comercial, contato_pessoal, agenda);

static void MenuPrincipal(List<Contato> contatos, ContatoComercial contato_comercial, ContatoPessoal contato_pessoal, Agenda agenda)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
 __________________________
|--------| AGENDA |--------|
|                          |
| [1] Contatos             |
| [2] Adicionar Contato    |
|                          |
| [0] Sair do progama      |
|__________________________|
");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"Insira o número correspondente à opção: ");
    Console.ResetColor();
    Console.ResetColor();
    string agendaMenu;

    // Validação do Input agendaMenu
    do
    {
        agendaMenu = Console.ReadLine()!; // Lê a inserção

        // Mensagem de valor inválido inserido
        if (agendaMenu != "1" && agendaMenu != "2" && agendaMenu != "0")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"VALOR INVÁLIDO, DIGITE UM DOS VALORES A SEGUIR: 1, 2, 0");
            Console.ResetColor();
        }
    } while (agendaMenu != "1" && agendaMenu != "2" && agendaMenu != "0");

    switch (agendaMenu)
    {
        case "1":
            Console.WriteLine(@$"
__________________________
|------| CONTATOS |------|
");         
            // agenda.contatos = contatos;
            agenda.Listar();
            break;

        case "2":
            MenuAdicionarContato(contatos, contato_comercial, contato_pessoal, agenda);
            break;

        case "0":
            Environment.Exit(1);
            break;
    }
}

static void MenuAdicionarContato(List<Contato> contatos, ContatoComercial contato_comercial, ContatoPessoal contato_pessoal, Agenda agenda)
{
    Console.Clear();
    string menuAddContato; // Recebe o valor do menu
    string confirmacaoTelaFormulario = ""; // Pergunta se o usuário deseja mesmo add um Contato Comercial/Pessoal

    do
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@$"
 __________________________________________
|           ADICIONAR CONTATO              |
| Que tipo de Contato deseja adicionar?    |
| [1] Contato Comercial                    |
| [2] Contato Pessoal                      |
| [0] Voltar                               |
|__________________________________________|
");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Insira o número correspondente à opção: ");
        Console.ResetColor();
        Console.ResetColor();

        // Validação do Input tipoContato
        do
        {
            menuAddContato = Console.ReadLine()!; // Lê a inserção

            // Mensagem de valor inválido inserido
            if (menuAddContato != "1" && menuAddContato != "2" && menuAddContato != "0")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"VALOR INVÁLIDO, DIGITE UM DOS VALORES A SEGUIR: 1, 2, 0");
                Console.ResetColor();
            }
        } while (menuAddContato != "1" && menuAddContato != "2" && menuAddContato != "0");

        // Confirmação se ir Para tela de inserção de Contato Comercial/Pessoal
        if (menuAddContato != "0")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Deseja adicionar um contato comercial? (s/n): ");
            Console.ResetColor();
            do
            {
                confirmacaoTelaFormulario = Console.ReadLine()!.ToLower();
            } while (confirmacaoTelaFormulario != "s" && confirmacaoTelaFormulario != "n");
            Console.Clear();
        }
    } while (confirmacaoTelaFormulario != "s" && menuAddContato != "0");


    switch (menuAddContato)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@$"
____________________________________
|   FORMULÁRIO CONTATO COMERCIAL   
|                                  
| Nome: ");
            string nome = Console.ReadLine()!;

            Console.Write($"| Telefone: ");
            string telefone = Console.ReadLine()!;

            Console.Write($"| Email: ");
            string email = Console.ReadLine()!;

            Console.Write($"| CNPJ: ");
            string cnpj = Console.ReadLine()!;
            Console.WriteLine($"|___________________________________");
            Console.ResetColor();

            ContatoComercial novoContatoComercial = new ContatoComercial(nome, telefone, email, cnpj);
            contato_comercial = novoContatoComercial;
            agenda.Adicionar(contato_comercial); // Adiciona à lista de contatos

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Pressione ENTER para prosseguir...");
            Console.ReadLine();
            Console.ResetColor();

            Console.Clear();
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@$"
____________________________________
|     FORMULÁRIO CONTATO PESSOAL   
|                                  
| Nome: ");
            nome = Console.ReadLine()!;

            Console.Write($"| Telefone: ");
            telefone = Console.ReadLine()!;

            Console.Write($"| Email: ");
            email = Console.ReadLine()!;

            Console.Write($"| CNPJ: ");
            string cpf = Console.ReadLine()!;
            Console.WriteLine($"|__________________________________|");
            Console.ResetColor();


            ContatoPessoal novoContatoPessoal = new ContatoPessoal();
            contato_pessoal = novoContatoPessoal;
            agenda.Adicionar(contato_pessoal); // Adiciona à lista de contatos

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Pressione ENTER para prosseguir...");
            Console.ReadLine();
            Console.ResetColor();

            Console.Clear();
            break;

        case "0":
            Console.Clear();
            MenuPrincipal(contatos, contato_comercial, contato_pessoal, agenda);
            break;
    }

    MenuPrincipal(contatos, contato_comercial, contato_pessoal, agenda);
}