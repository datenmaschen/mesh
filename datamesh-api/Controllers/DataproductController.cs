using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datamesh.Data;
using Datamesh.Models;

namespace datamesh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataproductController : ControllerBase
    {
        private readonly DatameshContext _context;

        public DataproductController(DatameshContext context)
        {
            _context = context;
        }

        // GET: api/Dataproduct
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dataproduct>>> GetDataproductSet()
        {
          if (_context.DataproductSet == null)
          {
              return NotFound();
          }
            return await _context.DataproductSet.ToListAsync();
        }

        // GET: api/Dataproduct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dataproduct>> GetDataproduct(Guid id)
        {
          if (_context.DataproductSet == null)
          {
              return NotFound();
          }
            var dataproduct = await _context.DataproductSet.FindAsync(id);

            if (dataproduct == null)
            {
                return NotFound();
            }

            return dataproduct;
        }

        // PUT: api/Dataproduct/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataproduct(Guid id, Dataproduct dataproduct)
        {
            if (id != dataproduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(dataproduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataproductExists(id))
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

        // POST: api/Dataproduct
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dataproduct>> PostDataproduct(Dataproduct dataproduct)
        {
          if (_context.DataproductSet == null)
          {
              return Problem("Entity set 'DatameshContext.DataproductSet'  is null.");
          }
            _context.DataproductSet.Add(dataproduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDataproduct", new { id = dataproduct.Id }, dataproduct);
        }

        // DELETE: api/Dataproduct/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDataproduct(Guid id)
        {
            if (_context.DataproductSet == null)
            {
                return NotFound();
            }
            var dataproduct = await _context.DataproductSet.FindAsync(id);
            if (dataproduct == null)
            {
                return NotFound();
            }

            _context.DataproductSet.Remove(dataproduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DataproductExists(Guid id)
        {
            return (_context.DataproductSet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
