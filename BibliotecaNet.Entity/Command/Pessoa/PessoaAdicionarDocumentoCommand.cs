using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.Pessoa
{
    public class PessoaAdicionarDocumentoCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaAdicionarDocumentoCommand()
        { }

        public PessoaAdicionarDocumentoCommand(int documentoTipoId, string valor, IMapper mapper)
        {
            PessoaDocumentoTipoId = documentoTipoId;
            Valor = valor;
            _mapper = mapper;
        }

        public int PessoaDocumentoTipoId { get; private set; }
        public string Valor { get; private set; }

        public Entity.PessoaDocumento Command()
            => _mapper.Map<Entity.PessoaDocumento>(this);
    }
}
