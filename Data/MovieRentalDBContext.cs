using Microsoft.EntityFrameworkCore;

namespace MovieRentalCRUD.Data;

internal sealed class MovieRentalDBContext : DbContext
{
    public DbSet<Movie>? Movies { get; set;}
    public DbSet<User>? Users { get; set;}
    public DbSet<MovieCopy>? MoviesCopy { get; set;}

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
        // the relationship is a one to many from movie to movieCopy
        // the relationship is a one to many from user to movieCopy
        
        modelBuilder.Entity<MovieCopy>()
            .HasOne(c => c.Movie)
            .WithMany(m => m.MovieCopies)
            .HasForeignKey(c => c.MovieId);

        modelBuilder.Entity<MovieCopy>()
            .HasOne(c => c.User)
            .WithMany(u => u.MovieCopies)
            .HasForeignKey(c => c.UserId);
           
    }

    // helpers to seed the db initially
    private Movie[] SeedMovie(int numToSeed) 
    {
        Movie[] moviesToSeed = new Movie[numToSeed];
        for (int i = 0; i < moviesToSeed.Length; i++)
        {
            moviesToSeed[i] = new Movie
            {
                MovieName = $"Example Movie {i} Title",
                MovieSummary = $"Example Movie {i} Content",
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
                UserName = $"User {i} Name",
            };
        }
        return usersToSeed;
    }
}

