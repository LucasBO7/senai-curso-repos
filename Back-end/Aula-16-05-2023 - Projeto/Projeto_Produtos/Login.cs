using Projeto_Produtos;

namespace Projeto_Produtos
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario usuario = new Usuario();
            Produto novoProduto = new Produto();
            Marca marca = new Marca();
            Logar(usuario);

            string menuOpcaoSelcionada;
            do
            {


                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
 ___________________________________
|               MENU                |
|                                   |
| Produto                           |
| [1] Adicionar Produto             |
| [2] Remover Produto               |
| [3] Listar Produto                |
|                                   |
| Marca                             |
| [4] Adicionar Marca               |
| [5] Remover Marca                 |
| [6] Listar Marcas                 |
|                                   |
| [0] Sair                          |
|___________________________________|
");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Insira a opção que deseja acessar: ");
                    menuOpcaoSelcionada = Console.ReadLine()!.ToLower();
                    Console.ResetColor();

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    if (menuOpcaoSelcionada != "1" && menuOpcaoSelcionada != "2" && menuOpcaoSelcionada != "3" && menuOpcaoSelcionada != "4" && menuOpcaoSelcionada != "5" && menuOpcaoSelcionada != "6" && menuOpcaoSelcionada != "0")
                    {
                        Console.WriteLine($"OPÇÃO INVÁLIDA! selecione uma das opções escritas!");
                    }
                    Console.ResetColor();

                } while (menuOpcaoSelcionada != "1" && menuOpcaoSelcionada != "2" && menuOpcaoSelcionada != "3" && menuOpcaoSelcionada != "4" && menuOpcaoSelcionada != "5" && menuOpcaoSelcionada != "6" && menuOpcaoSelcionada != "0");


                switch (menuOpcaoSelcionada)
                {
                    case "1":
                        novoProduto.Cadastrar(marca, usuario);
                        break;

                    case "2":
                        Console.Write($"Insira o código do produto a ser deletado: ");
                        int codigoProdutoDeletar = int.Parse(Console.ReadLine()!);
                        novoProduto.Deletar(codigoProdutoDeletar);
                        break;

                    case "3":
                        novoProduto.Listar();
                        break;

                    case "4":
                        marca.Cadastrar();
                        break;

                    case "5":
                        Console.Write($"Insira o código do produto a ser deletado: ");
                        int codigoMarca = int.Parse(Console.ReadLine()!);
                        marca.Deletar(codigoMarca);
                        break;

                    case "6":
                        marca.Listar();
                        break;

                    default:
                        break;
                }

            } while (menuOpcaoSelcionada != "0");

        }


        public string Logar(Usuario _usuario)
        {
            Usuario usuarioSalvo = new Usuario()
            {
                Email = "nb@gmail.com",
                Senha = "nbcz"
            };
            string email;
            string senha;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"

___________ LOGIN ___________
|");
                Console.Write($"| Email: ");
                email = Console.ReadLine()!;

                Console.Write($"| Senha: ");
                senha = Console.ReadLine()!;
                Console.WriteLine($"|____________________________");

                if (email != usuarioSalvo.Email || senha != usuarioSalvo.Senha)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Falha ao logar - Email ou Senha incorreto!");
                    Console.ResetColor();
                }

            } while (email != usuarioSalvo.Email || senha != usuarioSalvo.Senha);

            _usuario = new Usuario()
            {
                Email = email,
                Senha = senha
            };

            Logado = true;
            Console.Clear();
            Console.WriteLine($"Login realizado com sucesso!");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
            return "";
        }

        public string Deslogar(Usuario _usuario)
        {
            if (Logado == true)
            {
                Logado = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Deslogado com sucesso!");
                Console.ResetColor();
            }
            return "";
        }
    }
}