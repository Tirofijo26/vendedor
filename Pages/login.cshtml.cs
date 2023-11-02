using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vendedor.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public LoginInputModel Input { get; set; }

        public void OnGet()
        {
            Input = new LoginInputModel();
        }
    }

    public class LoginInputModel
    {
        [Display(Name = "Nombre de usuario")]
        [Required]
        public string? Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
