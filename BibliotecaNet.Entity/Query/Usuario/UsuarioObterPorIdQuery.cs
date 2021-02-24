using BibliotecaNet.Domain.ValueObject.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Usuario
{
    public class UsuarioObterPorIdQuery : IRequest<UsuarioVO>
    {
        public UsuarioObterPorIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
