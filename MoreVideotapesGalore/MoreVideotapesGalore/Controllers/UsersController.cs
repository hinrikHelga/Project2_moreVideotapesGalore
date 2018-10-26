using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoreVideotapesGalore.Models.Entities;
using MoreVideotapesGalore.Services;
using VideoTapeNS;

namespace MoreVideotapesGalore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserService us;

        public UsersController(VideoTapeContext context)
        {
            us = new UserService();
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery] string LoanDate, [FromQuery] string LoanDuration)
        {
            if (string.IsNullOrEmpty(LoanDate) && !string.IsNullOrEmpty(LoanDuration))
            {
                return Ok(us.usersWithTapesBorrowedAfterDuration(LoanDuration));
            }

            else if (string.IsNullOrEmpty(LoanDate))
            {
                return Ok(us.GetAllUsers());
            }
            
            else
            {
                return Ok(us.usersWithTapesBorrowedAtDate(LoanDate));
            }
            
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = us.getUserAndBorrowHistory(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("{id}/tapes")]
        public async Task<IActionResult> GetUserTapes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tapesOnLoan = us.getUserAndBorrow(id);

            if (tapesOnLoan == null)
            {
                return NotFound();
            }

            return Ok(tapesOnLoan );
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.userId)
            {
                return BadRequest();
            }


            try
            {
                us.EditUser(user, id);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            us.addUser(user);

            return CreatedAtAction("GetUser", new { id = user.userId }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = us.getUser(id);

            if (user == null)
            {
                return NotFound();
            }

            us.deleteUser(user);

            return Ok(user);
        }

        // Move to services?
        private bool UserExists(int id)
        {
            return us.checkIfExists(id);
        }
    }
}
