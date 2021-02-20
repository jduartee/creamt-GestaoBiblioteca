using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Entity;
using BibliotecaNet.Domain.ValueObject.Pessoa;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleTeste
{
    class Program
    {

        private static IMapper _mapper;




        static void Main(string[] args)
        {

            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.CreateMap<PessoaCadastrarCommand, Pessoa>()
                    .ForMember(x=> x.PessoaTipo, opt=> opt.MapFrom(src => src.PessoaTipoId))
                    .ForMember(x=> x.PessoaDocumentos, opt => opt.MapFrom(src=> src.PessoaDocumentos));
                    ;
                });

                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            var pessoaCadastroCommand = new PessoaCadastrarCommand("teste", 1, _mapper);
            //pessoaCadastroCommand.AdicionarContato(1, "(65) 98175-0406");

            var command = pessoaCadastroCommand.Command();
        }
    }
}
