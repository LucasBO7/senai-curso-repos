namespace Projeto_Produtos
{
    public class Usuario
    {
        public int Codigo { get; set; } = 110;
        public string? Nome { get; set; } = "nb";
        public string? Email { get; set; } = "nb@gmail.com";
        public string? Senha { get; set; } = "nbcz";
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public Usuario()
        {
            
        }


        public void Listar()
        {

        }

        public void Cadastrar(Usuario _usuario)
        {
            Console.WriteLine($"___________ CADASTRO USUÁRIO ___________");
            Console.Write($"Código: ");
            _usuario.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write($"Nome do usuário: ");
            _usuario.Nome = Console.ReadLine()!;

            Console.Write($"Email: ");
            _usuario.Email = Console.ReadLine()!;

            Console.Write($"Senha: ");
            _usuario.Senha = Console.ReadLine()!;

            // Usuarios.Add(_usuario);

            // Se HOUVER ALGUM usuário com código. email e senha iguais...
            // if (Usuarios.Any(user => user.Codigo == _usuario.Codigo || user.Email == _usuario.Email && user.Senha == _usuario.Senha))
            // {

            // }

        }

        public void Deletar(Usuario _usuario)
        {

        }
    }
}