using System.Collections.Generic;

using QuestRoom.Data.Abstractions;
using QuestRoom.Data.Entity;
using QuestRoom.Service.Absractions;

namespace QuestRoom.Service
{
    public class RoomService : IRoomService
    {
        private readonly IDataUnitOfWork _uow;

        public RoomService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void AddRoom(Room room)
        {
            _uow.RoomRepository.Create(room);
            _uow.Commit();
        }

        public Room GetRoomById(int id)
        {
            return _uow.RoomRepository.GetById(id);
        }

        public IEnumerable<Room> GetRooms()
        {
            return _uow.RoomRepository.GetAll();
        }

        public void RemoveRoom(Room room)
        {
            _uow.RoomRepository.Remove(room);
            _uow.Commit();
        }

        public void UpdateRoom(Room room)
        {
            _uow.RoomRepository.Update(room);
            _uow.Commit();
        }
    }
}
