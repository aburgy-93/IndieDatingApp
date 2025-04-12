using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class UsersController(DataContext context) : BaseApiController
{
   [HttpGet]
   public async Task<ActionResult<IEnumerable<User>>> GetUSers()
   {
        var users = await context.Users.ToListAsync();

        return Ok(users);
   }

   [HttpGet("{id:int}")]
   public async Task<ActionResult<User>> GetUser(int id)
   {
        var user = await context.Users.FindAsync(id);

        if(user == null) return NotFound();
        return Ok(user);
   }
}
