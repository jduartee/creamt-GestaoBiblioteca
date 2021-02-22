﻿using BibliotecaNet.Domain.Query.Acervo;
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
    public class AcervoListarPaginadoHandler : IRequestHandler<AcervoListarPaginadoQuery, IList<AcervoVO>>
    {
        private readonly IApplicationDbContext _context;

        public AcervoListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AcervoVO>> Handle(AcervoListarPaginadoQuery request, CancellationToken cancellationToken)
        {
            var sql = "SELECT * FROM [CREAMT].[DBO].[ACERVOS] WHERE ACERVOID NOT IN (SELECT ACERVOID FROM [CREAMT].[DBO].[ACERVOMOVIMENTACAOS] WHERE DATADEVOLUCAO IS NULL)";

            var acervos = await _context.Acervos.FromSqlRaw(sql).ToListAsync();
            return acervos.Select(x => new AcervoVO { }).ToList();
        }
    }
}
