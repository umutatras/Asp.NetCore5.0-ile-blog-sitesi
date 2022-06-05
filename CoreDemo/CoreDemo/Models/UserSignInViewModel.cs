using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="lütfen adınızı girin")]
        public string username { get; set; }
        [Required(ErrorMessage = "lütfen şifrenizi girin")]

        public string password { get; set; }
    }
}
