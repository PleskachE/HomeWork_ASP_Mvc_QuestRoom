using System.Linq;
using System.Web.Mvc;

namespace QuestRoom.Controllers
{
    public class RedactorController : Controller
    {



        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
           
            return View();
        }

        [HttpPost]
        public ActionResult Update()
        {
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create()
        //{
            
        //    return RedirectToAction("Index");
        //}
    }
}