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
    /*
     * The class VideotapeService (VideotapeService.cs)
     * contains CRUD functionality while working with database. 
     */
    public class VideotapeService
    {
        /**
         * Variables allowing access to database and all date validations.
         */
        private readonly VideoTapeContext _context;
        private DateValidations validation;


        /**
         * Constructor.
         */ 
        public VideotapeService()
        {
            _context = new VideoTapeContext();
            validation = new DateValidations();
        }


        /**
         * Returns videotape with ID and its borrow history.
         */
        public object getVideotapeAndBorrow(int id)
        {
            Videotape videotape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);

            // If videotape no longer exists in database.
            if (videotape == null)
            {
                return null;
            }

            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.videotapeId == id);

            return new { videotape, borrows };
        }


        /**
         * Returns a list of all videotapes in database.
         */ 
        public IEnumerable<Videotape> GetAllVideotapes()
        {
            return _context.Videotapes;
        }


        /**
         * Modify videotapes's data with ID.
         */
        public void EditVideotape(Videotape tape, int id)
        {
            tape.videotapeId = id;
            _context.Entry(tape).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }


        /**
         * Adds videotape to database.
         */ 
        public void addVideotape(Videotape tape)
        {
            var latestId = _context.Videotapes.Max(p => p.videotapeId);
            tape.videotapeId = latestId + 1;

            _context.Videotapes.Add(tape);
            _context.SaveChangesAsync();
        }


        /**
         * Return videotape from database using its ID.
         */
        public Videotape getVideotape(int id)
        {
            var videotape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);
            return videotape;
        }


        /**
         * Deletes videotape from database.
         * Also deletes review and borrow history of the deleted videotape.
         */ 
        public void deleteVideotape(Videotape tape)
        {
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.videotapeId == tape.videotapeId);
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.videotapeId == tape.videotapeId);
            _context.Borrows.RemoveRange(borrows);
            _context.Reviews.RemoveRange(reviews);
            _context.Videotapes.Remove(tape);
            _context.SaveChangesAsync();
        }


        /**
         * Returns a list of videotapes borrwed on a given date from query.
         */ 
        public IEnumerable<Videotape> tapesBorrowedAtDate(string sDate)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<Videotape> usersWithBorrowedTapes = new List<Videotape>();

            // Loop through all borrowed tapes.
            foreach (var tape in borrowedTapes)
            {
                // If the tape's dates in question are validated, add the user who borrowed it to list.
                if (validation.validateDate(tape.borrow_date, tape.return_date, sDate))
                {
                    var tapeOnLoan = getVideotape(tape.videotapeId);
                    usersWithBorrowedTapes.Add(tapeOnLoan);
                }
            }

            return usersWithBorrowedTapes;
        }

        /**
         * Returns true if videotape exists in database.
         */ 
        public bool checkIfExists(int id)
        {
            return _context.Videotapes.Any(e => e.videotapeId == id);
        }
    }
}

