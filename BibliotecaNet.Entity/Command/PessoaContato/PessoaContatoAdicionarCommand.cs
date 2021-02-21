using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaContato
{
    public class PessoaContatoAdicionarCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaContatoAdicionarCommand()
        { }

        public PessoaContatoAdicionarCommand(int documentoTipoId, string valor, IMapper mapper)
        {
            PessoaContatoTipoId = documentoTipoId;
            Valor = valor;
            _mapper = mapper;
        }

        public int PessoaContatoTipoId { get; private set; }
        public string Valor { get; private set; }

        public Entity.PessoaContato Command()
            => _mapper.Map<Entity.PessoaContato>(this);
    }
}
