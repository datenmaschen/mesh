using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datamesh.Models;

namespace datamesh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataDomainItemsController : ControllerBase
    {
        private readonly DatameshContext _context;

        public DataDomainItemsController(DatameshContext context)
        {
            _context = context;
        }

        // GET: api/DataDomainItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataDomain>>> GetDataDomainSet()
        {
          if (_context.DataDomainSet == null)
          {
              return NotFound();
          }
            return await _context.DataDomainSet.ToListAsync();
        }

        // GET: api/DataDomainItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataDomain>> GetDataDomain(Guid id)
        {
          if (_context.DataDomainSet == null)
          {
              return NotFound();
          }
            var dataDomain = await _context.DataDomainSet.FindAsync(id);

            if (dataDomain == null)
            {
                return NotFound();
            }

            return dataDomain;
        }

        // PUT: api/DataDomainItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataDomain(Guid id, DataDomain dataDomain)
        {
            if (id != dataDomain.Id)
            {
                return BadRequest();
            }

            _context.Entry(dataDomain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataDomainExists(id))
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

        // POST: api/DataDomainItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DataDomain>> PostDataDomain(DataDomain dataDomain)
        {
          if (_context.DataDomainSet == null)
          {
              return Problem("Entity set 'DatameshContext.DataDomainSet'  is null.");
          }
            _context.DataDomainSet.Add(dataDomain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDataDomain", new { id = dataDomain.Id }, dataDomain);
        }

        // DELETE: api/DataDomainItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDataDomain(Guid id)
        {
            if (_context.DataDomainSet == null)
            {
                return NotFound();
            }
            var dataDomain = await _context.DataDomainSet.FindAsync(id);
            if (dataDomain == null)
            {
                return NotFound();
            }

            _context.DataDomainSet.Remove(dataDomain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DataDomainExists(Guid id)
        {
            return (_context.DataDomainSet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
