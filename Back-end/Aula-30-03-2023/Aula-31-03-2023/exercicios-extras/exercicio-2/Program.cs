using System;
using System.Collections.Generic;
using System.Linq;

float[] numbers = new float[3]; // Inicialização variável que recebe os números

// Lê os 3 números
for (int number = 0; number < 3; number++)
{
    Console.Write($"Insira o número {number+1}: ");
    numbers[number] = int.Parse(Console.ReadLine());
}

Array.Sort(numbers); // Ordena em ordem crescente os números

float minNumber = numbers.First();
float maxNumber = numbers.Last();
Console.WriteLine($"Menor número: {minNumber}, Maior número: {maxNumber}");