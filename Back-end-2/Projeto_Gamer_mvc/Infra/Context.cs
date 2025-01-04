using Microsoft.EntityFrameworkCore;
using Projeto_Gamer_mvc.Models;

namespace Projeto_Gamer_mvc.Infra
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se NÃO estiver configurado
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-8TTSKB5; initial catalog = projetoGamerDB; User Id = sa; pwd = sa1234; TrustServerCertificate = true;");
            }
        }

        // Referenciar as tabelas do banco
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}