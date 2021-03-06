﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SMarketAPI.Models;
namespace SMarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly SMarketContext _context;

        public ProductsController(SMarketContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products= await _context.Products.Include(p => p.Images).ToListAsync();

            return Ok(products);
        }
        [HttpGet("last")]
        public async Task<IActionResult> GetLastProducts()
        {
            var products = await _context.Products.Include(p => p.Images).OrderByDescending(p=>p.Created).
                Take(4).ToListAsync();

            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.Include(p => p.Images).FirstAsync(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product product)
        {

            Console.WriteLine("ErrorAQui");
            //JsonConvert.DeserializeObject(product);
            string json = JsonConvert.SerializeObject(product, Formatting.Indented);
            Console.WriteLine(json);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            // _context.Entry(product).State = EntityState.Modified;
            _context.Update(product);
            var productDB = _context.Products.Single(a => a.ProductId == product.ProductId);
            var images = _context.Image.Where(b=>EF.Property<int>(b,"ProductId")==product.ProductId);
            foreach(var image in images)
            {
                productDB.Images.Remove(image);
            }
            //_context.Entry(product).Property(x=> x.Images).IsModified = false;
            _context.Update(product);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}