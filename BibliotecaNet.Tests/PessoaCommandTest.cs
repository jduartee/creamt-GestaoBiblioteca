using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Entity;
using System;
using Xunit;

namespace BibliotecaNet.Tests
{
    public class PessoaCommandTest
    {

        private static IMapper _mapper;

        public PessoaCommandTest()
        {
            if(_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.CreateMap<PessoaCadastroCommand, Pessoa>();
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public void CriarPessoaCadastroCommand()
        {

        }
    }
}
