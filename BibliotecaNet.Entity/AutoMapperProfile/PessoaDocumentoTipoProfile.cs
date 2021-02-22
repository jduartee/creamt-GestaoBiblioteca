using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.AutoMapperProfile
{
    public class PessoaDocumentoTipoProfile : Profile
    {
        public PessoaDocumentoTipoProfile()
        {
            CreateMap<Command.PessoaDocumentoTipo.PessoaDocumentoTipoAdicionarCommand, Entity.PessoaDocumentoTipo>();
        }
    }
}
