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
    public class ContactUsController : ControllerBase
    {
        private readonly SMarketContext _context;

        public ContactUsController(SMarketContext context)
        {
            _context = context;
        }

        // GET: api/ContactUs
        [HttpGet]
        public IEnumerable<ContactUs> GetContactUs()
        {
            return _context.ContactUs;
        }

        // GET: api/ContactUs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactUs([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contactUs = await _context.ContactUs.FindAsync(id);

            if (contactUs == null)
            {
                return NotFound();
            }

            return Ok(contactUs);
        }

        // PUT: api/ContactUs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactUs([FromRoute] int id, [FromBody] ContactUs contactUs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contactUs.ContactUsId)
            {
                return BadRequest();
            }

            _context.Entry(contactUs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactUsExists(id))
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

        // POST: api/ContactUs
        [HttpPost]
        public async Task<IActionResult> PostContactUs([FromBody] ContactUs contactUs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ContactUs.Add(contactUs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactUs", new { id = contactUs.ContactUsId }, contactUs);
        }

        // DELETE: api/ContactUs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactUs([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contactUs = await _context.ContactUs.FindAsync(id);
            if (contactUs == null)
            {
                return NotFound();
            }

            _context.ContactUs.Remove(contactUs);
            await _context.SaveChangesAsync();

            return Ok(contactUs);
        }

        private bool ContactUsExists(int id)
        {
            return _context.ContactUs.Any(e => e.ContactUsId == id);
        }
    }
}