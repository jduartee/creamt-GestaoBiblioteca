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

        public PessoaDocumentoTipoAdicionarCommand(int descricao, int mascara, bool obrigatorio, bool ativo, IMapper mapper)
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

        public int Descricao { get; set; }
        public int Mascara { get; set; }
        public bool Obrigatorio { get; set; }
        public bool Ativo { get; set; }

        public Entity.PessoaDocumentoTipo Command()
            => _mapper.Map<Entity.PessoaDocumentoTipo>(this);
    }
}
