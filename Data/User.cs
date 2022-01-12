using System.ComponentModel.DataAnnotations;

namespace MovieRentalCRUD.Data
{
    internal sealed class User
    {
        [Key]
        public Guid UserId { get; set; } = new Guid();

        [Required]
        [MaxLength(200)]
        public string UserName { get; set;} = String.Empty;

        [Required]
        public DateTime JoinDate { get; set; }

        public List<MovieCopy> MovieCopies { get; set; } = new List<MovieCopy>();

    }
}
