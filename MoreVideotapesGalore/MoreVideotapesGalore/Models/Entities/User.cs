using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Design;

namespace MoreVideotapesGalore.Models.Entities
{
    /*
     * The class User (User.cs)
     * contains the properties of all users that will be stored in database.
     */
    public class User
    {
        [Required]
        public int userId { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string phone_number { get; set; }

        public string address { get; set; }
    }
}