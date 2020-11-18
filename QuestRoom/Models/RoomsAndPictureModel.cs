using QuestRoom.Service.Absractions;

namespace QuestRoom.Models
{
    public class RoomsAndPictureModel
    {
        public IRoomService RoomService { get; set; }
        public IPictureService PictureService { get; set; }
        public ILevelComplexityService LevelComplexityService { get; set; }
        public ITypeRoomService TypeRoomService { get; set; }

        public RoomsAndPictureModel(IRoomService roomService, IPictureService pictureService,
            ILevelComplexityService levelComplexityService, ITypeRoomService typeRoomService)
        {
            RoomService = roomService;
            PictureService = pictureService;
            TypeRoomService = typeRoomService;
            LevelComplexityService = levelComplexityService;
        }
    }
}