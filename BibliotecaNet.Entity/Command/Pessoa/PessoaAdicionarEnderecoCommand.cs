using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.Pessoa
{
    public class PessoaAdicionarEnderecoCommand : IRequest<string>
    {
        private readonly IMapper _mapper;

        private PessoaAdicionarEnderecoCommand()
        { }

        public PessoaAdicionarEnderecoCommand(string cep, string cidade, string estado, string bairro, string logradouro, string numero, string complemento, bool principal)
        {
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Principal = principal;
        }

        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Bairro { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public bool Principal { get; private set; }

        public Entity.PessoaEndereco Command()
            => _mapper.Map<Entity.PessoaEndereco>(this);
    }
}
