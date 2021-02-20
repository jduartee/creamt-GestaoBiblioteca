
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class Usuario : IdentityUser<int>
    {
        public Pessoa Pessoa { get; set; }
    }
}
