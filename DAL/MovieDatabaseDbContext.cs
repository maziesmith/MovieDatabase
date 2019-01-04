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
            optionsBuilder.UseSqlite("Data source=MovieDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setup inheritance in db
            modelBuilder.Entity<Media>()
                .ToTable("Media")
                .HasDiscriminator(m => m.MediaType)
                .HasValue<Movie>(MediaType.Movie)
                .HasValue<Series>(MediaType.Series);

            // Prevent navigation error
            modelBuilder.Entity<Media>().Ignore(c => c.Actors);
            modelBuilder.Entity<Actor>().Ignore(c => c.Media);

            // Configure many-to-many Actors-Media
            modelBuilder.Entity<ActorAct>().Property<int>("ActorId");
            modelBuilder.Entity<ActorAct>().Property<int>("MediaId");
            modelBuilder.Entity<ActorAct>().HasKey("ActorId", "MediaId");

            modelBuilder.Entity<ActorAct>()
                .HasOne(aa => aa.Media)
                .WithMany(m => m.ActorActs)
                .HasForeignKey("MediaId"); // Properties not defined in class --> no lambda

            modelBuilder.Entity<ActorAct>()
                .HasOne(aa => aa.Actor)
                .WithMany(a => a.ActorActs)
                .HasForeignKey("ActorId"); // Properties not defined in class --> no lambda

            // Genre name unique
            modelBuilder.Entity<Genre>().HasIndex(g => g.Name).IsUnique();
        }
    }
}