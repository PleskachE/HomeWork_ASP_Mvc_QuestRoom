using QuestRoom.Data.Entity;
using System.Data.Entity;

namespace QuestRoom.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(string connectionString) : base(connectionString)
        {
            var config = new DataDbConfig();
            DbConfiguration.SetConfiguration(config);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>().ToTable(nameof(Room));
            modelBuilder.Entity<Picture>().ToTable(nameof(Picture));
            modelBuilder.Entity<TypeRoom>().ToTable(nameof(TypeRoom));
            modelBuilder.Entity<LevelComplexity>().ToTable(nameof(LevelComplexity));
        }
    }
}
