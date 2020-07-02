using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(80, MinimumLength =1, ErrorMessage ="Debe ingresar entre 1 a 80 caracteres")]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="Debe ingresar entre 4 a 8 caracteres")]
        public string Password { get; set; }
    }
}