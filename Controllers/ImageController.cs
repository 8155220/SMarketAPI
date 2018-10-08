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
    public class ImageController : ControllerBase
    {
        private readonly SMarketContext _context;

        public ImageController(SMarketContext context)
        {
            _context = context;
        }

        // GET: api/Image
        [HttpGet]
        public IEnumerable<Image> GetImage()
        {
            return _context.Image;
        }

        // GET: api/Image/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImage([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var image = await _context.Image.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
        }

        // PUT: api/Image/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImage([FromRoute] long id, [FromBody] Image image)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != image.ImageId)
            {
                return BadRequest();
            }

            _context.Entry(image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageExists(id))
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

        // POST: api/Image
        [HttpPost]
        public async Task<IActionResult> PostImage([FromBody] Image image)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Image.Add(image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImage", new { id = image.ImageId }, image);
        }

        // DELETE: api/Image/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var image = await _context.Image.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _context.Image.Remove(image);
            await _context.SaveChangesAsync();

            return Ok(image);
        }

        private bool ImageExists(long id)
        {
            return _context.Image.Any(e => e.ImageId == id);
        }
    }
}