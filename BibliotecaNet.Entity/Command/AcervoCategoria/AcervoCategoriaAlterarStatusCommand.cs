using BibliotecaNet.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command
{
    public class AcervoCategoriaAlterarStatusCommand : IRequest<string>
    {
        private AcervoCategoriaAlterarStatusCommand()
        {

        }

        public AcervoCategoriaAlterarStatusCommand(int id, bool ativo)
        {
            Id = id;
            Ativo = ativo;
        }

        public int Id { get; private set; }
        public bool Ativo { get; private set; }

        public AcervoCategoria Command() => new AcervoCategoria { CategoriaId = Id, Ativo = Ativo };
    }
}
