using System.ComponentModel.DataAnnotations;

namespace EventEase
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = "";
    }
}
