using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoTapeNS;

namespace MoreVideotapesGalore.Services
{
    public class ReviewService
    {
        private readonly VideoTapeContext _context;

        public ReviewService()
        {
            _context = new VideoTapeContext();
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _context.Reviews;
        }

        public void EditReview(Review review)
        {
            _context.Entry(review).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public void addReview(Review review)
        {
            //if (!_context.Videotapes.Any())
            //{
            //    tape.videotapeId = 1;
            //}
            //else
            //{
            //    var latestId = _context.Videotapes.Max(p => p.videotapeId);
            //    tape.videotapeId = latestId + 1;
            //}
            //_context.Videotapes.Add(tape);
            //_context.SaveChangesAsync();
        }

        public Review getReviewFromUser(int userId)
        {
            var review = _context.Reviews.SingleOrDefault(e => e.userId == userId);
            return review;
        }
        public Review getReview(int id)
        {
            var review = _context.Reviews.SingleOrDefault(e => e.reviewId == id);
            return review;
        }

        public void deleteReview(Review review)
        {
            _context.Reviews.Remove(review);
            _context.SaveChangesAsync();
        }

        public bool checkIfExists(int id)
        {
            return _context.Reviews.Any(e => e.reviewId == id);
        }

    }
}

