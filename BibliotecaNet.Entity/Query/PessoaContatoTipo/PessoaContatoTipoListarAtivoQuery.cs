using BibliotecaNet.Domain.ValueObject.PessoaContatoTipo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.PessoaContatoTipo
{
    public class PessoaContatoTipoListarAtivoQuery:IRequest<IList<PessoaContatoTipoVO>>
    {
    }
}
