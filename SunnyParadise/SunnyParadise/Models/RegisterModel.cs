using DataLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace SunnyParadise.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        [MinLength(5,ErrorMessage = "Password must be longer than 5 symbols")]
        [MaxLength(30,ErrorMessage = "Password must be shorter than 30 symbols")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Passwords are different")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Sex")]
        public Sex Sex { get; set; }

        [Required(ErrorMessage = "Enter BirthDate")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        public int Age { get; set; }
    }
}
