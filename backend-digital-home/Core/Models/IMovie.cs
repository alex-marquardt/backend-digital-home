namespace backend_digital_home.Core.Models
{
    public interface IMovie
    {
        int Id { get; set; }
        string Title { get; set; }
        int PlayTime { get; set; }
        int AgeLimit { get; set; }
        int ReleaseYear { get; set; }
        string Plot { get; set; }
    }
}