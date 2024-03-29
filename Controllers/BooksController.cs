
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BooksGallery.Controllers{
    public class BooksController : Controller {
        public ActionResult Detail() {
    ViewBag.SeriesTitle = "The Amazing Spider-Man";
    ViewBag.IssueNumber = 700;
    ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
    ViewBag.Artists = new [] {
        "Script: Dan Slott",
        "Pencils: Humberto Ramos",
        "Inks: Victor Olazaba",
        "Colors: Edgar Delgado",
        "Letters: Chris Eliopoulos"
    };
            return View();
            }
        }
    }