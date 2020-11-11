using System.Collections.Generic;

using QuestRoom.Data.Entity;

namespace QuestRoom.Service.Absractions
{
    public interface IRoomService
    {
        void AddRoom(Room room);

        void RemoveRoom(Room room);

        void UpdateRoom(Room room);

        Room GetRoomById(int id);

        IEnumerable<Room> GetRooms();
    }
}
