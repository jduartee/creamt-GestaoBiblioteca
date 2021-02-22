using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.AcervoAutor
{
    public class AcervoAutorRemoverCommand: IRequest<string>
    {
        private AcervoAutorRemoverCommand()
        { }

        public AcervoAutorRemoverCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }

    }
}
