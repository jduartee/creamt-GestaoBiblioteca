using MediatR;
using System;

namespace BibliotecaNet.Domain.Command.Usuario
{
    public class UsuarioCadastrarCommand : IRequest<string>
    {
        public UsuarioCadastrarCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        
        public Entity.Usuario Command()
        {
            return new Entity.Usuario
            {
                Email = Email,
                UserName = Email,
                EmailConfirmed = true
            };
        }
    }
}
