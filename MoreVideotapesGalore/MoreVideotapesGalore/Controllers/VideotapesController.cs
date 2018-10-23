using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using VideoTapeNS;

namespace MoreVideotapesGalore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideotapesController : ControllerBase
    {
        private readonly VideoTapeContext _context;

        public VideotapesController(VideoTapeContext context)
        {
            _context = context;
        }

        // GET: api/Videotapes
        [HttpGet]
        public IEnumerable<Videotape> GetVideotapes()
        {
            return _context.Videotapes;
        }

        // GET: api/Videotapes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVideotape([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var videotape = await _context.Videotapes.FindAsync(id);

            if (videotape == null)
            {
                return NotFound();
            }

            return Ok(videotape);
        }

        // PUT: api/Videotapes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVideotape([FromRoute] int id, [FromBody] Videotape videotape)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != videotape.videotapeId)
            {
                return BadRequest();
            }

            _context.Entry(videotape).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideotapeExists(id))
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

        // POST: api/Videotapes
        [HttpPost]
        public async Task<IActionResult> PostVideotape([FromBody] Videotape videotape)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Videotapes.Add(videotape);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVideotape", new { id = videotape.videotapeId }, videotape);
        }

        // DELETE: api/Videotapes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideotape([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var videotape = await _context.Videotapes.FindAsync(id);
            if (videotape == null)
            {
                return NotFound();
            }

            _context.Videotapes.Remove(videotape);
            await _context.SaveChangesAsync();

            return Ok(videotape);
        }

        private bool VideotapeExists(int id)
        {
            return _context.Videotapes.Any(e => e.videotapeId == id);
        }
    }
}