// CALCULAR qntd números ímpares e pares

int[] numeros = new int[6];
int qntd_numeros_impares = 0;
int qntd_numeros_pares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Insira um número: ");
    int numero = int.Parse(Console.ReadLine());

    numeros[i] = numero;
    if (numero % 2 == 0)
    {
        qntd_numeros_pares += 1;
    }
    else
    {
        qntd_numeros_impares += 1;
    }
}
Console.WriteLine();


Console.WriteLine($"Números pares: {qntd_numeros_pares}");
Console.WriteLine($"Números ímpares: {qntd_numeros_impares}");