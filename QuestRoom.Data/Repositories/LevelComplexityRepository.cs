using System.Data.Entity;

using QuestRoom.Data.Abstractions.Repositories;
using QuestRoom.Data.Entity;

namespace QuestRoom.Data.Repositories
{
    internal class LevelComplexityRepository : Repository<LevelComplexity>, ILevelComplexityRepository
    {
        public LevelComplexityRepository(DbContext context) : base(context)
        {

        }
    }
}
