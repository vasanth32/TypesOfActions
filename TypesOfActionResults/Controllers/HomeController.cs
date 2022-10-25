using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TypesOfActionResults.Models;

namespace TypesOfActionResults.Controllers
{
    public class HomeController : Controller
    {
        public PartialViewResult Partial()
        {
            return PartialView("_PartialView");
        }

        public ViewResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();

        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Re_Direct()
        {
            return Redirect("https://www.google.com/");
        }
        public ActionResult RedirectToActionResult()
        {
            return RedirectToAction("Index", "Default");
        }

        public ActionResult JsonResult()
        {
            var persons = new List<Person1>
               {
                new Person1{Id=1, FirstName="Harry", LastName="Potter"},
                      new Person1{Id=2, FirstName="James", LastName="Raj"}
               };
            return Json(persons, JsonRequestBehavior.AllowGet);
        }

        public ContentResult Contents()
        {
            return Content("<h3>Here's a custom content header</h3>", "text/html", System.Text.Encoding.UTF8);
        }
        public HttpStatusCodeResult UnauthorizedStatusCode()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "You are not authorized to access this controller action.");
        }
        public HttpStatusCodeResult BadGateway()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "I have no idea what this error means.");
        }
       

    }
}