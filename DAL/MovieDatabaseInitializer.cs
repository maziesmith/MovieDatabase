using MovieDatabase.BL.Domain;

namespace MovieDatabase.DAL
{
    public class MovieDatabaseInitializer
    {
        public static void Initialize(MovieDatabaseDbContext context, bool dropDatabase = false)
        {
            if (dropDatabase)
            {
                context.Database.EnsureDeleted();
            }

            context.Database.EnsureCreated();
        }

    }
}