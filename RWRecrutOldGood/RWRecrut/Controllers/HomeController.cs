using RWRecrut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWRecrut.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            //try
            //{
            //    RWRDataContext dCon = new RWRDataContext();
            //    var res = dCon.ContactTypes;
            //    ContactType ct = new ContactType{Type = "AIM"};
            //    dCon.ContactTypes.Add(ct);
            //    dCon.SaveChanges();
            //}
            //catch(Exception ex)
            //{

            //}

            return View();
        }

        
        //[HttpPost]
        //public ActionResult Index(Candidate model)
        //{
        //    return View("CreateCandidate");
        //}

        //public 

    }
}
