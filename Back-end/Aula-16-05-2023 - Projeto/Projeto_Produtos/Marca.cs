namespace Projeto_Produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string? NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now.Date;

        public string Cadastrar(Marca _marca)
        {
            
            
            return "";
        }

        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            return lista; 
        }

        public string Deletar(Marca _marca)
        {
            return "";
        }

    }
}