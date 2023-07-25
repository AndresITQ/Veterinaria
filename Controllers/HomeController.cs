using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Servicios;
using System.Diagnostics;

namespace Veterinaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //creamos una instancia de la clase repositorioProyectos
            var repositorioProyectos = new RepositoriosProyectos();
            //creamos una variable llamada proyectos para obtener los proyectos
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            //Creamos el modelo
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };

            return View(modelo);
        }


        //Vamos a crear la accion para llamar a la lista proyectos
        public IActionResult Proyectos()
        {
            //creamos una instancia de la clase repositorio proyecto
            var repositorioProyectos = new RepositoriosProyectos();
            //creamos una variable llamada rpoyectos para obtener toda la data de nuestra clase Repositorio Proyectosk
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        //creamos la accion para ir a contacto
        public IActionResult Contacto()
        {
            return View();
        }

        //Colocamos un atributo en el cual le decimos que tipo de peticion estamos enviando
        [HttpPost]
        //creamos una accion para la peticion, y recordamos los datos que vamos a recibir

        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            return RedirectToAction("Gracias");
        }
        //creamos una accion para redirecicionar despues de enviar los datos del formulario
        public IActionResult Gracias()
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