using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Design;

namespace MoreVideotapesGalore.Models.Entities
{
    public class User
    {
        private int id { get; set; }
        private string first_name { get; set; }
        private string last_name { get; set; }
        private string email { get; set; }
        private string phone_number { get; set; }
        private string address { get; set; }
    }
}