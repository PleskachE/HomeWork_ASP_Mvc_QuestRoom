using QuestRoom.DB.Model;
using System.Collections.Generic;

namespace QuestRoom.Models
{
    public class RoomsAndPictersContainer
    {
        public IEnumerable<Room> Rooms;

        public IEnumerable<Picture> Pictures;

        public RoomsAndPictersContainer(IEnumerable<Room> rooms, IEnumerable<Picture> pictures)
        {
            this.Rooms = rooms;
            this.Pictures = pictures;
        }
    }
}