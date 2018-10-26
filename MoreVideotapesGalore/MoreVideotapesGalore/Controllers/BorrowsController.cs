using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using MoreVideotapesGalore.Services;
using VideoTapeNS;

namespace MoreVideotapesGalore.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class BorrowsController : ControllerBase
    {
        private readonly VideoTapeContext _context;
        private BorrowService bs;

        public BorrowsController(VideoTapeContext context)
        {
            _context = context;
            bs = new BorrowService();
        }

        //// GET: api/Borrows
        //[HttpGet]
        //public IEnumerable<Borrow> GetBorrows()
        //{
        //    return bs.GetAllborrows();
        //}

        // GET: api/Borrows/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBorrow([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var borrow = bs.getBorrow(id);

            if (borrow == null)
            {
                return NotFound();
            }

            return Ok(borrow);
        }

        // PUT: api/Borrows/5
        [HttpPut("{userid}/tapes/{tapeId}")]
        public async Task<IActionResult> PutBorrow([FromRoute] int userId, [FromRoute] int tapeId, [FromBody] Borrow borrow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (tapeId != borrow.borrowId)
            {
                return BadRequest();
            }

            try
            {
                bs.EditBorrow(borrow); 
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BorrowExists(tapeId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(borrow);
        }

        // POST: api/Borrows
        [HttpPost("{userid}/tapes/{tapeId}")]
        public async Task<IActionResult> PostBorrow([FromRoute] int userId, [FromRoute] int tapeId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (bs.checkIfRented(tapeId))
            {
                return NotFound(); // tape is already rented
            }
            else
            {
                Borrow borrow = bs.addBorrow(userId, tapeId);
                return CreatedAtAction("GetBorrow", new { id = borrow.borrowId }, borrow); // tape is available
            }

        }

        // DELETE: api/Borrows/5
        [HttpDelete("{userid}/tapes/{tapeId}")]
        public async Task<IActionResult> DeleteBorrow([FromRoute] int userId, [FromRoute] int tapeId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var borrow = bs.getBorrow(tapeId); // get correct tape

            if (borrow == null)
            {
                return NotFound();
            }

            bs.deleteBorrow(tapeId); // return the tape.

            return Ok(borrow);
        }

        private bool BorrowExists(int id)
        {
            return bs.checkIfExists(id);
        }
    }
}