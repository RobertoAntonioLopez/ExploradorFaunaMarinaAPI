using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExploradorFaunaMarinaAPI.Data;
using ExploradorFaunaMarinaAPI.Models;

namespace ExploradorFaunaMarinaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspeciesController : ControllerBase
    {
        private readonly MarinaContext _context;

        public EspeciesController(MarinaContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspecieMarina>>> GetEspecies()
        {
            return await _context.EspeciesMarinas.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<EspecieMarina>> GetEspecie(int id)
        {
            var especie = await _context.EspeciesMarinas.FindAsync(id);

            if (especie == null)
                return NotFound();

            return especie;
        }

        
        [HttpPost]
        public async Task<ActionResult<EspecieMarina>> PostEspecie(EspecieMarina especie)
        {
            _context.EspeciesMarinas.Add(especie);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEspecie), new { id = especie.Id }, especie);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecie(int id, EspecieMarina especie)
        {
            if (id != especie.Id)
                return BadRequest();

            _context.Entry(especie).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspecie(int id)
        {
            var especie = await _context.EspeciesMarinas.FindAsync(id);
            if (especie == null)
                return NotFound();

            _context.EspeciesMarinas.Remove(especie);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}