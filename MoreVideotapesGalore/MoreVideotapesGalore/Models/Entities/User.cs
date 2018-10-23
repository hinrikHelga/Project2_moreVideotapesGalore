using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Design;

namespace MoreVideotapesGalore.Models.Entities
{
    public class User
    {
        public int userId { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
    }
}