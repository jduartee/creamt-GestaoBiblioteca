﻿using BibliotecaNet.Domain.Query.AcervoMovimentacao;
using BibliotecaNet.Domain.ValueObject.AcervoMovimentacao;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoMovimentacaoListarPaginada : IRequestHandler<AcervoMovimentacaoListarPaginadaQuery, IList<AcervoMovimentacaoVO>>
    {
        private readonly IApplicationDbContext _context;

        public AcervoMovimentacaoListarPaginada(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AcervoMovimentacaoVO>> Handle(AcervoMovimentacaoListarPaginadaQuery request, CancellationToken cancellationToken)
        {
            return await (from t0 in _context.AcervoMovimentacaos
                                      join t1 in _context.Acervos on t0.Acervo.AcervoId equals t1.AcervoId
                                      join t2 in _context.Pessoas on t0.Pessoa.PessoaId equals t2.PessoaId
                                      join t3 in _context.Usuarios on t0.Usuario.Id equals t3.Id
                                      join t4 in _context.Pessoas on t3.Pessoa.PessoaId equals t4.PessoaId
                                      select new AcervoMovimentacaoVO
                                      {
                                          Id = t0.AcervoMovimentacaoId,
                                          Acervo = t1.Titulo,
                                          Pessoa = t2.Nome,
                                          Usuario = t4.Nome,

                                      }).ToListAsync();

        }
    }
}
