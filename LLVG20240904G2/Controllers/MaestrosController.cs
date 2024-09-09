using LLVG20240904G2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LLVG20240904G2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaestrosController : ControllerBase
    {

        static List<Maestro> maestros = new List<Maestro>();
        // GET: api/<MaestrosController>
    
         

        // GET api/<MaestrosController>/5
        [HttpGet("{id}")]
        public ActionResult<Maestro> Get(int id)
        {
            // Busca un maestro en la lista por su ID
            var maestro = maestros.FirstOrDefault(m => m.Id == id);
            if (maestro != null)
            {
                return Ok(maestro); // Devuelve el maestro encontrado
            }
            else
            {
                return NotFound(); // Devuelve NotFound si el maestro no existe
            }
        }

        // POST api/<MaestrosController>
        [HttpPost]
        public IActionResult Post([FromBody] Maestro maestro)
        {
            // Añade un nuevo maestro a la lista
            maestros.Add(maestro);
            // Devuelve una respuesta OK
            return Ok();

        } 
    }
}
