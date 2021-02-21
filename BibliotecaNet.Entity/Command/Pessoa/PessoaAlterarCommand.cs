using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.Pessoa
{
    public class PessoaAlterarCommand : IRequest<string>
    {
        public int Id { get; private set; }
    }
}
