using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.PessoaDocumento
{
    public class PessoaDocumentoRemoverCommand : IRequest<string>
    {
        private PessoaDocumentoRemoverCommand()
        { }

        public PessoaDocumentoRemoverCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

    }
}
