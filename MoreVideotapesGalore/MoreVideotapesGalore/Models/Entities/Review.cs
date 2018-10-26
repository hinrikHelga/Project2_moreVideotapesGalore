
using System.ComponentModel.DataAnnotations;

namespace MoreVideotapesGalore.Models.Entities
{
    /*
     * The class Review (Review.cs)
     * contains the properties of user's reviews that will be stored in database.
     */
    public class Review
    {
        [Required]
        public int reviewId { get; set; }

        [Required]
        public int userId { get; set; }

        [Required]
        public int videotapeId { get; set; }

        public int rating { get; set; }

        public string text { get; set; }
    }
}