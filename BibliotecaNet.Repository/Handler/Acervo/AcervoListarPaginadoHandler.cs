using BibliotecaNet.Common;
using BibliotecaNet.Domain.Query.Acervo;
using BibliotecaNet.Domain.ValueObject.Acervo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoListarPaginadoHandler : IRequestHandler<AcervoListarPaginadoQuery, PaginatedList<AcervoVO>>
    {
        private readonly IApplicationDbContext _context;

        public AcervoListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<AcervoVO>> Handle(AcervoListarPaginadoQuery request, CancellationToken cancellationToken)
        {
            //var sql = "SELECT * FROM [CREAMT].[DBO].[ACERVOS] WHERE ACERVOID NOT IN (SELECT ACERVOID FROM [CREAMT].[DBO].[ACERVOMOVIMENTACAOS] WHERE DATADEVOLUCAO IS NULL)";
            //var acervos = _context.Acervos.FromSqlRaw(sql).Select(x => new AcervoVO { });

            var query = (from t0 in _context.Acervos
                         join t1 in _context.AcervoAutors on t0.AcervoAutor.AcervoAutorId equals t1.AcervoAutorId
                         join t2 in _context.Pessoas on t1.Pessoa.PessoaId equals t2.PessoaId
                         join t3 in _context.AcervoCategorias on t0.AcervoCategoria.AcervoCategoriaId equals t3.AcervoCategoriaId
                         join t4 in _context.AcervoEditoras on t0.AcervoEditora.AcervoEditoraId equals t4.AcervoEditoraId
                         join t5 in _context.AcervoSituacaos on t0.AcervoSituacao.AcervoSituacaoId equals t5.AcervoSituacaoId
                         where t0.Titulo.Contains(request.Titulo)
                         select new AcervoVO
                         {
                             Id = t0.AcervoId,
                             Ano = t0.Ano,
                             Edicao = t0.Edicao,
                             Titulo = t0.Titulo,
                             Autor = t2.Nome,
                             Categoria = t3.Descricao,
                             Editora = t4.Nome,
                             Situacao = t5.Descricao
                         });

            return await PaginatedList<AcervoVO>.CreateAsync(query, request.OffSet, request.Limit);
        }
    }
}
