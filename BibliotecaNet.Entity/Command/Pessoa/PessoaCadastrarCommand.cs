using AutoMapper;
using BibliotecaNet.Domain.ValueObject.Pessoa;
using MediatR;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaNet.Domain.Command.Pessoa
{
    public class PessoaCadastrarCommand : IRequest<int>
    {
        private readonly IMapper _mapper;

        private PessoaCadastrarCommand()
        { }

        public PessoaCadastrarCommand(string nome, int pessoaTipoId, IMapper mapper)
        {
            Nome = nome;
            PessoaTipoId = pessoaTipoId;
            PessoaDocumentos = new List<PessoaDocumentoVO>();
            PessoaEnderecos = new List<PessoaEnderecoVO>();
            PessoaContatos = new List<PessoaContatoVO>();

            _mapper = mapper;
        }

        public string Nome { get; private set; }
        public int PessoaTipoId { get; private set; }
        public IList<PessoaDocumentoVO> PessoaDocumentos { get; private set; }
        public IList<PessoaEnderecoVO> PessoaEnderecos { get; private set; }
        public IList<PessoaContatoVO> PessoaContatos { get; private set; }

        public void AdicionarDocumento(int pessoaDocumentoTipoId, string valor)
        {
            PessoaDocumentos.Add(new PessoaDocumentoVO { PessoaDocumentoTipoId = pessoaDocumentoTipoId, Valor = valor });
        }

        public void AdicionarEndereco(string cep, string cidade, string estado, string bairro, string logradouro, string numero, string complemento, bool principal)
        {
            PessoaEnderecos.Add(new PessoaEnderecoVO { Cep = cep, Cidade = cidade, Estado = estado, Bairro = bairro, Logradouro = logradouro, Numero = numero, Complemento = complemento, Principal = principal });
        }

        public void AdicionarContato(int pessoaContatoTipoId, string valor)
        {
            PessoaContatos.Add(new PessoaContatoVO { PessoaContatoTipoId = pessoaContatoTipoId, Valor = valor });
        }

        public Entity.Pessoa Command()
        {
            var pessoa = new Entity.Pessoa
            {
                Nome = Nome,
                //PessoaTipo = new Entity.PessoaTipo { PessoaTipoId = (Common.PessoaTipoEnum)PessoaTipoId },
                Ativo = true
            };

            if (PessoaDocumentos.Count > 0)
                pessoa.PessoaDocumentos = PessoaDocumentos.Select(x => new Entity.PessoaDocumento { PessoaDocumentoId = x.PessoaDocumentoTipoId, Valor = x.Valor }).ToList();

            if (PessoaContatos.Count > 0)
                pessoa.PessoaContatos = PessoaContatos.Select(x => new Entity.PessoaContato { PessoaContatoId = x.PessoaContatoTipoId, Valor = x.Valor }).ToList();

            if (PessoaEnderecos.Count > 0)
                pessoa.PessoaEnderecos = PessoaEnderecos.Select(x => new Entity.PessoaEndereco
                { Cep = x.Cep, Cidade = x.Cidade, Estado = x.Estado, Bairro = x.Bairro, Logradouro = x.Logradouro, Numero = x.Numero, Complemento = x.Complemento, Principal = x.Principal }).ToList();

            return pessoa;
        }


    }
}
