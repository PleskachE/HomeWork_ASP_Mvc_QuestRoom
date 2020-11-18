using System.Collections.Generic;

using QuestRoom.Data.Entity;

namespace QuestRoom.Service.Absractions
{
    public interface ITypeRoomService
    {
        void AddTypeRoom(TypeRoom typeRoom);

        void RemoveTypeRoom(TypeRoom typeRoom);

        void UpdateTypeRoom(TypeRoom typeRoom);

        TypeRoom GetTypeRoomById(int id);

        IEnumerable<TypeRoom> GetTypeRoom();
    }
}
