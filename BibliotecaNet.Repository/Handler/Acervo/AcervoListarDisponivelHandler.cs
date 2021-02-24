using BibliotecaNet.Domain.Query.Acervo;
using BibliotecaNet.Domain.ValueObject;
using BibliotecaNet.Domain.ValueObject.Acervo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoListarDisponivelHandler : IRequestHandler<AcervoListarDisponivelQuery, RequestSelectVO>
    {
        private readonly IApplicationDbContext _context;

        public AcervoListarDisponivelHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RequestSelectVO> Handle(AcervoListarDisponivelQuery request, CancellationToken cancellationToken)
        {
            var sql = $"SELECT * FROM [CREAMT].[DBO].[ACERVOS] WHERE titulo like '%{request.Titulo}%' and ACERVOID NOT IN (SELECT ACERVOID FROM [CREAMT].[DBO].[ACERVOMOVIMENTACAOS] WHERE DATADEVOLUCAO IS NULL)";

            var acervos = await _context.Acervos.FromSqlRaw(sql).ToListAsync();
            return new RequestSelectVO { results =  acervos.Select(x => new SelectResult { id = x.AcervoId, text =  x.Titulo}).ToList() };
        }
    }
}
