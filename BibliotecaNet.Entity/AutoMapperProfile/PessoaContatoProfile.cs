using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Entity;

namespace BibliotecaNet.Domain.AutoMapperProfile
{
    public class PessoaContatoProfile : Profile
    {
        public PessoaContatoProfile()
        {
            CreateMap<Command.PessoaContato.PessoaContatoAdicionarCommand, PessoaContato>();
        }
    }
}
