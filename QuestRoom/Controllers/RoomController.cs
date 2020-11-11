using QuestRoom.Service.Absractions;
using System.Linq;
using System.Web.Mvc;

namespace QuestRoom.Controllers
{
    public class RoomController : Controller
    {
        private IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            this._roomService = roomService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _roomService.GetRooms();
            return View(model);
        }

        [HttpGet]
        public ActionResult Result(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var model = _roomService.GetRoomById(id.Value);
            return View(model);
        }
    }
}