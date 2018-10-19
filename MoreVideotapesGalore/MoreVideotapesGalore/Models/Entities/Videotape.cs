using System.Data.Common;

namespace MoreVideotapesGalore.Models.Entities
{
    public class Videotape
    {
        public int id { get; set; }
        public string director_name { get; set; }
        public string type { get; set; }
        public string release_date { get; set; }
        public string eidr { get; set; }
    }
}