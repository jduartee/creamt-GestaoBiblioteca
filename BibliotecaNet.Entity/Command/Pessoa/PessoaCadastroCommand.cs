using AutoMapper;
using BibliotecaNet.Domain.ValueObject.Pessoa;
using MediatR;
using System.Collections.Generic;

namespace BibliotecaNet.Domain.Command.Pessoa
{
    public class PessoaCadastroCommand : IRequest<int>
    {
        private readonly IMapper _mapper;

        public PessoaCadastroCommand(IMapper mapper)
        { _mapper = mapper; }

        public PessoaCadastroCommand(string nome, int pessoaTipoId, IMapper mapper)
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
            => _mapper.Map<Entity.Pessoa>(this);

    }
}
