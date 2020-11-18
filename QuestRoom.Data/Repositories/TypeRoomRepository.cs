using System.Data.Entity;

using QuestRoom.Data.Abstractions.Repositories;
using QuestRoom.Data.Entity;

namespace QuestRoom.Data.Repositories
{
    internal class TypeRoomRepository : Repository<TypeRoom>, ITypeRoomRepository
    {
        public TypeRoomRepository(DbContext context) : base(context)
        {

        }
    }
}
