
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace BooksGallery.Controllers{
    public class BooksController : Controller {
        public ActionResult Detail() {
            return View();
            }
        }
    }