using QuestRoom.DB.Model;
using System.Data.Entity;

namespace QuestRoom.DB
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DefaultConnection") { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}