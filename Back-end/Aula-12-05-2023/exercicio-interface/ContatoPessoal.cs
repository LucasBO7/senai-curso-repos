using exercicio_interface.Interfaces;

namespace exercicio_interface
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public string ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}