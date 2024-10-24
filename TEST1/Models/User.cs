namespace TEST1.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<Boat> users = new List<Boat>();
        public bool hasPaid() {

            throw new NotImplementedException();
        }
        
    }

    


}
