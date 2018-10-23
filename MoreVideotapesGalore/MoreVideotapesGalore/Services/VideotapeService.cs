using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoTapeNS;

namespace MoreVideotapesGalore.Services
{
    public class VideotapeService
    {
        private readonly VideoTapeContext _context;

        public VideotapeService()
        {
            _context = new VideoTapeContext();
        }


        public object getVideotapeAndBorrow(int id)
        {
            Videotape videotape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.videotapeId == id);
            Console.WriteLine("brorbro");
            Console.Write(videotape);

            return new { videotape, borrows };
        }

        public IEnumerable<Videotape> GetAllVideotapes()
        {
            return _context.Videotapes;
        }

        public void EditVideotape( Videotape tape)
        {
            _context.Entry(tape).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public void addVideotape( Videotape tape)
        { 
            _context.Videotapes.Add(tape);
            _context.SaveChangesAsync();
        }

        public Videotape getVideotape(int id)
        {
            var videotape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);
            return videotape;
        }

        public void deleteVideotape(Videotape tape)
        {
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.videotapeId == tape.videotapeId);
            _context.Borrows.RemoveRange(borrows);
            _context.Videotapes.Remove(tape);
            _context.SaveChangesAsync();
        }

        public bool checkIfExists(int id)
        {
            return _context.Videotapes.Any(e => e.videotapeId == id);
        }

        }
    }

