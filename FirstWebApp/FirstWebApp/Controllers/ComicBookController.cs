using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class ComicBooksController : Controller
    {
       
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Hero";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>The best Book in World <strong>HaHaHaHa</strong></p> ";
            ViewBag.Artists = new string[]
            {
        "script : ana",
        "Pencils : ana",
        "Inks : ana",
            };

            return View();
        }
    }
}