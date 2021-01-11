using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        //dependency injection using contructor to fetch database 
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        //adding 2 endPoint

        //1st end point to fetch all content
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //ToList() is a linq method
            return await _context.Users.ToListAsync();
        }
        //type this inbrwoser https://localhost:5001/api/users after running the programcs

        //2nd end point to get user by id
        [HttpGet("{id}")]//("{id}") --> api/users/3
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }


    }
}