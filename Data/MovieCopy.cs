using System.ComponentModel.DataAnnotations;

namespace MovieRentalCRUD.Data
{
    internal sealed class MovieCopy
    {
        [Key] 
        public Guid CopyId { get; set; } = new Guid();

        [Required]
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }

        public DateTime? DateRent { get; set; }
    }
}
