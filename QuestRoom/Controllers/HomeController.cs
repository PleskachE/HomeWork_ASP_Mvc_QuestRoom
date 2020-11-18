using System.Web.Mvc;

using QuestRoom.Models;
using QuestRoom.Service.Absractions;

namespace QuestRoom.Controllers
{
    public class HomeController : Controller
    {
        private RoomsAndPictureModel _model;

        public HomeController(IRoomService roomService, IPictureService pictureService,
            ITypeRoomService typeRoomService, ILevelComplexityService levelComplexityService)
        {
            _model = new RoomsAndPictureModel(roomService, pictureService, levelComplexityService, typeRoomService);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_model);
        }
    }
}