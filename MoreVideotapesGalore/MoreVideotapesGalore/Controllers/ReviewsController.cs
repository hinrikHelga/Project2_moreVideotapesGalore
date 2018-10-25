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
    [Route("api/")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly VideoTapeContext _context;
        private ReviewService rs;

        public ReviewsController(VideoTapeContext context)
        {
            _context = context;
            rs = new ReviewService();
        }

        // GET: api/Reviews
        [HttpGet]
        public IEnumerable<Review> GetReviews()
        {
            return _context.Reviews;
        }
        ///users/{user_id}/reviews/{tape_id}
        ///

        // GET: api/Reviews/5
        [HttpGet("users/{userId}/reviews/{tapeId}")]
        public async Task<IActionResult> GetReviewFromUserByTape([FromRoute] int userId, [FromRoute] int tapeId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var review = rs.getReviewFromUserByTape(userId,tapeId);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }


        // GET: api/Reviews/5
        [HttpGet("users/{userId}/reviews")]
        public async Task<IActionResult> GetReviewFromUser([FromRoute] int userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var review = rs.getReviewFromUser(userId);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }
        [HttpGet("reviews/{id}")]
        public async Task<IActionResult> GetReview([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var review = rs.getReview(id);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }
        ///users/{user_id}/reviews/{tape_id}
        // PUT: api/Reviews/5
        [HttpPut("users/{user_id}/reviews/{tape_id}")]
        public async Task<IActionResult> PutReview( [FromBody] Review review, [FromRoute] int user_id, [FromRoute] int tape_id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
 
            _context.Entry(review).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(review.reviewId))
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

        // POST: /users/{user_id}/reviews/{tape_id}
        [HttpPost("users/{user_id}/reviews/{tape_id}")]
        public async Task<IActionResult> PostReview([FromBody] Review review, [FromRoute] int user_id,[FromRoute] int tape_id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Review new_review = rs.addReview(review);

            return CreatedAtAction("GetReview", new { id = new_review.reviewId }, new_review);
        }

        // DELETE: api/Reviews/5
        ///users/{user_id}/reviews/{tape_id}
[HttpDelete("users/{user_id}/reviews/{tape_id}")]
        public async Task<IActionResult> DeleteReview([FromRoute] int user_id, [FromRoute] int tape_id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var review = rs.deleteReview(user_id, tape_id);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.reviewId == id);
        }
    }
}