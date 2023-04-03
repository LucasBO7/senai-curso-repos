//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

Console.ForegroundColor = ConsoleColor.Green; // Insere cor nos caracteres de verde
Console.WriteLine(@$"
     _______________________________
    /                               \
   |         BAR DA ALEGRIA          |
    \_______________________________/
");
Console.ResetColor(); // Reseta cor

Console.WriteLine(@$"
    -----Cardápio------>

    o Coca cola -> (digite c)
    o Pepsi -> (digite p)
    o Fanta -> (digite f)
    o Monster -> (digite m)


");

Console.Write($"Escolha uma das opções do cardápio: ");
char bebidaEscolhida = char.Parse(Console.ReadLine().ToLower());

Console.WriteLine(); // Pula linha

Console.Write($"Deseja acrescentar gelo na bebida?(s/n): ");
char acrescentarGelo = char.Parse(Console.ReadLine().ToLower());

// Checa se deve add gelo ou não e guarda na variável.
string addGelo = acrescentarGelo == 's' ? "com gelo" : "sem gelo";
Console.WriteLine();

// Imprime com base na bebida
switch (bebidaEscolhida)
{
    case 'c':
        Console.WriteLine($"Bebida: Coca cola {addGelo}");
        break;
    case 'P':
        Console.WriteLine($"Bebida: Pepsi {addGelo}");
        break;
    case 'f':
        Console.WriteLine($"Bebida: Fanta {addGelo}");
        break;
    case 'm':
        Console.WriteLine($"Bebida: Monster {addGelo}");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@$"A bebida selecionada não existe.");
        Console.ResetColor();

        Console.WriteLine(@$"
        Use as seguintes nomenclaturas:
        c para Coca Cola
        p para Pepsi
        f para Fanta
        m para Monster

        s para adicionar gelo
        n para não adicionar gelo");
        break;
}