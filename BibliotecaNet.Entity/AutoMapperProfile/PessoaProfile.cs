using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Entity;

namespace BibliotecaNet.Domain.AutoMapperProfile
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<PessoaCadastrarCommand, Pessoa>()
                .ForMember(x => x.PessoaTipo, opt => opt.MapFrom(src => src.PessoaTipoId))
                .ForMember(x => x.PessoaContatos, opt => opt.MapFrom(src => src.PessoaContatos))
                .ForMember(x => x.PessoaDocumentos, opt => opt.MapFrom(src => src.PessoaDocumentos));

            CreateMap<Command.PessoaContato.PessoaContatoAdicionarCommand, PessoaContato>();
            CreateMap<Command.PessoaContatoTipo.PessoaContatoTipoAdicionarCommand, PessoaContatoTipo>();
            CreateMap<Command.PessoaDocumento.PessoaDocumentoAdicionarCommand, PessoaDocumento>();
            CreateMap<Command.PessoaDocumentoTipo.PessoaDocumentoTipoAdicionarCommand, PessoaDocumentoTipo>();
            CreateMap<Command.PessoaEndereco.PessoaEnderecoAdicionarCommand, PessoaEndereco>();
        }
    }
}
