
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using MoreVideotapesGalore.Services;

namespace MoreVideotapesGalore.Controllers
{
    [Route("api/tapes")]
    [ApiController]
    public class VideotapesController : ControllerBase
    {
        private VideotapeService vts;

        public VideotapesController()
        {
            vts = new VideotapeService();
        }

        [HttpGet]
        public async Task<IActionResult> GetVideotapes([FromQuery] string LoanDate)
        { 
            if (!string.IsNullOrEmpty(LoanDate))
            {
                return Ok(vts.tapesBorrowedAtDate(LoanDate));
            }

            else
            {
                return Ok(vts.GetAllVideotapes());
            }

        }

        // GET: api/Videotapes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVideotape([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Data = vts.getVideotapeAndBorrow(id);

            if (Data == null)
            {
                return NotFound();
            }

            return Ok(Data);
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

            try
            {
                vts.EditVideotape(videotape, id);
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

            return Ok(videotape);
        }

        // POST: api/Videotapes
        [HttpPost]
        public async Task<IActionResult> PostVideotape([FromBody] Videotape videotape)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            vts.addVideotape(videotape);

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

            var videotape = vts.getVideotape(id);

            if (videotape == null)
            {
                return NotFound();
            }

            vts.deleteVideotape(videotape);

            return Ok(videotape);
        }

        private bool VideotapeExists(int id)
        {
            return vts.checkIfExists(id);
        }
    }
}