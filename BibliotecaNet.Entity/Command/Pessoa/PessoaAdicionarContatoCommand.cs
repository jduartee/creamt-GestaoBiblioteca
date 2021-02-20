using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.Pessoa
{
    public class PessoaAdicionarContatoCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaAdicionarContatoCommand()
        { }

        public PessoaAdicionarContatoCommand(int documentoTipoId, string valor, IMapper mapper)
        {
            PessoaContatoTipoId = documentoTipoId;
            Valor = valor;
            _mapper = mapper;
        }

        public int PessoaContatoTipoId { get; set; }
        public string Valor { get; set; }

        public Entity.PessoaContato Command()
            => _mapper.Map<Entity.PessoaContato>(this);
    }
}
