using System.Data.Entity;

using QuestRoom.Data.Abstractions.Repositories;
using QuestRoom.Data.Entity;

namespace QuestRoom.Data.Repositories
{
    internal class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(DbContext context) : base(context)
        {

        }
    }
}
