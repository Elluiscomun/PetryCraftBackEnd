using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swagger5._0.Data;
using Swagger5._0.Model;

namespace Swagger5._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //var dbUser = await _context.Users.FirstOrDefaultAsync(m => m.Email == user.Email && m.Password == user.Password);
            var dbUser = await _context.Users.FirstOrDefaultAsync(m => m.Email_User == user.Email_User && m.Password_User == user.Password_User);
            if (dbUser == null)
            {
                return Unauthorized();
            }

            return Ok(dbUser);
        }
    }
}