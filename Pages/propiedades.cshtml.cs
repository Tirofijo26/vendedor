using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vendedor.Models;
using Vendedor.Services;

namespace Vendedor.Pages
{
    public class PropiedadesModel : PageModel
    {
        public List<Propiedades> Propiedades = new();
        public IActionResult OnPost()
        {
            return new RedirectToPageResult("DatosCliente");
        }
        public void OnGet()
        {
            Propiedades = PropiedadesService.GetAll();
        }
    }
}
