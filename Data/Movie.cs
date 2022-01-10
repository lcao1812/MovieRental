using System.ComponentModel.DataAnnotations;

namespace MovieRentalCRUD.Data
{
    internal sealed class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [MaxLength(200)]
        public string MovieName { get; set;} = String.Empty;
        
        [Required]
        [MaxLength(2000)]
        public string MovieSummary { get; set;} = String.Empty;

        public int MovieStock { get; set; } = 0;

        public List<Movie_User> MovieUser { get; set; } = new List<Movie_User>();
    }
}
