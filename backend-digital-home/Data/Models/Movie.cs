using backend_digital_home.Core.Models;

namespace backend_digital_home.Data.Models
{
    public class Movie : IMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PlayTime { get; set; }
        public int AgeLimit { get; set; }
        public int ReleaseYear { get; set; }
        public string Plot { get; set; }
    }
}
