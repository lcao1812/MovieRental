using Microsoft.EntityFrameworkCore;

namespace MovieRentalCRUD.Data;

internal sealed class MovieRentalDBContext : DbContext
{
    public DbSet<Movie>? Movies { get; set;}
    public DbSet<User>? Users { get; set;}
    public DbSet<Movie_User>? Movie_User { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) 
    {
        dbContextOptionsBuilder.UseSqlite("Data Source=MovieRentalCRUDSln.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
/*        modelBuilder.Entity<Movie>().HasData(SeedMovie(6));
        modelBuilder.Entity<User>().HasData(SeedUser(10));
*/
        // set up the many to many relationship between the movies and the user
        modelBuilder.Entity<Movie_User>()
            .HasOne(m => m.Movie)
            .WithMany(m => m.MovieUser)
            .HasForeignKey(m => m.MovieId);

        modelBuilder.Entity<Movie_User>()
            .HasOne(u => u.User)
            .WithMany(u => u.MovieUser)
            .HasForeignKey(u => u.UserId);
    }

    // helpers to seed the db initially
    private Movie[] SeedMovie(int numToSeed) 
    {
        Movie[] moviesToSeed = new Movie[numToSeed];
        for (int i = 0; i < moviesToSeed.Length; i++)
        {
            moviesToSeed[i] = new Movie
            {
                MovieId = i + 1,
                MovieName = $"Example Movie {i} Title",
                MovieSummary = $"Example Movie {i} Content",
                MovieStock = 3,
            };
        }
        return moviesToSeed;
    }
    
    private User[] SeedUser(int numToSeed) 
    {
        User[] usersToSeed = new User[numToSeed];
        for (int i = 0; i < usersToSeed.Length; i++)
        {
            usersToSeed[i] = new User
            {
                UserId = i + 1,
                UserName = $"User {i} Name",
            };
        }
        return usersToSeed;
    }
}

