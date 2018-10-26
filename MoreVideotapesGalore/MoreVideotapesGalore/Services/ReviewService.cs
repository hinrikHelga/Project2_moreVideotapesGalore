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


        public IEnumerable<Review> getReviewsForTape(int tapeId)
        {
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.videotapeId == tapeId);
            return reviews;
        }

        public Videotape getRecommendation(int userId)
        {
            int total = _context.Videotapes.Count();
            Random r = new Random();
            int offset = r.Next(0, total);

            Videotape result = _context.Videotapes.Skip(offset).FirstOrDefault();

            if(_context.Borrows.Any(e=>e.userId == userId & e.videotapeId== result.videotapeId))
            {
                getRecommendation(userId);
            }

            return result;
        }

        public void EditReview(Review review, int userId, int tapeId)
        {
            review.videotapeId = tapeId;
            review.userId = userId;
            _context.Entry(review).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
        
        public Review addReview(Review review, int userId, int tapeId)
        {
            review.userId = userId;
            review.videotapeId = tapeId;
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
        public Review getTapeReviewFromUser(int userId, int tapeId)
        {
            Review review = _context.Reviews.SingleOrDefault(e => e.userId == userId && e.videotapeId == tapeId);
            return review;
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
        //Check used when borrowing a tape to check if the user has already reviewed the specific tape.
        public bool checkUserReview(int userId, int tapeId)
        {
            return _context.Reviews.Any(e => e.userId == userId & e.videotapeId == tapeId);

        }

        public bool checkIfExists(int id)
        {
            return _context.Reviews.Any(e => e.reviewId == id);
        }

    }
}

