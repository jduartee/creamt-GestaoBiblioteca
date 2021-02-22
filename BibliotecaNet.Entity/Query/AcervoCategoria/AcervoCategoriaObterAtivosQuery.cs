using BibliotecaNet.Domain.ValueObject.AcervoCategoria;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.AcervoCategoria
{
    public class AcervoCategoriaObterAtivosQuery : IRequest<IList<AcervoCategoriaVO>>
    {
    }
}
