using BibliotecaNet.Domain.ValueObject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Usuario
{
    public class UsuarioListarPorNomeQuery : IRequest<RequestSelectVO>
    {
        public UsuarioListarPorNomeQuery(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
