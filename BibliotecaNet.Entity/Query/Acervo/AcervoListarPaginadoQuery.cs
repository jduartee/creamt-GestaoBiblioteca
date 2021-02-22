using BibliotecaNet.Domain.ValueObject.Acervo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Acervo
{
    public class AcervoListarPaginadoQuery : IRequest<IList<AcervoVO>>
    {
    }
}
