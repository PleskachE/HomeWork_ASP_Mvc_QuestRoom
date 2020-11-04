using QuestRoom.DB.Model;
using System.Collections.Generic;

namespace QuestRoom.Models
{
    public class RoomContainer
    {
        public Room Room { get; set; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}