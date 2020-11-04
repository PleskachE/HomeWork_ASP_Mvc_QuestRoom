using System.ComponentModel.DataAnnotations.Schema;

namespace QuestRoom.DB.Model
{
    public class Picture
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FotoId { get; set; }
        public int RoomId { get; set; }
        public string Path { get; set; }
        public bool Logo { get; set; }
    }
}