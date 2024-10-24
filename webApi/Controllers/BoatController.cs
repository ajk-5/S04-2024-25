using Microsoft.AspNetCore.Mvc;
using System.Linq;
using webApi.Data;
using webApi.Models;
using webApi.Service.Mappers;

namespace webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoatController : ControllerBase
    {
        private readonly AppDbContext DbContext;


         
        private static List<Boat> boats= new List<Boat>()
        {
            new Boat() { ID = 1, Name= "aaea", Description="vavbig shipsd"}
            , new Boat() { ID = 2,Name="boat", Description="cruise"},
        };
        [HttpGet("{Id}")]
        public BoatMapper GetBoats(int Id) {
            string Name = Boat.Name;

            var User= new BoatMapper() {
                UserID = Name.DbContext.Users.FirstOrDefault(u => u.ID == Id); 
            }
            
        }

        [HttpGet]
        public List<Boat> getAllBoats() { return boats; }

        [HttpGet("{Id}")]
        public IActionResult getBoats(int Id)
        {
            Boat? boat = boats.FirstOrDefault(u => u.ID == Id);


            if (boat == null)
            {
                return NotFound("{Id} doesnot esists");
            }
            return Ok(boat);
        }


        [HttpPost]
        public Boat PostUser(Boat boat)
        {
            boats.Add(boat);
            return boat;
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteBoat(int Id)
        {
            var boat = boats.FirstOrDefault(u => u.ID == Id);
            if (boat == null)
            {
                return NotFound("{Id} not found");

            }
            boats.Remove(boat);
            return Ok("{Id} deleted");

        }
        [HttpPut("{Id}")]
        public IActionResult UpdateBoat(int Id, [FromBody] Boat updatedBoat)
        {
            var boat = boats.FirstOrDefault(u => u.ID == Id);
            if (boat == null)
            {
                return NotFound("{Id} not found");

            }
            boat.Name = updatedBoat.Name;
            boat.Description = updatedBoat.Description;
            return Ok(boat);

        }

    }
}

