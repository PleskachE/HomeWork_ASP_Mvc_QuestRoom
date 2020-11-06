using QuestRoom.DB;
using QuestRoom.DB.Model;
using QuestRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoom.Controllers
{
    public class RedactorController : Controller
    {
        private MyDbContext _dbContext;
        private RoomContainer _roomContainer;
        private RoomsAndPictersContainer _roomsAndPictersContainer;


        [HttpGet]
        public ActionResult Index()
        {
            _dbContext = new MyDbContext();
            _roomsAndPictersContainer = new RoomsAndPictersContainer(_dbContext.Rooms, _dbContext.Pictures);
            return View(_roomsAndPictersContainer);
        }

        [HttpGet]
        public ActionResult Update(int? id)
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

        [HttpPost]
        public ActionResult Update(RoomContainer container)
        {
            _dbContext = new MyDbContext();
            _dbContext.Rooms.Remove(_dbContext.Rooms.ToList().Find(x => x.RoomId == container.Room.RoomId));
            _dbContext.Rooms.Add(container.Room);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            _dbContext = new MyDbContext();
            _dbContext.Rooms.Remove(_dbContext.Rooms.ToList().Find(x => x.RoomId == id));
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Room room)
        {
            _dbContext = new MyDbContext();
            _dbContext.Rooms.Add(room);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}