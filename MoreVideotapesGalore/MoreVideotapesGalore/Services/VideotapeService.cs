using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoTapeNS;
using MoreVideotapesGalore.Services.DateLogic;

namespace MoreVideotapesGalore.Services
{
    public class VideotapeService
    {
        private readonly VideoTapeContext _context;
        private DateValidations validation;

        public VideotapeService()
        {
            _context = new VideoTapeContext();
            validation = new DateValidations();
        }


        public object getVideotapeAndBorrow(int id)
        {
            Videotape videotape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.videotapeId == id);

            return new { videotape, borrows };
        }

        public IEnumerable<Videotape> GetAllVideotapes()
        {
            return _context.Videotapes;
        }

        public void EditVideotape( Videotape tape, int id)
        {
            tape.videotapeId = id;
            _context.Entry(tape).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public void addVideotape( Videotape tape)
        {
            if (!_context.Videotapes.Any())
            {
                tape.videotapeId = 1;
            }
            else
            {
                var latestId = _context.Videotapes.Max(p => p.videotapeId);
                tape.videotapeId = latestId + 1;
            }
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
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.videotapeId == tape.videotapeId);
            _context.Borrows.RemoveRange(borrows);
            _context.Reviews.RemoveRange(reviews);
            _context.Videotapes.Remove(tape);
            _context.SaveChangesAsync();
        }

        public IEnumerable<Videotape> tapesBorrowedAtDate(string sDate)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<Videotape> usersWithBorrowedTapes = new List<Videotape>();

            foreach (var tape in borrowedTapes)
            {
                if (validation.validateDate(tape.borrow_date, tape.return_date, sDate))
                {
                    var tapeOnLoan = getVideotape(tape.videotapeId);
                    usersWithBorrowedTapes.Add(tapeOnLoan);
                }
            }

            return usersWithBorrowedTapes;
        }

        public bool checkIfExists(int id)
        {
            return _context.Videotapes.Any(e => e.videotapeId == id);
        }
    }
}

