int senhaValida = 1234; // Senha válida

// Recebe a senha inserida
Console.Write("Insira a senha: ");
int senha = int.Parse(Console.ReadLine());

// Testa se a senha inserida e a mesma que a senha Valida
// if (senha == senhaValida)
//     Console.WriteLine("ACESSO PERMITIDO");
// else
// {
//     Console.WriteLine("ACESSO NEGADO");
// }

string acessoRetornoMsg = (senha == senhaValida) ? "ACESSO PERMITIDO" : "ACESSO NEGADO";
