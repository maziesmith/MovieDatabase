namespace MovieDatabase.DAL
{
    using BL.Domain;
    using Microsoft.EntityFrameworkCore;

    public class MovieDatabaseDbContext : DbContext
    {
        public DbSet<Media> Media { get; set; }
        public DbSet<MediaGenre> MediaGenres { get; set; }
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
            // Configure many-to-many Actors-Media
            modelBuilder.Entity<ActorAct>().HasKey(aa => new {aa.ActorId, aa.MediaId});

            // Unique actors
            modelBuilder.Entity<Actor>().HasIndex(a => a.Name).IsUnique();

            // On delete Media -> delete related MediaGenres
            modelBuilder.Entity<Media>()
                .HasMany(m => m.MediaGenres)
                .WithOne(mg => mg.Media)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}