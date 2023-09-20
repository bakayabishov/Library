using LibraryApp.DataAccess.Entities;
using LibraryApp.DataAccess.Entities.Configurations;
using LibraryApp.DataAccess.Entities.Seeds;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new PartitionConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.Seed(new UserSeeds());
            modelBuilder.Seed(new AuthorSeeds());
            modelBuilder.Seed(new PartitionSeeds());
            modelBuilder.Seed(new BookSeeds());
        }

        public static DbSet<User> Users { get; set; }
        public static DbSet<Book> Books { get; set; }
        public static DbSet<Partition> Partitions { get; set; }
        public static DbSet<Author> Authors { get; set; }
    }
}