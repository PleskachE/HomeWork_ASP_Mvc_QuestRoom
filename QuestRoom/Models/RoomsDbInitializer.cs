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
                Path = "Content/Images/Pictures/Logo1.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 2,
                RoomId = 1,
                Logo = false,
                Path = "Content/Images/Pictures/Foto1-1.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 3,
                RoomId = 1,
                Logo = false,
                Path = "Content/Images/Pictures/Foto1-2.jpg"
            });

            db.Rooms.Add(new Room
            {
                RoomId = 2,
                Name = "Братство масонов",
                Description = "Множеством знаний владеют масоны." +
                " Простые смертные даже не догадываются, " +
                "что за самыми громкими событиями в истории человечества стоят именно они." +
                " Что же произойдет, если эти знания попадут не в те руки?",
                Duration = "60 мин",
                GroupSize = "2 – 5",
                MinimumAge = "12+",
                LevelComplexity = "Средний",
                LevelFear = "Не страшный",
                Rating = "9.6",
                PhoneNumbers = "+5587786769",
                Email = "емейл@by",
                Address = "улица Ленина 1",
                Company = "Весёлые старты"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 4,
                RoomId = 2,
                Logo = true,
                Path = "Content/Images/Pictures/Logo2.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 5,
                RoomId = 2,
                Logo = false,
                Path = "Content/Images/Pictures/Foto2-1.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 6,
                RoomId = 2,
                Logo = false,
                Path = "Content/Images/Pictures/Foto2-2.jpg"
            });

            db.Pictures.Add(new Picture
            {
                FotoId = 7,
                RoomId = 2,
                Logo = false,
                Path = "Content/Images/Pictures/Foto2-3.jpg"
            });

            db.SaveChanges();

            base.Seed(db);
        }
    }
}