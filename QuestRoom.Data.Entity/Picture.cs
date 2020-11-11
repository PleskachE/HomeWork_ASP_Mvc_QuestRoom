using QuestRoom.Base.Abstractions;

namespace QuestRoom.Data.Entity
{
    public class Picture : BaseEntity
    {
        public int RoomId { get; set; }
        public string Path { get; set; }
        public bool Logo { get; set; }
    }
}
