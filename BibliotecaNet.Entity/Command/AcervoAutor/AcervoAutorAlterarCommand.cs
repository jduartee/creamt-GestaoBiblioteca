using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.AcervoAutor
{
    public class AcervoAutorAlterarCommand : IRequest<string>
    {
        private AcervoAutorAlterarCommand()
        { }

        public AcervoAutorAlterarCommand(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
    }
}
