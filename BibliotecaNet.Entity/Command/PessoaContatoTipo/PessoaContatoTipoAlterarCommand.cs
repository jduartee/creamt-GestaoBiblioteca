using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaContatoTipo
{
    public class PessoaContatoTipoAlterarCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaContatoTipoAlterarCommand()
        {
        }

        public PessoaContatoTipoAlterarCommand(int id)
        {
            Id = id;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void AlterarMascara(string mascara)
        {
            Mascara = mascara;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public string Mascara { get; private set; }

        public Entity.PessoaContatoTipo Command()
            => _mapper.Map<Entity.PessoaContatoTipo>(this);
    }
}
