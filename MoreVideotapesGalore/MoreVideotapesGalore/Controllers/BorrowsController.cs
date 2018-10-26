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
        private BorrowService bs;

        public BorrowsController(VideoTapeContext context)
        {
            bs = new BorrowService();
        }


        // GET: api/users/5
        // returns a single borrow entry by id
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
                if(borrow == null)
                {
                    return BadRequest();
                }
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
