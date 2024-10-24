using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEST1.Models;


namespace TEST1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>()
        {
            new User() { Id = 1, Username= "aaa", Password="vavsd"}
            , new User() { Id = 2,Username="bbb", Password="sahds"},
        };

        [HttpGet]
        public List<User> getAllUsers() { return users; }

        [HttpPost]
        public User PostUser(User user)
        {
            users.Add(user);
            return user;
        }



    }
}
