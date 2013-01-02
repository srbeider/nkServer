using nk.ServerBase.Contracts;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class UsersController : Controller
    {
        [HttpPost]
        public ActionResult GetUserById(ServiceArgs<string> data)
        {
            return View();
        }

        public ActionResult Nuria()
        {
            return View();
        }

        public ActionResult Marc()
        {
            return View();
        }

        public ActionResult Pablo()
        {
            return View();
        }

        public ActionResult Ray()
        {
            return View();
        }

        public ActionResult Steff()
        {
            return View();
        }

        public ActionResult Inventat()
        {
            return View();
        }
    }
}