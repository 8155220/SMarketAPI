using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMarketAPI.Models;

namespace SMarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitTypeController : ControllerBase
    {
        private readonly SMarketContext _context;

        public UnitTypeController(SMarketContext context)
        {
            _context = context;
        }

        // GET: api/UnitType
        [HttpGet]
        public IEnumerable<UnitType> GetUnitType()
        {
            return _context.UnitType;
        }

        // GET: api/UnitType/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnitType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unitType = await _context.UnitType.FindAsync(id);

            if (unitType == null)
            {
                return NotFound();
            }

            return Ok(unitType);
        }

        // PUT: api/UnitType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnitType([FromRoute] long id, [FromBody] UnitType unitType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != unitType.UnitTypeId)
            {
                return BadRequest();
            }

            _context.Entry(unitType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitTypeExists(id))
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

        // POST: api/UnitType
        [HttpPost]
        public async Task<IActionResult> PostUnitType([FromBody] UnitType unitType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UnitType.Add(unitType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnitType", new { id = unitType.UnitTypeId }, unitType);
        }

        // DELETE: api/UnitType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unitType = await _context.UnitType.FindAsync(id);
            if (unitType == null)
            {
                return NotFound();
            }

            _context.UnitType.Remove(unitType);
            await _context.SaveChangesAsync();

            return Ok(unitType);
        }

        private bool UnitTypeExists(long id)
        {
            return _context.UnitType.Any(e => e.UnitTypeId == id);
        }
    }
}