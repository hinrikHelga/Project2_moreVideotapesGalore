using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using VideoTapeNS;
using MoreVideotapesGalore.Services.DateLogic;

namespace MoreVideotapesGalore.Services
{
    public class UserService
    {
        private readonly VideoTapeContext _context;
        private DateValidations validation;

        public UserService()
        {
            validation = new DateValidations();
            _context = new VideoTapeContext();
        }


        public object getUserAndBorrow(int id)
        {
            User user = _context.Users.SingleOrDefault(e => e.userId == id);
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == id && e.return_date == null);

            return new { user, borrows };
        }

        public object getUserAndBorrowHistory(int id)
        {
            User user = _context.Users.SingleOrDefault(e => e.userId == id);
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == id);

            return new { user, borrows };
        }

        public IEnumerable<Borrow> getTapes(int id)
        {
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == id);
            return borrows;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public void EditUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public void addUser(User user)
        {
            if (!_context.Users.Any())
            {
                user.userId = 1;
            }
            else
            {
                var latestId = _context.Users.Max(p => p.userId);
                user.userId= latestId + 1;
            }
            _context.Users.Add(user);
            _context.SaveChangesAsync();
        }

        public User getUser(int id)
        {
            User user = _context.Users.SingleOrDefault(e => e.userId == id);
            return user;
        }

        public void deleteUser(User user)
        {
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == user.userId);
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.userId == user.userId);
            _context.Borrows.RemoveRange(borrows);
            _context.Reviews.RemoveRange(reviews);
            _context.Users.Remove(user);
            _context.SaveChangesAsync();
        }

        public IEnumerable<User> usersWithTapesBorrowedAtDate(string sDate)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<User> usersWithBorrowedTapes = new List<User>();

            foreach (var tape in borrowedTapes)
            {
                if (validation.validateDate(tape.borrow_date, tape.return_date, sDate))
                {
                    var userWithTape = getUser(tape.userId);
                    usersWithBorrowedTapes.Add(userWithTape);
                }
            }

            return usersWithBorrowedTapes;
        }

        public IEnumerable<User> usersWithTapesBorrowedAfterDuration(string sDuration)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<User> usersWithBorrowedTapes = new List<User>();

            int duration = Int32.Parse(sDuration);

            foreach (var tape in borrowedTapes)
            {
                if (validation.validateAfterDuration(tape.borrow_date, tape.return_date, duration))
                {
                    var userWithTape = getUser(tape.userId);
                    usersWithBorrowedTapes.Add(userWithTape);
                }
            }

            return usersWithBorrowedTapes;
        }

        public bool checkIfExists(int id)
        {
            return _context.Users.Any(e => e.userId == id);
        }
    }
}

