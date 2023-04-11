string[]carros = new string[3];

for (int i = 0; i < 3; i++)
{
    // Bloco de código a ser executado
    Console.WriteLine($"Digite o nome do carro:");
    carros[i] = Console.ReadLine();
}

for (int i = 0; i < 300; i++)
{
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");   
}
/* Foreach (var item in carros)
{
    Console.WriteLine($"Nome do carro: {item}");
}

*/