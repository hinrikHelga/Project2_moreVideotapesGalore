using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoTapeNS;

namespace MoreVideotapesGalore.Services
{
    /*
     * The class BorrowService (BorrowService.cs)
     * contains CRUD functionality while working with database. 
     */
    public class BorrowService
    {
        /**
         * Variable allowing access to database.
         */
        private readonly VideoTapeContext _context;


        /**
         * Constructor.
         */ 
        public BorrowService()
        {
            _context = new VideoTapeContext();
        }


        /**
         * Register borrowed videotape which has the borrow date set to the current date.
         * The function only adds videotape to database if videotape exists in database.
         */ 
        public Borrow addBorrow(int userId, int tapeId) 
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            Borrow br = new Borrow();

            var latestId = _context.Borrows.Max(p => p.borrowId);
            br.borrowId = latestId + 1;

            br.userId = userId;
            br.videotapeId = tapeId;
            br.borrow_date = today;
            br.return_date = null;

            Videotape tape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == tapeId);

            // If videotape ID from URI is valid
            if (tape != null)
            {
                // Only add to user's borrow history if videotape exists in database.
                if (checkIfTapeExists(tape.videotapeId))
                {
                    tape.isRented = true;
                    _context.Entry(tape).State = EntityState.Modified;
                    _context.SaveChangesAsync();
                }

                _context.Borrows.Add(br);
                _context.SaveChangesAsync();
            }
 
            return br;
        }


        /**
         * Return true if videotape is already borrowed by some user.
         */ 
        public bool checkIfRented(int id)
        {
            Videotape tape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);
            if (tape.isRented)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /**
         * Return borrow history of videotape.
         */ 
        public Borrow getBorrow(int id)
        {
            var borrow = _context.Borrows.SingleOrDefault(e => e.videotapeId == id);
            return borrow;
        }


        /**
         * Remove a videotape from borrow history in database.
         */ 
        public void deleteBorrow(int id)
        {
            Borrow br = getBorrow(id);
            Videotape tape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id); // the tape to change isRented

            // If videotape ID from URI is valid
            if (tape != null)
            {
                // If videotape exists in database, return it.
                if (checkIfTapeExists(tape.videotapeId))
                {
                    tape.isRented = false;
                    _context.Entry(tape).State = EntityState.Modified;
                    _context.SaveChangesAsync();
                }
            }

            _context.Borrows.Remove(br);
            _context.SaveChangesAsync();
        }


        /**
         * Returns true if a borrowed videotape exists in database.
         */
        public bool checkIfExists(int id)
        {
            return _context.Borrows.Any(e => e.borrowId == id);
        }


        /**
         * Returns true if videotape exists in database.
         */
        public bool checkIfTapeExists(int id)
        {
            return _context.Videotapes.Any(e => e.videotapeId == id);
        }

    }
}

