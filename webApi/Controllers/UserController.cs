using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webApi.Data;
using webApi.Models;

namespace webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly  AppDbContext Dbcontext;

        private static List<User> users = new List<User>()
        {
            new User() { ID = 1, Username= "aaa", Password="vavsd"}
            , new User() { ID = 2,Username="bbb", Password="sahds"},
        };

        [HttpGet]
        public List<User> getAllUsers() { return Dbcontext.Users.ToList(); }

        [HttpGet("{Id}")]
        public IActionResult getUsers(int Id)
        { User? user = Dbcontext.Users.FirstOrDefault(u => u.ID == Id);


            if (user == null) {
                return NotFound("{Id} doesnot esists");
            }
            return Ok(user);
        }


        [HttpPost]
        public User PostUser(User user)
        {
            users.Add(user);
            return user;
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteUser(int Id)
        {
            var user = users.FirstOrDefault(u => u.ID == Id);
            if (user == null)
            {
                return NotFound("{Id} not found");

            }
            Dbcontext.Users.Remove(user);
            return Ok("Id is deleted");

        }
        [HttpPut("{Id}")]
        public IActionResult UpdateUser(int Id, [FromBody] User updatedUser) 
        {
            var user = Dbcontext.Users.FirstOrDefault(u => u.ID == Id);
            if (user == null)
            {
                return NotFound("{Id} not found");

            }
            Dbcontext.Users.Username=updatedUser.Username;
            Dbcontext.Users.Password=updatedUser.Password;
            return Ok(user);
            
        }

    }
}
