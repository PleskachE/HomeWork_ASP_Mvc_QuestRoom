using System.Collections.Generic;

using QuestRoom.Data.Abstractions;
using QuestRoom.Data.Entity;
using QuestRoom.Service.Absractions;

namespace QuestRoom.Service
{
    public class PictureService : IPictureService
    {
        private readonly IDataUnitOfWork _uow;

        public PictureService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void AddPicture(Picture picture)
        {
            _uow.PictureRepository.Create(picture);
            _uow.Commit();
        }

        public Picture GetPictureById(int id)
        {
            return _uow.PictureRepository.GetById(id);
        }

        public IEnumerable<Picture> GetPictures()
        {
            return _uow.PictureRepository.GetAll();
        }

        public void RemovePicture(Picture picture)
        {
            _uow.PictureRepository.Remove(picture);
            _uow.Commit();
        }

        public void UpdatePicture(Picture picture)
        {
            _uow.PictureRepository.Update(picture);
            _uow.Commit();
        }
    }
}
