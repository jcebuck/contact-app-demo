using ContactApplication.Services;
using System.Web.Mvc;

namespace ContactApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactService _contactService;

        public HomeController()
        {
            // dependency injected service would work better
            // but for this simple application we don't need to worry about it
            _contactService = new ContactService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetContacts()
        {
            return Json(_contactService.GetAllContacts(), JsonRequestBehavior.AllowGet);
        }
    }
}