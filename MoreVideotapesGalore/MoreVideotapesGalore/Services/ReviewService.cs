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
        
        public Review addReview(Review review)
        {
            if (!_context.Reviews.Any())
            {
                review.reviewId = 1;
            }
            else
            {
                var latestId = _context.Reviews.Max(p => p.reviewId);
                review.reviewId = latestId + 1;
            }
            _context.Reviews.Add(review);
            _context.SaveChangesAsync();

            return review;
        }

        public IEnumerable<Review> getReviewFromUser(int userId)
        {
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.userId == userId);
            return reviews;
        }

        public IEnumerable<Review> getReviewFromUserByTape(int userId, int tapeId)
        {
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.userId == userId && e.videotapeId == tapeId);
            return reviews;
        }
        public Review getReview(int id)
        {
            var review = _context.Reviews.SingleOrDefault(e => e.reviewId == id);
            return review;
        }

        public Review deleteReview(int userId, int tapeId)
        {
            var review = _context.Reviews.SingleOrDefault(e => e.userId == userId && e.videotapeId == tapeId);
            _context.Reviews.Remove(review);
            _context.SaveChangesAsync();
            return review;
        }

        public bool checkIfExists(int id)
        {
            return _context.Reviews.Any(e => e.reviewId == id);
        }

    }
}

