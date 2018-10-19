using System.Data.Common;

namespace MoreVideotapesGalore.Models.Entities
{
    public class Videotape
    {
        private int id { get; set; }
        private string director_name { get; set; }
        private string type { get; set; }
        private string release_date { get; set; }
        private string eidr { get; set; }
    }
}