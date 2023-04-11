﻿// ALGORÍTMO
// LER nome e idade (5 pessoas)
// IMPRIMIR nome e idade (5 pessoas)
// Resposta do nome em azul;    Resposta da idade em verde;
// nome: Jose /n idade: 40 anos 

int quantidade_pessoas = 5 ;
string[] name = new string[quantidade_pessoas];
int[] idade = new int[quantidade_pessoas];

for (int i = 0; i < quantidade_pessoas; i++)
{
    Console.Write($"Insira seu nome: ");
    name[i] = Console.ReadLine();

    Console.Write($"Insira sua idade: ");
    idade[i] = int.Parse(Console.ReadLine());

    Console.WriteLine();
}
Console.WriteLine($"_______________________");


for (int x = 0; x < quantidade_pessoas; x++)
{
    Console.Write($"{x + 1}) nome: ");
    Console.ForegroundColor = ConsoleColor.Blue; // Aplica cor azul à resposta
    Console.WriteLine($"{name[x]}");
    Console.ResetColor();


    Console.Write($"idade: ");
    Console.ForegroundColor = ConsoleColor.Green; // Aplica cor verde à resposta
    Console.WriteLine($"{idade[x]} anos");
    Console.ResetColor();

    Console.WriteLine(); // Pula linha
    
}