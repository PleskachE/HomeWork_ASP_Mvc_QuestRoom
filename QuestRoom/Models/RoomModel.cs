using QuestRoom.Data.Entity;

namespace QuestRoom.Models
{
    public class RoomModel
    {
        public Room Room { get; set; }
        public TypeRoom TypeRoom {get;set;}
        public LevelComplexity LevelComplexity { get; set; }
        public RoomModel(Room room, TypeRoom typeRoom, LevelComplexity levelComplexity)
        {
            Room = room;
            TypeRoom = typeRoom;
            LevelComplexity = levelComplexity;
        }
    }
}