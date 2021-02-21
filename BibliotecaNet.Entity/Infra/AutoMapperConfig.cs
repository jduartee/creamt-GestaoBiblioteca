using AutoMapper;
using BibliotecaNet.Domain.AutoMapperProfile;

namespace BibliotecaNet.Domain.Infra
{
    public class AutoMapperConfig
    {
        public MapperConfiguration AutoMapperConfiguration()
                => new MapperConfiguration(config =>
                    {
                        config.AddProfile<PessoaProfile>();
                        config.AddProfile<PessoaContatoProfile>();
                        config.AddProfile<PessoaContatoTipoProfile>();
                    });

    }
}
