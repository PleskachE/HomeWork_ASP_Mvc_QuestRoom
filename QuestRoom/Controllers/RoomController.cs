using System.Linq;
using System.Web.Mvc;

using QuestRoom.Models;
using QuestRoom.Service.Absractions;

namespace QuestRoom.Controllers
{
    public class RoomController : Controller
    {
        private IRoomService _roomService;
        private IPictureService _pictureService;
        private ITypeRoomService _typeRoomService;
        private ILevelComplexityService _levelComplexityService;
        public RoomController(IRoomService roomService, IPictureService pictureService,
            ITypeRoomService typeRoomService, ILevelComplexityService levelComplexityService)
        {
            this._roomService = roomService;
            this._pictureService = pictureService;
            _typeRoomService = typeRoomService;
            _levelComplexityService = levelComplexityService;
        }

        [HttpGet]
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var room = _roomService.GetRoomById(id.Value);
            var typeRoom = _typeRoomService.GetTypeRoomById(room.TypeRoomId);
            var levelComplexity = _levelComplexityService.GetLevelComplexityById(room.LevelComplexityId);
            RoomModel model = new RoomModel(room, typeRoom, levelComplexity);
            model.Room.Pictures = _pictureService.GetPictures().ToList().FindAll(x => x.RoomId == id);
            return View(model);
        }

        [HttpGet]
        public ActionResult TypeRoom(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var model = new CategoryRoomsModel();
            model.Rooms = _roomService.GetRooms().ToList().FindAll(x => x.TypeRoomId == id);
            return View(model);
        }

        [HttpGet]
        public ActionResult LevelComplexity(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var model = new CategoryRoomsModel();
            model.Rooms = _roomService.GetRooms().ToList().FindAll(x => x.LevelComplexityId == id);
            return View(model);
        }
    }
}