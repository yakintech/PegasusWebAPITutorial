using Microsoft.AspNetCore.Mvc;
using PegasusWebAPITutorial.Models.ORM;

namespace PegasusWebAPITutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        PegasusContext context;
        public UserController()
        {
            context = new PegasusContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = context.Users.ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var user = context.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return NotFound("User not found!");
            }
            else
            {
                return Ok(user);
            }
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            if (user == null)
            {
                return NotFound("User no found!");
            }
            else
            {
                context.Remove(user);
                context.SaveChanges();
                return Ok(user);
            }
        }


        [HttpPut]
        public IActionResult Put(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return Ok(user);
        }
    }
}
