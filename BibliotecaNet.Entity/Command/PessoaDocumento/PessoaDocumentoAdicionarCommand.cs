using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaDocumento
{
    public class PessoaDocumentoAdicionarCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaDocumentoAdicionarCommand()
        { }

        public PessoaDocumentoAdicionarCommand(int documentoTipoId, string valor, IMapper mapper)
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
