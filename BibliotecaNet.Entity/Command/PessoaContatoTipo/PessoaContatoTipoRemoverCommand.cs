using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaContatoTipo
{
    public class PessoaContatoTipoRemoverCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaContatoTipoRemoverCommand()
        {
        }

        public PessoaContatoTipoRemoverCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
