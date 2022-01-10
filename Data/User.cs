using System.ComponentModel.DataAnnotations;

namespace MovieRentalCRUD.Data
{
    internal sealed class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(200)]
        public string UserName { get; set;} = String.Empty;

        public List<Movie_User> MovieUser { get; set; } = new List<Movie_User>();
    }
}
