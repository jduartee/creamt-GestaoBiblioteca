using BibliotecaNet.Domain.ValueObject.AcervoCategoria;
using MediatR;
using System.Collections.Generic;

namespace BibliotecaNet.Domain.Command
{
    public class AcervoCategoriaListarAtivoCommand : IRequest<IList<AcervoCategoriaVO>>
    {
    }
}
