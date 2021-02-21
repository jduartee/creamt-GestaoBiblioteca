using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Acervo> Acervos { get; set; }
        DbSet<AcervoAutor> AcervoAutors { get; set; }
        DbSet<AcervoCategoria> AcervoCategorias { get; set; }
        DbSet<AcervoEditora> AcervoEditoras { get; set; }
        DbSet<AcervoMovimentacao> AcervoMovimentacaos { get; set; }
        DbSet<AcervoSituacao> AcervoSituacaos { get; set; }
        DbSet<Pessoa> Pessoas { get; set; }
        DbSet<PessoaContato> PessoaContatos { get; set; }
        DbSet<PessoaContatoTipo> PessoaContatoTipos { get; set; }
        DbSet<PessoaDocumento> PessoaDocumentos { get; set; }
        DbSet<PessoaDocumentoTipo> PessoaDocumentoTipos { get; set; }
        DbSet<PessoaEndereco> PessoaEnderecos { get; set; }
        DbSet<Usuario> Usuarios { get; set; }

        Task<int> SaveChangesAsync();

        void OnModelCreating(ModelBuilder modelBuilder);
    }
}
