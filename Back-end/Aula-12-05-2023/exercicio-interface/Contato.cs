namespace exercicio_interface
{
    public abstract class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato() { }

        public Contato(string _nome, string _telefone, string _email)
        {
            Nome = _nome;
            Telefone = _telefone;
            Email = _email;
        }
    }
}