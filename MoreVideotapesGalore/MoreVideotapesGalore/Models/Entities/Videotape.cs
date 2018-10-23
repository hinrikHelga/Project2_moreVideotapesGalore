using System.Data.Common;

namespace MoreVideotapesGalore.Models.Entities
{
    public class Videotape
    {
        public int videotapeId { get; set; }
        public string title { get; set; }
        public string director_first_name { get; set; }
        public string director_last_name { get; set; }
        public string type { get; set; }
        public string release_date { get; set; }
        public string eidr { get; set; }
    }
}