using BibliotecaNet.Domain.ValueObject.PessoaDocumentoTipo;
using MediatR;
using System.Collections.Generic;

namespace BibliotecaNet.Domain.Query.PessoaDocumentoTipo
{
    public class PessoaDocumentoTipoListarAtivoQuery : IRequest<IList<PessoaDocumentoTipoVO>>
    {
    }
}
