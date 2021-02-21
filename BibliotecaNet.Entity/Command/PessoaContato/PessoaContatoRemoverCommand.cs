using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaContato
{
    public class PessoaContatoRemoverCommand : IRequest<string>
    {
        private PessoaContatoRemoverCommand()
        { }

        public PessoaContatoRemoverCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
