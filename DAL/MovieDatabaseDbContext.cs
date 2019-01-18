namespace MovieDatabase.DAL
{
    using BL.Domain;
    using Microsoft.EntityFrameworkCore;

    public class MovieDatabaseDbContext : DbContext
    {
        public DbSet<Media> Media { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }

        //TODO: nodig?
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorAct> ActorActs { get; set; }

        public MovieDatabaseDbContext()
        {
            MovieDatabaseInitializer.Initialize(this, true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=../DAL/MovieDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setup inheritance in db
            modelBuilder.Entity<Media>()
                .ToTable("Media")
                .HasDiscriminator(m => m.MediaType)
                .HasValue<Movie>(MediaType.Movie)
                .HasValue<Series>(MediaType.Series);

            // Configure many-to-many Actors-Media
            modelBuilder.Entity<ActorAct>().HasKey(aa => new {aa.MediaId, aa.ActorId});

            // Configure many-to-many Genre-Media
            modelBuilder.Entity<MediaGenre>().HasKey(mg => new {mg.GenreId, mg.MediaId});

            // Genre name unique
            modelBuilder.Entity<Genre>().HasIndex(g => g.Name).IsUnique();
        }
    }
}