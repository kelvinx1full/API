using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.ETEC01.Data;
using API.ETEC01.Model;

namespace API.ETEC01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController2 : ControllerBase
    {
        private readonly APIETEC01Context _context;

        public ContaController2(APIETEC01Context context)
        {
            _context = context;
        }

        // GET: api/ContaController2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaModel>>> GetContaModel()
        {
            return await _context.ContaModel.ToListAsync();
        }

        // GET: api/ContaController2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaModel>> GetContaModel(int id)
        {
            var contaModel = await _context.ContaModel.FindAsync(id);

            if (contaModel == null)
            {
                return NotFound();
            }

            return contaModel;
        }

        // PUT: api/ContaController2/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaModel(int id, ContaModel contaModel)
        {
            if (id != contaModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(contaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaModelExists(id))
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

        // POST: api/ContaController2
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ContaModel>> PostContaModel(ContaModel contaModel)
        {
            _context.ContaModel.Add(contaModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContaModel", new { id = contaModel.Id }, contaModel);
        }

        // DELETE: api/ContaController2/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ContaModel>> DeleteContaModel(int id)
        {
            var contaModel = await _context.ContaModel.FindAsync(id);
            if (contaModel == null)
            {
                return NotFound();
            }

            _context.ContaModel.Remove(contaModel);
            await _context.SaveChangesAsync();

            return contaModel;
        }

        private bool ContaModelExists(int id)
        {
            return _context.ContaModel.Any(e => e.Id == id);
        }
    }
}
