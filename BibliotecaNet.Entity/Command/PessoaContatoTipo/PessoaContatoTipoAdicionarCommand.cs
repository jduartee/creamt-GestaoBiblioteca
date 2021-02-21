using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaContatoTipo
{
    public class PessoaContatoTipoAdicionarCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaContatoTipoAdicionarCommand()
        {
        }

        public PessoaContatoTipoAdicionarCommand(string descricao, string mascara, bool obrigatorio, bool ativo, IMapper mapper)
        {
            Descricao = descricao;
            Mascara = mascara;
            Obrigatorio = obrigatorio;
            Ativo = ativo;
            _mapper = mapper;
        }

        public string Descricao { get; private set; }
        public string Mascara { get; private set; }
        public bool Obrigatorio { get; private set; }
        public bool Ativo { get; private set; }

        public Entity.PessoaContatoTipo Command()
            => _mapper.Map<Entity.PessoaContatoTipo>(this);
    }
}
