using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaDetallesController : ControllerBase
    {
        private readonly APINetCoreContext _context;

        public FacturaDetallesController(APINetCoreContext context)
        {
            _context = context;
        }

        // GET: api/FacturaDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaDetalle>>> GetFacturaDetalle()
        {
            return await _context.FacturaDetalle.ToListAsync();
        }

        // GET: api/FacturaDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacturaDetalle>> GetFacturaDetalle(int id)
        {
            var facturaDetalle = await _context.FacturaDetalle.FindAsync(id);

            if (facturaDetalle == null)
            {
                return NotFound();
            }

            return facturaDetalle;
        }

        // PUT: api/FacturaDetalles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturaDetalle(int id, FacturaDetalle facturaDetalle)
        {
            if (id != facturaDetalle.Id)
            {
                return BadRequest();
            }

            _context.Entry(facturaDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaDetalleExists(id))
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

        // POST: api/FacturaDetalles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FacturaDetalle>> PostFacturaDetalle(FacturaDetalle facturaDetalle)
        {
            _context.FacturaDetalle.Add(facturaDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturaDetalle", new { id = facturaDetalle.Id }, facturaDetalle);
        }

        // DELETE: api/FacturaDetalles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacturaDetalle(int id)
        {
            var facturaDetalle = await _context.FacturaDetalle.FindAsync(id);
            if (facturaDetalle == null)
            {
                return NotFound();
            }

            _context.FacturaDetalle.Remove(facturaDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacturaDetalleExists(int id)
        {
            return _context.FacturaDetalle.Any(e => e.Id == id);
        }
    }
}
