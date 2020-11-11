using System.Data.Entity;

using QuestRoom.Data.Abstractions.Repositories;
using QuestRoom.Data.Entity;

namespace QuestRoom.Data.Repositories
{
    internal class PictureRepository : Repository<Picture>, IPictureRepository
    {
        public PictureRepository(DbContext context) : base(context)
        {

        }
    }
}
