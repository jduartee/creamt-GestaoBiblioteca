using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaDocumentoTipo
{
    public class PessoaDocumentoTipoAdicionarCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        public PessoaDocumentoTipoAdicionarCommand(string descricao, string mascara, bool obrigatorio, bool ativo, IMapper mapper)
        {
            Descricao = descricao;
            Mascara = mascara;
            Obrigatorio = obrigatorio;
            Ativo = ativo;
            _mapper = mapper;
        }

        private PessoaDocumentoTipoAdicionarCommand()
        {

        }

        public string Descricao { get; set; }
        public string Mascara { get; set; }
        public bool Obrigatorio { get; set; }
        public bool Ativo { get; set; }

        public Entity.PessoaDocumentoTipo Command()
            => _mapper.Map<Entity.PessoaDocumentoTipo>(this);
    }
}
