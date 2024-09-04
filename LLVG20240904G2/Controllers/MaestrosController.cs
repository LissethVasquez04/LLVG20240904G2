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
        [HttpGet]
        public IEnumerable<Maestro> Get()
        {
            // Devuelve la lista completa de maestros
            return maestros;
        }

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

        // PUT api/<MaestrosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Maestro maestro)
        {// Busca el maestro existente por su ID
            var existingMaestro = maestros.FirstOrDefault(m => m.Id == id);
            if (existingMaestro != null)
            {
                // Actualiza los datos del maestro existente
                existingMaestro.Nombre = maestro.Nombre;
                existingMaestro.Apellido = maestro.Apellido;
                existingMaestro.Especialidad = maestro.Especialidad;
                existingMaestro.NumeroEmpleado = maestro.NumeroEmpleado;
                // Devuelve una respuesta OK
                return Ok();
            }
            else
            {
                // Devuelve NotFound si el maestro no existe
                return NotFound();
            }
        }

        // DELETE api/<MaestrosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Busca el maestro existente por su ID
            var existingMaestro = maestros.FirstOrDefault(m => m.Id == id);
            if (existingMaestro != null)
            {
                // Elimina el maestro de la lista
                maestros.Remove(existingMaestro);
                // Devuelve una respuesta OK
                return Ok();
            }
            else
            {
                // Devuelve NotFound si el maestro no existe
                return NotFound();
            }
        }
    }
}
