using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using MoreVideotapesGalore.Models.Entities;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;
using System;
using Microsoft.AspNetCore.Hosting;

namespace VideoTapeNS
{
    public class VideoTapeContext : DbContext
    {
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Videotape> Videotapes { get; set; }
        public DbSet<Review> Reviews { get; set; }

        private int incremented_id = 0;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Filename = ..\\MoreVideotapesGalore\\GaloreDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            using (StreamReader streamReader = new StreamReader("..\\MoreVideotapesGalore\\Seed\\Videotapes.json"))
            {
                string tapeData = streamReader.ReadToEnd();
                JArray tapes = JArray.Parse(tapeData);
                foreach (var tape in tapes)
                {
                    JObject tapeJObject = (JObject)JToken.FromObject(tape);

                    int tapeId = (int)tapeJObject.GetValue("id");
                    string title = (string)tapeJObject.GetValue("title");
                    string dln = (string)tapeJObject.GetValue("director_first_name");
                    string dfn = (string)tapeJObject.GetValue("director_last_name");
                    string type = (string)tapeJObject.GetValue("type");
                    string release_date = (string)tapeJObject.GetValue("release_date");
                    string eidr = (string)tapeJObject.GetValue("eidr");

                    modelBuilder.Entity<Videotape>().HasData(
                        new Videotape
                        {
                            videotapeId = tapeId,
                            title = title,
                            director_first_name = dfn,
                            director_last_name = dln,
                            type = type,
                            release_date = release_date,
                            eidr = eidr,
                            isRented = false
                        });
                }
            }

            using (StreamReader streamReader = new StreamReader("..\\MoreVideotapesGalore\\Seed\\Friends.json"))
            {
                string userData = streamReader.ReadToEnd();
                JArray users = JArray.Parse(userData);
                foreach (var user in users)
                {
                    JObject userJObject = (JObject)JToken.FromObject(user);

                    int userId = (int)userJObject.GetValue("id");
                    string fn = (string)userJObject.GetValue("first_name");
                    string ln = (string)userJObject.GetValue("last_name");
                    string email = (string)userJObject.GetValue("email");
                    string phone = (string)userJObject.GetValue("phone");
                    string address = (string)userJObject.GetValue("address");

                    JArray tapesBorrowed = (JArray)userJObject.GetValue("tapes");
                    if (tapesBorrowed != null)
                    {
                        foreach (var tapeBorrowed in tapesBorrowed)
                        {
                            JObject borrowedTapeJObject = (JObject)JToken.FromObject(tapeBorrowed);

                            int borrowedTapeId = (int)borrowedTapeJObject.GetValue("id");
                            string borrow_date = (string)borrowedTapeJObject.GetValue("borrow_date");
                            string return_date = (string)borrowedTapeJObject.GetValue("return_date");

                            incremented_id = incremented_id + 1;

                            modelBuilder.Entity<Borrow>().HasData(
                                new Borrow
                                {
                                    borrowId = incremented_id,
                                    userId = userId,
                                    videotapeId = borrowedTapeId,
                                    borrow_date = borrow_date,
                                    return_date = return_date
                                });
                        }
                    }

                    modelBuilder.Entity<User>().HasData(
                        new User
                        {
                            userId = userId,
                            first_name = fn,
                            last_name = ln,
                            email = email,
                            phone_number = phone,
                            address = address
                        });
                }
            }
        }
    }
}