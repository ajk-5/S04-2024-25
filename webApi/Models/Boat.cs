namespace webApi.Models
{
    public class Boat
    {
        public int ID { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<User> users = new List<User>();
        public bool canPass { get; set; }


    }
    
}
