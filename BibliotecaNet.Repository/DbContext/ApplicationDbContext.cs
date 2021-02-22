using BibliotecaNet.Domain.Entity;
using BibliotecaNet.Repository.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<Usuario, Role, int>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Acervo> Acervos { get; set; }
        public DbSet<AcervoAutor> AcervoAutors { get; set; }
        public DbSet<AcervoCategoria> AcervoCategorias { get; set; }
        public DbSet<AcervoEditora> AcervoEditoras { get; set; }
        public DbSet<AcervoMovimentacao> AcervoMovimentacaos { get; set; }
        public DbSet<AcervoSituacao> AcervoSituacaos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaContato> PessoaContatos { get; set; }
        public DbSet<PessoaContatoTipo> PessoaContatoTipos { get; set; }
        public DbSet<PessoaDocumento> PessoaDocumentos { get; set; }
        public DbSet<PessoaDocumentoTipo> PessoaDocumentoTipos { get; set; }
        public DbSet<PessoaEndereco> PessoaEnderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public async Task<int> SaveChangesAsync()
            => await base.SaveChangesAsync();        

        void IApplicationDbContext.OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                  .SelectMany(e => e.GetProperties()
                      .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            //decimal(18,2) default para decimal
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                  .SelectMany(e => e.GetProperties()
                      .Where(p => p.ClrType == typeof(decimal))))
            {
                property.SetColumnType("decimal(18,2)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //impedir delete cascade no banco
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
