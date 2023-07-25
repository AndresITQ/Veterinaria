using Veterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Veterinaria.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        //Creamos una acción para enviar los datos por el método POST
        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            //Creamos una condicion de evaluacion para saber si el campo que estamos enviando
            //datos validos
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}

