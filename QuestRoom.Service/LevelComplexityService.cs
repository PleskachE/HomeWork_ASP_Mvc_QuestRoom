using System.Collections.Generic;

using QuestRoom.Data.Abstractions;
using QuestRoom.Data.Entity;
using QuestRoom.Service.Absractions;

namespace QuestRoom.Service
{
    public class LevelComplexityService : ILevelComplexityService
    {
        private readonly IDataUnitOfWork _uow;

        public LevelComplexityService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void AddLevelComplexity(LevelComplexity levelComplexity)
        {
            _uow.LevelComplexityRepository.Create(levelComplexity);
            _uow.Commit();
        }

        public LevelComplexity GetLevelComplexityById(int id)
        {
            return _uow.LevelComplexityRepository.GetById(id);
        }

        public IEnumerable<LevelComplexity> GetLevelComplexity()
        {
            return _uow.LevelComplexityRepository.GetAll();
        }

        public void RemoveLevelComplexity(LevelComplexity levelComplexity)
        {
            _uow.LevelComplexityRepository.Remove(levelComplexity);
            _uow.Commit();
        }

        public void UpdateLevelComplexity(LevelComplexity levelComplexity)
        {
            _uow.LevelComplexityRepository.Update(levelComplexity);
            _uow.Commit();
        }
    }
}
