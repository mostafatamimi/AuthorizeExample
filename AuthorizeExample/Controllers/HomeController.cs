using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthorizeExample.Models;
using Microsoft.AspNet.Identity;

namespace AuthorizeExample.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {

            //var LoginID = User.Identity.Name;
            //ViewBag.ID = LoginID;

            var myId = User.Identity.GetUserId();
            

            var myDoctor = db.Doctors.Where(x => x.DoctorID == myId).FirstOrDefault();

            if(myDoctor!=null)
            {
                ViewBag.FullName = myDoctor.FirstName + " " + myDoctor.LastName;
                ViewBag.PhoneNumber = myDoctor.PhoneNumber;
            }

            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}