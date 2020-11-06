using QuestRoom.DB;
using QuestRoom.Models;
using System.Linq;
using System.Web.Mvc;

namespace QuestRoom.Controllers
{
    public class RoomController : Controller
    {
        private MyDbContext _dbContext;
        private RoomsAndPictersContainer _roomsAndPictersContainer;
        private RoomContainer _roomContainer;

        [HttpGet]
        public ActionResult Index()
        {
           _dbContext = new MyDbContext();
            _roomsAndPictersContainer = new RoomsAndPictersContainer(_dbContext.Rooms,
                _dbContext.Pictures.ToList().FindAll(x => x.Logo == true));
            return View(_roomsAndPictersContainer);
        }

        [HttpGet]
        public ActionResult Result(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            _dbContext = new MyDbContext();
            _roomContainer = new RoomContainer()
            {
                Room = _dbContext.Rooms.ToList().Find(x => x.RoomId == id),
                Pictures = _dbContext.Pictures.ToList().FindAll(x => x.RoomId == id)
            };
            return View(_roomContainer);
        }
    }
}