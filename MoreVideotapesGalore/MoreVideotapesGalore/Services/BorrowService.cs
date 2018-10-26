using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoTapeNS;

namespace MoreVideotapesGalore.Services
{
    public class BorrowService
    {
        private readonly VideoTapeContext _context;

        public BorrowService()
        {
            _context = new VideoTapeContext();
        }

        public IEnumerable<Borrow> GetAllborrows()
        {
            return _context.Borrows;
        }

        public void EditBorrow(Borrow loan, int userId, int tapeId)
        {
            loan.userId = userId;
            loan.videotapeId = tapeId;
            _context.Entry(loan).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public Borrow addBorrow(int userId, int tapeId) 
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            Borrow br = new Borrow();
            if (!_context.Borrows.Any())
            {
                br.borrowId = 1;
            }
            else
            {
                var latestId = _context.Borrows.Max(p => p.borrowId);
                br.borrowId = latestId + 1;
            }
            br.userId = userId;
            br.videotapeId = tapeId;
            br.borrow_date = today;
            br.return_date = null;

            Videotape tape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == tapeId);
            if(tape != null)
            {
                if (checkIfTapeExists(tape.videotapeId))
                {
                    tape.isRented = true;
                    _context.Entry(tape).State = EntityState.Modified;
                    _context.SaveChangesAsync();
                }
            }
 
            _context.Borrows.Add(br);
            _context.SaveChangesAsync();
            return br;
        }

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

        public Borrow getBorrow(int id)
        {
            var borrow = _context.Borrows.SingleOrDefault(e => e.videotapeId == id);
            return borrow;
        }

        public void deleteBorrow(int id)
        {
            Borrow br = getBorrow(id);
            Videotape tape = _context.Videotapes.SingleOrDefault(e => e.videotapeId == id);// the tape to change isRented
            if (tape != null)
            {
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



        public bool checkIfExists(int id)
        {
            return _context.Borrows.Any(e => e.borrowId == id);
        }
        public bool checkIfTapeExists(int id)
        {
            return _context.Videotapes.Any(e => e.videotapeId == id);
        }

    }
}

