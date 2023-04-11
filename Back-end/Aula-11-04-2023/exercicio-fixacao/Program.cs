// RECEBER 5 números inteiros
// EXIBIR o dobro dos números

int[] numeros = new int[5];
for (int x = 0; x < numeros.Length; x++)
{
    Console.Write($"Insira o número: ");
    numeros[x] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine($"DOBRO DOS NÚMEROS");

foreach (var item in numeros)
{
    Console.WriteLine(item * 2);
    
}