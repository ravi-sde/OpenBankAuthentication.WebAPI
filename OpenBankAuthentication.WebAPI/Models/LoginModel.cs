using System.ComponentModel.DataAnnotations;

namespace OpenBankAuthentication.WebAPI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "UserName is required!")]
        public string UserName { get; set;}
        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set;}
    }
}
