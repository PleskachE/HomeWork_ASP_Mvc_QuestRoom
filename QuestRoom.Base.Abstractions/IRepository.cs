﻿using System.Collections.Generic;

namespace QuestRoom.Base.Abstractions
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
