using System.Collections.Generic;

using QuestRoom.Data.Entity;

namespace QuestRoom.Service.Absractions
{
    public interface ILevelComplexityService
    {
        void AddLevelComplexity(LevelComplexity levelComplexity);

        void RemoveLevelComplexity(LevelComplexity levelComplexity);

        void UpdateLevelComplexity(LevelComplexity levelComplexity);

        LevelComplexity GetLevelComplexityById(int id);

        IEnumerable<LevelComplexity> GetLevelComplexity();
    }
}
