using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.AcervoAutor
{
    public class AcervoAutorAdicionarCommand : IRequest<string>
    {
        private AcervoAutorAdicionarCommand()
        { }

        public AcervoAutorAdicionarCommand(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }


        public Entity.AcervoAutor Command()
            => new Entity.AcervoAutor
            {
                Pessoa = new Entity.Pessoa
                {
                    Nome = Nome,
                    PessoaTipo = new Entity.PessoaTipo { PessoaTipoId = Common.PessoaTipoEnum.Outros}
                }
            };
    }
}
