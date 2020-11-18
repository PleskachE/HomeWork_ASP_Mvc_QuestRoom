using QuestRoom.Data.Entity;
using System.Web.Mvc;

namespace QuestRoom.Models
{
    public class RedactorRoomModel
    {
        public Room Room { get; set; }
        public SelectList TypeRoomList { get; set; }
        public SelectList LevelComplexityList { get; set; }
    }
}