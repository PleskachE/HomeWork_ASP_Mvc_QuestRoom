using System;

namespace QuestRoom.Base.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
