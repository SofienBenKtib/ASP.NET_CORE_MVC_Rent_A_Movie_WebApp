namespace RentAMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public Movie()
        {

        }
    }
}
