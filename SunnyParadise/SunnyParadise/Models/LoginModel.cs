using System.ComponentModel.DataAnnotations;

namespace SunnyParadise.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Login not found")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Password not found")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
