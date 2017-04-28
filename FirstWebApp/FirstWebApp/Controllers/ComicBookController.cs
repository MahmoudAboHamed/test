using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApp.Models;

namespace FirstWebApp.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>The best Book in World <strong>HaHaHaHa</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {name = "ana", Role = "script"},
                    new Artist() {name = "ana", Role = "Pencils"},
                    new Artist() {name = "ana", Role = "Inks"}
                }
            };

            return View(comicBook);
        }
    }
}