using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.ViewModels.Usuario
{
    public class UsuarioVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter no minimo {2} e no maximo {1} characteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "O campo senha e confirmar semnha não são iguais")]
        public string ConfirmPassword { get; set; }
    }
}
