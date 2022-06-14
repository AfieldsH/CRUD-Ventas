using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventas.Models;

namespace Ventas.Controllers
{
    public class AutoController : Controller
    {
        private readonly ventasContext _contex;

        public AutoController(ventasContext contex)
        {
            _contex = contex;
        }

        public IActionResult Index()
        {
            return View(_contex.Autos.Include(m => m.IdMarcaNavigation).ToList());
        }
    }
}
