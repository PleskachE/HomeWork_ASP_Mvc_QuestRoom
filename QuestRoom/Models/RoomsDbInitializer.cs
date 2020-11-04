using QuestRoom.DB;
using QuestRoom.DB.Model;
using System.Data.Entity;

namespace QuestRoom.Models
{
    public class RoomsDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext db)
        {
            db.Rooms.Add(new Room
            {
                RoomId = 1,
                Name = "Сон",
                Description = "Ваш сон может превратиться в страшный кошмар," +
            " кошмар из того самого детства, кошмар, который так хочется забыть," +
            " из которого нельзя вернуться.",
                Duration = "60 мин",
                GroupSize = "2 – 5",
                MinimumAge = "12+",
                LevelComplexity = "Средний",
                LevelFear = "Страшный",
                Rating = "9.7",
                PhoneNumbers = "+5587786769",
                Email = "емейл@by",
                Address = "улица Ленина 1",
                Company = "Весёлые старты"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 1,
                RoomId = 1,
                Logo = true,
                Path = "Images/Pictures/Logo1.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 2,
                RoomId = 1,
                Logo = false,
                Path = "Images/Pictures/Foto1-1.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 3,
                RoomId = 1,
                Logo = false,
                Path = "Images/Pictures/Foto1-2.jpg"
            });
            db.SaveChanges();

            base.Seed(db);
        }
    }
}