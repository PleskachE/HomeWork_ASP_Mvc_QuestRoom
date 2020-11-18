using QuestRoom.Data.Entity;
using System.Collections.Generic;

namespace QuestRoom.Models
{
    public class CategoryRoomsModel
    {
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}