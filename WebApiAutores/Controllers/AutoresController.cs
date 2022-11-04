using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Modelos;

namespace WebApiAutores.Controllers
{
    [ApiController]         // Esto permitira hacer validaciones 
    [Route("api/autores")]  // Aqui se define la ruta
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>()
            {
                new Autor() { id = 1, nombre = "Felipe" },
                new Autor() { id = 2, nombre = "Mariano" }
            };
        }
    }
}
