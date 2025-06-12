using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExploradorFaunaMarinaAPI.Data;
using ExploradorFaunaMarinaAPI.Models;

namespace ExploradorFaunaMarinaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipsController : ControllerBase
    {
        private readonly MarinaContext _context;

        public TipsController(MarinaContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipSnorkeling>>> GetTips()
        {
            return await _context.TipsSnorkeling.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<TipSnorkeling>> GetTip(int id)
        {
            var tip = await _context.TipsSnorkeling.FindAsync(id);

            if (tip == null)
                return NotFound();

            return tip;
        }

        
        [HttpPost]
        public async Task<ActionResult<TipSnorkeling>> PostTip(TipSnorkeling tip)
        {
            _context.TipsSnorkeling.Add(tip);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTip), new { id = tip.Id }, tip);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTip(int id, TipSnorkeling tip)
        {
            if (id != tip.Id)
                return BadRequest();

            _context.Entry(tip).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTip(int id)
        {
            var tip = await _context.TipsSnorkeling.FindAsync(id);
            if (tip == null)
                return NotFound();

            _context.TipsSnorkeling.Remove(tip);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
