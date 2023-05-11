using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datamesh.Data;
using Datamesh.Data.Dto;
using Datamesh.Models;

namespace datamesh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataproductItemsController : ControllerBase
    {
        private readonly DatameshContext _context;

        public DataproductItemsController(DatameshContext context)
        {
            _context = context;
        }

        // <snippet_Create>
        /// <summary>
        /// Fetch all Dataproduct(s).
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET api/Dataproduct
        ///
        /// </remarks>
        // GET: api/Dataproduct
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataproductDto>>> GetDataproductSet()
        {
            if (_context.DataproductSet == null)
            {
                return NotFound();
            }
            return await _context.DataproductSet
                        .Select(x => ItemToDTO(x))
                        .ToListAsync();
        }

        // GET: api/Dataproduct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataproductDto>> GetDataproduct(Guid id)
        {
            var dataproduct = await _context.DataproductSet.Select(t => 
                new DataproductDto(){
                    Id = t.Id,
                    Name = t.Name,
                    Key = t.Key,
                    Type = t.Type,
                    Owner = t.Owner,
                    DeputyOwner = t.DeputyOwner,
                    Description = t.Description,
                    DataDomainId = t.DataDomainId
                })
                .SingleOrDefaultAsync(t => t.Id == id);;

            if (dataproduct == null)
            {
                return NotFound();
            }

            return Ok(dataproduct);
        }

        // PUT: api/Dataproduct/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataproduct(Guid id, DataproductDto dataproduct)
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

        // <snippet_Create>
        /// <summary>
        /// Creates a Dataproduct.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST api/Dataproduct
        ///     {
        ///        "Name": "Item1",
        ///        "Key": "Key",
        ///     }
        ///
        /// </remarks>
        /// <param name="dataproduct"></param>
        /// <returns>A newly created Dataproduct</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>  
        // POST: api/Dataproduct
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DataproductDto>> PostDataproduct(DataproductDto dataproduct)
        {
            //get the related datadomain   
            var datadomain = _context.DataDomainSet.Where(x => x.Id == dataproduct.DataDomainId).ToList();
            
            Dataproduct dp = new Dataproduct
            {
                Id = dataproduct.Id,
                Name = dataproduct.Name,
                Key = dataproduct.Key,
                Type = dataproduct.Type,
                Owner = dataproduct.Owner,
                DeputyOwner = dataproduct.DeputyOwner,
                Description = dataproduct.Description,
                DataDomainId = datadomain[0].Id
            };

            if (_context.DataproductSet == null)
            {
                return Problem("Entity set 'DatameshContext.DataproductSet'  is null.");
            }

            _context.DataproductSet.Add(dp);
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

        private static DataproductDto ItemToDTO(Dataproduct DataproductDtoItem) =>
            new DataproductDto
            {
                Id = DataproductDtoItem.Id,
                Name = DataproductDtoItem.Name,
                Key = DataproductDtoItem.Key,
                Type = DataproductDtoItem.Type,
                Owner = DataproductDtoItem.Owner,
                DeputyOwner = DataproductDtoItem.DeputyOwner,
                Description = DataproductDtoItem.Description,
                Purpose = DataproductDtoItem.Purpose,
                DataDomainId = DataproductDtoItem.DataDomainId
            };
    }
}
