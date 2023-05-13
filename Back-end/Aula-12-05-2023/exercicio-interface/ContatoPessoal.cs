using exercicio_interface.Interfaces;

namespace exercicio_interface
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public ContatoPessoal() { }

        public ContatoPessoal(string _nome, string _telefone, string _email, string _cpf)
        {
            Nome = _nome;
            Telefone = _telefone;
            Email = _email;
            Cpf = _cpf;
        }


        public string ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}