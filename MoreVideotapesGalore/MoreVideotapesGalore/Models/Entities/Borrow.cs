
using System.ComponentModel.DataAnnotations;

namespace MoreVideotapesGalore.Models.Entities
{
    /*
     * The class Borrow (Borrow.cs)
     * contains the properties of borrowed tapes that will be stored in database.
     */
    public class Borrow
    {
        [Required]
        public int borrowId { get; set; }

        [Required]
        public int userId { get; set; }

        [Required]
        public int videotapeId { get; set; }

        [Required]
        public string borrow_date { get; set; }

        public string return_date { get; set; }

    }
}