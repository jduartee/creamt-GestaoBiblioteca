using MediatR;
using System;

namespace BibliotecaNet.Domain.Command.Usuario
{
    public class UsuarioCadastrarCommand : IRequest<string>
    {
        public UsuarioCadastrarCommand(string email, string password, string nome)
        {
            Email = email;
            Password = password;
            Nome = nome;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Nome { get; private set; }


        public Entity.Usuario Command()
        {
            return new Entity.Usuario
            {
                Email = Email,
                UserName = Email,
                EmailConfirmed = true,
                Pessoa = new Entity.Pessoa
                {
                    Nome = Nome
                }
            };
        }
    }
}
