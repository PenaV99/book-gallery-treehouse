
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace BooksGallery.Controllers{
    public class BooksController : Controller {
        public ActionResult Detail() {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday) {
                return Redirect("/");
            }

            return Content("Hello, from the comic books controller! You suck!!");
            }
        }
    }