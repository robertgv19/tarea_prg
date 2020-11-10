using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRG___WEBAPP.Models;

namespace PRG___WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Producto()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Producto(string nombre, string precio, string descripcion)
        {
            // TODO: hacer algo con los parametros nombre, apellido, distrito y correo.
            return RedirectToAction("ProductoConfirmacion");
        }
         public IActionResult ProductoConfirmacion()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
