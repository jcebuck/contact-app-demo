using ContactApplication.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactApplication.Controllers
{
    [Authorize]
    public class MapController : Controller
    {
        private readonly ContactService _contactService;

        public MapController()
        {
            _contactService = new ContactService();
        }

        // GET: Map
        public ActionResult Index(string email)
        {
            ViewBag.gMapsApiKey = ConfigurationManager.AppSettings["gMapsApiKey"];
            var contact = _contactService.GetContactByEmail(email);
            return View(contact);
        }
    }
}