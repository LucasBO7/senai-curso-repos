// VERSÃO 1
// Console.Write("Telefonou para a vítima?(sim/não): ");
// string telefonouVitima = Console.ReadLine().ToLower();

// Console.Write("Esteve no local do crime?(sim/não): ");
// string esteveLocal = Console.ReadLine().ToLower();

// Console.Write("Mora perto da vítima?(sim/não): ");
// string moraPerto = Console.ReadLine().ToLower();

// Console.Write("Devia para a vítima?(sim/não): ");
// string deviaDinheiro = Console.ReadLine().ToLower();

// Console.Write("Já trabalhou com a vítima?(sim/não): ");
// string trabalhouComVitima = Console.ReadLine().ToLower();

// int qntdPerguntasPositivas = 0;

// // Junta as quantias positivas
// if (telefonouVitima == "sim")
// {
//     qntdPerguntasPositivas += 1;
// }
// if (esteveLocal == "sim")
// {
//     qntdPerguntasPositivas += 1;
// }
// if (moraPerto == "sim")
// {
//     qntdPerguntasPositivas += 1;
// }
// if (deviaDinheiro == "sim")
// {
//     qntdPerguntasPositivas += 1;
// }
// if (trabalhouComVitima == "sim")
// {
//     qntdPerguntasPositivas += 1;
// }


// if (qntdPerguntasPositivas == 2)
// {
//     Console.WriteLine($"status: SUSPEITA, com participação de {qntdPerguntasPositivas} perguntas positivas.");
// }
// else if (qntdPerguntasPositivas == 3 || qntdPerguntasPositivas == 4)
// {
//     Console.WriteLine($"staus: CÚMPLICE, com participação de {qntdPerguntasPositivas} perguntas positivas.");
// }
// else if (qntdPerguntasPositivas == 5)
// {
//     Console.WriteLine($"staus: CULPADA, com participação de {qntdPerguntasPositivas} perguntas positivas.");
// }
// else
// {
//     Console.WriteLine($"status: INOCENTE, com participação de {qntdPerguntasPositivas} perguntas positivas.");
// }





// VERSÃO 2 - OPÇÃO 1 (if e Dictionary / switch-case e Dictionary)
// Dictionary<string, string> perguntas = new Dictionary<string, string>(); // Inicialização do objeto

// // Leitura de inputs/valores
// Console.Write("Telefonou para a vítima?(sim/não): ");
// string telefonouVitima = Console.ReadLine().ToLower();

// Console.Write("Esteve no local do crime?(sim/não): ");
// string esteveLocal = Console.ReadLine().ToLower();

// Console.Write("Mora perto da vítima?(sim/não): ");
// string moraPerto = Console.ReadLine().ToLower();

// Console.Write("Devia para a vítima?(sim/não): ");
// string deviaDinheiro = Console.ReadLine().ToLower();

// Console.Write("Já trabalhou com a vítima?(sim/não): ");
// string trabalhouComVitima = Console.ReadLine().ToLower();

// // Atribuição de valores à propriedade de objeto Dictionary
// perguntas.Add("telefonouVitima", telefonouVitima);
// perguntas.Add("esteveLocal", esteveLocal);
// perguntas.Add("moraPerto", moraPerto);
// perguntas.Add("deviaDinheiro", deviaDinheiro);
// perguntas.Add("trabalhouVitima", trabalhouComVitima);

// if (perguntas.Count == 2)
// {
//     Console.WriteLine($"status: SUSPEITA, com participação de {perguntas.Count} perguntas positivas.");
// }
// else if (perguntas.Count >= 3 && perguntas.Count <= 4)
// {
//     Console.WriteLine($"status: CÚMPLICE, com participação de {perguntas.Count} perguntas positivas.");
// }
// else if (perguntas.Count == 5)
// {
//     Console.WriteLine($"status: CULPADA, com participação de {perguntas.Count} perguntas positivas.");
// }
// else
// {
//     Console.WriteLine($"status: INOCENTE, com participação de {perguntas.Count} perguntas positivas.");
// }


// Opção 2
// switch (perguntas.Count)
// {
//     case 2:
//         Console.WriteLine($"status: SUSPEITA, com participação de {perguntas.Count} perguntas positivas.");
//         break;

//     case 3:
//         Console.WriteLine($"status: CÚMPLICE, com participação de {perguntas.Count} perguntas positivas.");
//         break;

//     case 4:
//         Console.WriteLine($"status: CÚMPLICE, com participação de {perguntas.Count} perguntas positivas.");
//         break;

//     case 5:
//         Console.WriteLine($"status: CULPADA, com participação de {perguntas.Count} perguntas positivas.");
//         break;

//     default:
//         Console.WriteLine($"status: INOCENTE, com participação de {perguntas.Count} perguntas positivas.");
//         break;
// }






// VERSÃO 3
List<string> perguntas = new List<string>();

// Leitura de inputs/valores
Console.Write("Telefonou para a vítima?(sim/não): ");
perguntas.Add(Console.ReadLine().ToLower());

Console.Write("Esteve no local do crime?(sim/não): ");
perguntas.Add(Console.ReadLine().ToLower());

Console.Write("Mora perto da vítima?(sim/não): ");
perguntas.Add(Console.ReadLine().ToLower());

Console.Write("Devia para a vítima?(sim/não): ");
perguntas.Add(Console.ReadLine().ToLower());

Console.Write("Já trabalhou com a vítima?(sim/não): ");
perguntas.Add(Console.ReadLine().ToLower());


int qntdRespostasPositivas = perguntas.FindAll(resposta => resposta == "sim").Count();


if (qntdRespostasPositivas == 2)
{
    Console.WriteLine($"status: SUSPEITA, com participação de {qntdRespostasPositivas} perguntas positivas.");
}
else if (qntdRespostasPositivas >= 3 && qntdRespostasPositivas <= 4)
{
    Console.WriteLine($"status: CÚMPLICE, com participação de {qntdRespostasPositivas} perguntas positivas.");
}
else if (qntdRespostasPositivas == 5)
{
    Console.WriteLine($"status: CULPADA, com participação de {qntdRespostasPositivas} perguntas positivas.");
}
else
{
    Console.WriteLine($"status: INOCENTE, com participação de {qntdRespostasPositivas} perguntas positivas.");
}