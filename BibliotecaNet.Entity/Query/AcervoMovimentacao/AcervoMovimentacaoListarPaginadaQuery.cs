using BibliotecaNet.Domain.ValueObject.AcervoMovimentacao;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.AcervoMovimentacao
{
    public class AcervoMovimentacaoListarPaginadaQuery : IRequest<IList<AcervoMovimentacaoVO>>
    { }
}
