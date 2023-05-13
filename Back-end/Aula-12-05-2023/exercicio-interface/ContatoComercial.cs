using exercicio_interface.Interfaces;

namespace exercicio_interface
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj { get; set; }

        // Construtores
        public ContatoComercial() { }
        public ContatoComercial(string _nome, string _telefone, string _email, string _cnpj)
        {
            Nome = _nome;
            Telefone = _telefone;
            Email = _email;
            Cnpj = _cnpj;
        }

        public string ValidarCnpj(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}