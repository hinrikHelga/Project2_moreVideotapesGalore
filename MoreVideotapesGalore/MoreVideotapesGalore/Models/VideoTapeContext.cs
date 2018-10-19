using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;

namespace EFCoreWebDemo
{
    public class EFCoreWebDemoContext : DbContext
    {
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Videotape> Videotapes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Filename = C:\\Users\\Elvar\\Documents\\Project2_moreVideotapesGalore\\MoreVideotapesGalore\\MoreVideotapesGalore\\GaloreDB.db");
        }
    }
}