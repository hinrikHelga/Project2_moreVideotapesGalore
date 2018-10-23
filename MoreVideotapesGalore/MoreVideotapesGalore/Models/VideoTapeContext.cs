using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;


namespace VideoTapeNS
{
    public class VideoTapeContext : DbContext
    {
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Videotape> Videotapes { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Filename = C:\\Users\\Elvar\\Documents\\Project2_moreVideotapesGalore\\MoreVideotapesGalore\\MoreVideotapesGalore\\GaloreDB.db");
        }
    }
}