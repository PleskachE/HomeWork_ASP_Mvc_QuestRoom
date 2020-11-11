using System.Collections.Generic;

using QuestRoom.Data.Entity;

namespace QuestRoom.Service.Absractions
{
    public interface IPictureService
    {
        void AddPicture(Picture picture);

        void RemovePicture(Picture picture);

        void UpdatePicture(Picture picture);

        Picture GetPictureById(int id);

        IEnumerable<Picture> GetPictures();
    }
}
