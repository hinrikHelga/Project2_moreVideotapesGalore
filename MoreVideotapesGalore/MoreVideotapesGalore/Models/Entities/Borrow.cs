
namespace MoreVideotapesGalore.Models.Entities
{
    public class Borrow
    {
        public int borrowId { get; set; }
        public int userId { get; set; }
        public int videotapeId { get; set; }
        public string borrow_date { get; set; }
        public string return_date { get; set; }
        public bool isRented { get; set; }


    }
}