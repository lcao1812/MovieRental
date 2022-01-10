namespace MovieRentalCRUD.Data
{
    internal sealed class Movie_User
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int MovieId { get; set; }
        public Movie? Movie { get; set; }


    }
}
