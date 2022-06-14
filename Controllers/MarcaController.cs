using Microsoft.AspNetCore.Mvc;
using Ventas.Models;

namespace Ventas.Controllers
{
    public class MarcaController : Controller
    {
        private readonly ventasContext _contex;

        public MarcaController(ventasContext context)
        {
            _contex = context;

        }

        public IActionResult Index()
        {
            // _contex.Modelos.ToList() = Select * FROM Modelo;            
            return View(_contex.Modelos.ToList());
        } 
        
        public IActionResult FormMarca()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarMarca(Modelo mod)
        {
            _contex.Modelos.Add(mod);
            _contex.SaveChanges();
            return RedirectToAction("Index", "Marca");
        }

        public IActionResult Eliminar(int Id)
        {
            Modelo modeloBd = _contex.Modelos.Find(Id); // SELECT * FROM Modelo WHERE ID = Id;
            if(modeloBd.Id.Equals(null))
            {
                return RedirectToAction("Index", "Marca");
            }
            _contex.Modelos.Remove(modeloBd);
            _contex.SaveChanges();
            return RedirectToAction("Index", "Marca");
        }
    }
}
