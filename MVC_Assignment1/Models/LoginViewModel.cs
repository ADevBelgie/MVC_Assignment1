using System.ComponentModel.DataAnnotations;


namespace MVC_Assignment1.Models
{
    public class LoginViewModel
    {
        [Key]
        public int LoginId { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
        public string Role { get; set; }
    }

}
