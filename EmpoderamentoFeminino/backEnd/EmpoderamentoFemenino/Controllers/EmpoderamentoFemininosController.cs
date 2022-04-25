using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmpoderamentoFemenino.Model;

namespace EmpoderamentoFemenino.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpoderamentoFemininosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmpoderamentoFemininosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/EmpoderamentoFemininos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpoderamentoFeminino>>> GetEmpoderamentoFeminino()
        {
            return await _context.EmpoderamentoFeminino.ToListAsync();
        }

        // GET: api/EmpoderamentoFemininos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpoderamentoFeminino>> GetEmpoderamentoFeminino(int id)
        {
            var empoderamentoFeminino = await _context.EmpoderamentoFeminino.FindAsync(id);

            if (empoderamentoFeminino == null)
            {
                return NotFound();
            }

            return empoderamentoFeminino;
        }

        // PUT: api/EmpoderamentoFemininos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpoderamentoFeminino(int id, EmpoderamentoFeminino empoderamentoFeminino)
        {
            if (id != empoderamentoFeminino.Id)
            {
                return BadRequest();
            }

            _context.Entry(empoderamentoFeminino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpoderamentoFemininoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmpoderamentoFemininos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpoderamentoFeminino>> PostEmpoderamentoFeminino(EmpoderamentoFeminino empoderamentoFeminino)
        {
            _context.EmpoderamentoFeminino.Add(empoderamentoFeminino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpoderamentoFeminino", new { id = empoderamentoFeminino.Id }, empoderamentoFeminino);
        }

        // DELETE: api/EmpoderamentoFemininos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpoderamentoFeminino(int id)
        {
            var empoderamentoFeminino = await _context.EmpoderamentoFeminino.FindAsync(id);
            if (empoderamentoFeminino == null)
            {
                return NotFound();
            }

            _context.EmpoderamentoFeminino.Remove(empoderamentoFeminino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpoderamentoFemininoExists(int id)
        {
            return _context.EmpoderamentoFeminino.Any(e => e.Id == id);
        }
    }
}
