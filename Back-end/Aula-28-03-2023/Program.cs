// // Declaração de Variáveis
// string name = "Lucas Bianchezzi Oliveira";
// const int idade = 16;

// Console.WriteLine(name);
// Console.WriteLine(idade);
// Console.WriteLine();

// Console.WriteLine("Concatenação:");
// Console.WriteLine($"A idade do " + name + " é de " + idade + " anos ");
// Console.WriteLine($"A idade do {name} é de {idade}");




// Tipos de dados
// int quantity = 10;
// double price = 4.99d; // o d no final indica que é double
// float height = 1.8f;
// bool careca = true;
// string text = "Olá, mundo.";
// char letter = 'C';



// Operador de atribuição
// int idade = 36;

// Operadores aritméticos
// soma
// Console.WriteLine(4 + 4);
// Console.WriteLine(4 + "4");

// // subtração
// Console.WriteLine(10 - 8);

// // multiplicação
// Console.WriteLine(5 * 9);

// // divisão
// Console.WriteLine(10 / 2);

// // modular
// Console.WriteLine(10 % 2);

// Operadores de comparação

// igual a
// Console.WriteLine(5 == 5);

// // maior ou igual a
// Console.WriteLine(5 >= 4);


// // menor ou igual a
// Console.WriteLine(4 <= 3);

// // maior que
// Console.WriteLine(5 > 1);

// // menor que
// Console.WriteLine(5 < 2);

// // diferente de
// Console.WriteLine(5 != 8);



// Operadores lógicos e Tabela verdade

// && : e
// || : ou
// ! : negação

//      ---- TABELA VERDADE ----
// Console.WriteLine(5 == 5 && 8 == 8); //TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 9); //TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8); //FALSE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 9); //FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 == 3); //TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 3 == 4); //TRUE || FALSE = TRUE
// Console.WriteLine(2 == 3 || 3 == 3); //FALSE || TRUE = TRUE
// Console.WriteLine(1 == 2 || 3 == 5); //FALSE || FALSE = FALSE

// Console.WriteLine(!(2 == 4 || 3 == 8)); //TRUE || TRUE = TRUE 
// Console.WriteLine(!(2 == 2 || 3 == 3));
// Console.WriteLine(!(2 == 2 || 3 == 3));
// Console.WriteLine(!(2 == 2 || 3 == 3));

// Crie um programa para calcular o IMC de uma pessoa
// entradas
string name = "Lucas";
float weight = 63f;
float height = 1.67f;

// processamento
float imc = weight/(height * height);

Console.WriteLine("O IMC do " + name + " é de " + Math.Round(imc, 2));