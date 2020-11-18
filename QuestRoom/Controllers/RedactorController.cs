using QuestRoom.Models;
using QuestRoom.Service.Absractions;
using System.Web.Mvc;

namespace QuestRoom.Controllers
{
    public class RedactorController : Controller
    {

        private RoomsAndPictureModel _roomsAndPictureModel;
        private RedactorRoomModel _redactorRoomModel;

        public RedactorController(IRoomService roomService, IPictureService pictureService,
            ITypeRoomService typeRoomService, ILevelComplexityService levelComplexityService)
        {
            _roomsAndPictureModel = new RoomsAndPictureModel(roomService, pictureService, levelComplexityService, typeRoomService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_roomsAndPictureModel);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var removeRoom = _roomsAndPictureModel.RoomService.GetRoomById(id.Value);
            _roomsAndPictureModel.RoomService.RemoveRoom(removeRoom);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var updateRoom = _roomsAndPictureModel.RoomService.GetRoomById(id.Value);
            _redactorRoomModel = new RedactorRoomModel()
            {
                Room = updateRoom,
                TypeRoomList = new SelectList(_roomsAndPictureModel.TypeRoomService.GetTypeRoom(), "Id", "Name"),
                LevelComplexityList = new SelectList(_roomsAndPictureModel.LevelComplexityService.GetLevelComplexity(), "Id", "Name")
            };
            return View(_redactorRoomModel);
        }

        [HttpPost]
        public ActionResult Update(RedactorRoomModel model)
        {
            _roomsAndPictureModel.RoomService.UpdateRoom(model.Room);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            _redactorRoomModel = new RedactorRoomModel()
            {
                Room = null,
                TypeRoomList = new SelectList(_roomsAndPictureModel.TypeRoomService.GetTypeRoom(), "Id", "Name"),
                LevelComplexityList = new SelectList(_roomsAndPictureModel.LevelComplexityService.GetLevelComplexity(), "Id", "Name")
            };
            return View(_redactorRoomModel);
        }

        [HttpPost]
        public ActionResult Create(RedactorRoomModel model)
        {
            _roomsAndPictureModel.RoomService.AddRoom(model.Room);
            return RedirectToAction("Index");
        }
    }
}