using System.ComponentModel.DataAnnotations;

namespace MovieRentalCRUD.Data
{
    internal sealed class Movie
    {
        [Key]
        public Guid MovieId { get; set; } = new Guid();

        [Required]
        [MaxLength(200)]
        public string MovieName { get; set; } = String.Empty;

        [Required]
        [MaxLength(2000)]
        public string MovieSummary { get; set; } = String.Empty;

        [Required]
        public int MovieYear { get; set; }

        public List<MovieCopy> MovieCopies { get; set; } = new List<MovieCopy>();

    }

}
