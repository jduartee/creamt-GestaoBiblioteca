using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Usuario
{
    public class UsuarioListarPaginadoQuery : IRequest<PaginatedList<UsuarioVO>>
    {
        public UsuarioListarPaginadoQuery(int offSet, int limit)
        {
            OffSet = offSet;
            Limit = limit;
        }

        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
