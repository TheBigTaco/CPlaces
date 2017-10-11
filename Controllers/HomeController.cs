using Microsoft.AspNetCore.Mvc;
using System;
using Vacation.Models;

namespace Vacation.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/place/clear"), ActionName("Index")]
        public ActionResult ListClear()
        {
            Place.ClearAll();
            return View();
        }
        [Route("/places/list")]
        public ActionResult List()
        {
            if (Request.Form["place-name"] != "")
            {
                Place newPlace = new Place(Request.Form["place-name"], Request.Form["place-image"]);
            }
            return View(Place.GetAll());
        }

        [HttpGet("/places/{id}")]
        public ActionResult ViewPlace(int id)
        {
            return View(Place.Find(id));
        }
    }
}
