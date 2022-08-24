using System.ComponentModel.DataAnnotations;

namespace OpenBankAuthentication.WebAPI.Controllers
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User name is required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Eamil is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }
    }
}