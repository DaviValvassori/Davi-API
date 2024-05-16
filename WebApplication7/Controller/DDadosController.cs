using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Dados;
using WebApplication7.Models;

namespace WebApplication7.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDadosController : ControllerBase
    {
        private readonly DDados _context;

        public DDadosController(DDados context)
        {
            _context = context;
        }

        // GET: api/DDados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistoricoModel>>> GethistoricoModels()
        {
            return await _context.historicoModels.ToListAsync();
        }

        // GET: api/DDados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HistoricoModel>> GetHistoricoModel(int id)
        {
            var historicoModel = await _context.historicoModels.FindAsync(id);

            if (historicoModel == null)
            {
                return NotFound();
            }

            return historicoModel;
        }

        // PUT: api/DDados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoricoModel(int id, HistoricoModel historicoModel)
        {
            if (id != historicoModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(historicoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoricoModelExists(id))
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

        // POST: api/DDados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HistoricoModel>> PostHistoricoModel(HistoricoModel historicoModel)
        {
            _context.historicoModels.Add(historicoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoricoModel", new { id = historicoModel.ID }, historicoModel);
        }

        // DELETE: api/DDados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoricoModel(int id)
        {
            var historicoModel = await _context.historicoModels.FindAsync(id);
            if (historicoModel == null)
            {
                return NotFound();
            }

            _context.historicoModels.Remove(historicoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HistoricoModelExists(int id)
        {
            return _context.historicoModels.Any(e => e.ID == id);
        }
    }
}
