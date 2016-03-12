using RecruitRW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitRW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
             //   InitDbManually();
                

            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index", "Candidates", null);
           // return View();
        }

        private void InitDbManually()
        {
            using (RecruitContext db = new RecruitContext())
            {
                //db.Database.Initialize(false);

                //var test = db.ContactTypes;
                db.ContactTypes.Add(new ContactType { TypeName = "Tel" });
                db.SaveChanges();
                var test = db.ContactTypes;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}