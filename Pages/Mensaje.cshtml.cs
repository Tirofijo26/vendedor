using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vendedor.Pages
{
    public class MensajeModel : PageModel
    {

        [BindProperty]
        public int Numero1 { get; set; }

        [BindProperty]
        public int Numero2 { get; set; }

        public int? Resultado { get; set; }

        public void OnGet()
        {
            // Esta es la página de carga inicial
        }

        public IActionResult OnPost()
        {
            Resultado = Numero1 + Numero2;
            return Page();
            // return RedirectToPage("Calcular");
        }

    }
}
