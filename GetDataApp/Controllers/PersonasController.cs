using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GetDataApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PersonasController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/<PersonasController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listaPersonas = await _context.Persona.ToListAsync();
                return Ok(listaPersonas);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
