using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace MoreVideotapesGalore.Models.Entities
{
    /*
     * The class Videotape (Videotape.cs)
     * contains the properties of all videotapes that will be stored in database.
     */
    public class Videotape
    {
        [Required]
        public int videotapeId { get; set; }

        public string title { get; set; }

        public string director_first_name { get; set; }

        public string director_last_name { get; set; }

        public string type { get; set; }

        public string release_date { get; set; }

        public string eidr { get; set; }

        public bool isRented { get; set; }
    }
}