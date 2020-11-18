using System.Collections.Generic;

using QuestRoom.Data.Abstractions;
using QuestRoom.Data.Entity;
using QuestRoom.Service.Absractions;

namespace QuestRoom.Service
{
    public class TypeRoomService : ITypeRoomService
    {
        private readonly IDataUnitOfWork _uow;

        public TypeRoomService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void AddTypeRoom(TypeRoom typeRoom)
        {
            _uow.TypeRoomRepository.Create(typeRoom);
            _uow.Commit();
        }

        public TypeRoom GetTypeRoomById(int id)
        {
            return _uow.TypeRoomRepository.GetById(id);
        }

        public IEnumerable<TypeRoom> GetTypeRoom()
        {
            return _uow.TypeRoomRepository.GetAll();
        }

        public void RemoveTypeRoom(TypeRoom typeRoom)
        {
            _uow.TypeRoomRepository.Remove(typeRoom);
            _uow.Commit();
        }

        public void UpdateTypeRoom(TypeRoom typeRoom)
        {
            _uow.TypeRoomRepository.Update(typeRoom);
            _uow.Commit();
        }
    }
}
