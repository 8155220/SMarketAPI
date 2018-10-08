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
    public class ProductTypeController : ControllerBase
    {
        private readonly SMarketContext _context;

        public ProductTypeController(SMarketContext context)
        {
            _context = context;
        }

        // GET: api/ProductType
        [HttpGet]
        public IEnumerable<ProductType> GetProductType()
        {
            return _context.ProductType;
        }

        // GET: api/ProductType/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productType = await _context.ProductType.FindAsync(id);

            if (productType == null)
            {
                return NotFound();
            }

            return Ok(productType);
        }

        // PUT: api/ProductType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductType([FromRoute] int id, [FromBody] ProductType productType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productType.ProductTypeId)
            {
                return BadRequest();
            }

            _context.Entry(productType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeExists(id))
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

        // POST: api/ProductType
        [HttpPost]
        public async Task<IActionResult> PostProductType([FromBody] ProductType productType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ProductType.Add(productType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductType", new { id = productType.ProductTypeId }, productType);
        }

        // DELETE: api/ProductType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productType = await _context.ProductType.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            _context.ProductType.Remove(productType);
            await _context.SaveChangesAsync();

            return Ok(productType);
        }

        private bool ProductTypeExists(int id)
        {
            return _context.ProductType.Any(e => e.ProductTypeId == id);
        }
    }
}