using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Entity;

namespace BibliotecaNet.Domain.AutoMapperProfile
{
    public class PessoaContatoTipoProfile : Profile
    {
        public PessoaContatoTipoProfile()
        {
            CreateMap<Command.PessoaContatoTipo.PessoaContatoTipoAdicionarCommand, PessoaContatoTipo>();
        }
    }
}
