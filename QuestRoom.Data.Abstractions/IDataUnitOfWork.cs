using QuestRoom.Base.Abstractions;
using QuestRoom.Data.Abstractions.Repositories;

namespace QuestRoom.Data.Abstractions
{
    public interface IDataUnitOfWork : IUnitOfWork
    {
        IRoomRepository RoomRepository { get; }

        IPictureRepository PictureRepository { get; }
        ITypeRoomRepository TypeRoomRepository { get; }
        ILevelComplexityRepository LevelComplexityRepository { get; }
    }
}
