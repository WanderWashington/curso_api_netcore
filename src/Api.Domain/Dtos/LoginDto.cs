using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "E-mail é um campo obrigatório para o Login")] //obrigatorio.
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]//valida o e-mail.
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} caracteres.")]//valida o tamanho.
        public string Email { get; set; }
    }
}
