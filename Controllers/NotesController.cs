﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMarketAPI.Models;
using SMarketAPI.Models.Helpers;

namespace SMarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly SMarketContext _context;

        public NotesController(SMarketContext context)
        {
            _context = context;
        }

        // GET: api/Notes
        [HttpGet]
        public IEnumerable<Note> GetNote()
        {
            return _context.Note;
        }

        // GET: api/Notes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var note = await _context.Note
                .Include(n=>n.ProductNoteDetails)
                .FirstAsync(n=>n.NoteId== id);

            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        // PUT: api/Notes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNote([FromRoute] int id, [FromBody] Note note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != note.NoteId)
            {
                return BadRequest();
            }

            _context.Entry(note).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteExists(id))
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

        // POST: api/Notes
        [HttpPost]
        public async Task<IActionResult> PostNote([FromBody] DTONote dtoNote)
        {
            //return BadRequest(ModelState);
            Console.WriteLine("DebugHere");
            Note note = dtoNote.Note;
            ProductNoteDetail[] productDetail = dtoNote.ProductNoteDetail;

            Console.WriteLine(note.Observation);
            // Console.WriteLine(productDetail[0].ReceivedBy);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            productDetail.ToList().ForEach(
                e =>
                {
                    Product product = _context.Products.Find(e.ProductId);

                    if (note.NoteType.Equals("entry"))
                    {
                        product.Quantity = product.Quantity + e.Quantity;
                    } else
                    {
                        product.Quantity = product.Quantity - e.Quantity;
                    }
                }
                );

            _context.Note.Add(note);
            await _context.SaveChangesAsync();
            productDetail.ToList().ForEach(e =>
            {
                e.NoteId = note.NoteId;
                _context.ProductNoteDetail.Add(e);
            });
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetNote", new { id = note.NoteId }, note);
        }
        /*
        [HttpPost]
        public async Task<IActionResult> PostNote([FromBody] Note note, [FromBody] Note note2)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Note.Add(note);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNote", new { id = note.NoteId }, note);
        }
         */

        // DELETE: api/Notes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var note = await _context.Note.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }

            _context.Note.Remove(note);
            await _context.SaveChangesAsync();

            return Ok(note);
        }

        private bool NoteExists(int id)
        {
            return _context.Note.Any(e => e.NoteId == id);
        }
    }
}