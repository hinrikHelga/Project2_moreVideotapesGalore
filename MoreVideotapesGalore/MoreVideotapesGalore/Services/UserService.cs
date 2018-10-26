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
    /*
     * The class UserService (UserService.cs)
     * contains CRUD functionality while working with database. 
     * 
     * Also contains report functionality. 
     */
    public class UserService
    {
        /**
         * Variables allowing access to database and all date validations.
         */
        private readonly VideoTapeContext _context;
        private DateValidations validation;


        /**
         * Constructor.
         */
        public UserService()
        {
            validation = new DateValidations();
            _context = new VideoTapeContext();
        }


        /**
         * Returns user and tapes which are still borrowed.
         */ 
        public object getUserAndBorrow(int id)
        {
            User user = _context.Users.SingleOrDefault(e => e.userId == id);
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == id && e.return_date == null);

            return new { user, borrows };
        }


        /**
         * Returns a user and his borrow history. 
         */ 
        public object getUserAndBorrowHistory(int id)
        {
            User user = _context.Users.SingleOrDefault(e => e.userId == id);

            // If user no longer exists in database.
            if (user == null)
            {
                return null;
            }

            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == id);

            return new { user, borrows };
        }


        /**
         * Returns user's borrowed tapes. 
         */ 
        public IEnumerable<Borrow> getTapes(int id)
        {
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == id);
            return borrows;
        }


        /**
         * Returns a list of all users from database. 
         */ 
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }


        /**
         * Modify user's data with ID.
         */
        public void EditUser(User user, int id)
        {
            user.userId = id;
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }


        /**
         * Adds user to database.
         */
        public void addUser(User user)
        {
            var latestId = _context.Users.Max(p => p.userId);
            user.userId = latestId + 1;

            _context.Users.Add(user);
            _context.SaveChangesAsync();
        }


        /**
         * Returns user from database using his ID.
         */
        public User getUser(int id)
        {
            User user = _context.Users.SingleOrDefault(e => e.userId == id);
            return user;
        }


        /**
         * Deletes user from database.
         * Also removes review and borrow history of the deleted user.
         */
        public void deleteUser(User user)
        {
            IEnumerable<Borrow> borrows = _context.Borrows.Where(e => e.userId == user.userId);
            IEnumerable<Review> reviews = _context.Reviews.Where(e => e.userId == user.userId);
            _context.Borrows.RemoveRange(borrows);
            _context.Reviews.RemoveRange(reviews);
            _context.Users.Remove(user);
            _context.SaveChangesAsync();
        }


        /**
         * Returns a list of users with tapes borrowed on a given date from query.
         */
        public IEnumerable<User> usersWithTapesBorrowedOnDate(string sDate)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<User> usersWithBorrowedTapes = new List<User>();

            // Loop through all borrowed tapes.
            foreach (var tape in borrowedTapes)
            {
                // If the tape's dates in question are validated, add the user who borrowed it to list.
                if (validation.validateDate(tape.borrow_date, tape.return_date, sDate))
                {
                    var userWithTape = getUser(tape.userId);
                    usersWithBorrowedTapes.Add(userWithTape);
                }
            }

            return usersWithBorrowedTapes;
        }


        /**
         * Returns a list of users with tapes borrowed after the time/duration given from query.
         */
        public IEnumerable<User> usersWithTapesBorrowedAfterDuration(string sDuration)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<User> usersWithBorrowedTapes = new List<User>();

            int duration = Int32.Parse(sDuration);

            // Loop through all borrowed tapes.
            foreach (var tape in borrowedTapes)
            {
                // If the tape's dates in question are validated, add the user who borrowed it to list.
                if (validation.validateAfterDuration(tape.borrow_date, tape.return_date, duration))
                {
                    var userWithTape = getUser(tape.userId);
                    usersWithBorrowedTapes.Add(userWithTape);
                }
            }

            return usersWithBorrowedTapes;
        }


        /**
         * Returns a list of users with tapes borrowed on date and after time/duration given from query.
         */
        public IEnumerable<User> usersWithTapesBorrowedOnDateAfterDuration(string sDate, string sDuration)
        {
            IEnumerable<Borrow> borrowedTapes = _context.Borrows;
            List<User> usersWithBorrowedTapesAfterDuration = new List<User>();
            int duration = Int32.Parse(sDuration);

            // Loop through all borrowed tapes.
            foreach (var tape in borrowedTapes)
            {
                // Check first if the tape's dates in question are validated.
                if (validation.validateDate(tape.borrow_date, tape.return_date, sDate))
                {
                    // Then check if tape is still on loan after the given duration. 
                    // If so, add it to the list.
                    if (validation.validateAfterDuration(tape.borrow_date, tape.return_date, duration))
                    {
                        var userWithTape = getUser(tape.userId);
                        usersWithBorrowedTapesAfterDuration.Add(userWithTape);
                    }
                }
            }

            return usersWithBorrowedTapesAfterDuration;
        }


        /**
         * Returns true if user exists in database.
         */
        public bool checkIfExists(int id)
        {
            return _context.Users.Any(e => e.userId == id);
        }
    }
}

