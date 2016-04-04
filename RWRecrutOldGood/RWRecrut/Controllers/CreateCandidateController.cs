using RWRecrut.Models;
using RWRecrut.Models.StoreInteractors;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RWRecrut.Controllers
{
    public class CreateCandidateController : Controller
    {
        public CreateCandidateController()
        {
        }

        private DataProvider _Store
        {
            get { return DataProvider.Instance; }
        }

        private CandidateInformation currentCandidateGlobal;

        [HttpGet]
        public ActionResult CandidateProfile()
        {
            if (currentCandidateGlobal == null)
                currentCandidateGlobal = new CandidateInformation();
            return View(currentCandidateGlobal);
        }

        [HttpPost]
        public ActionResult CandidateProfile(CandidateInformation currentCandidate)
        {
            var res = ModelState.Values;
            var res2 = ModelState.IsValid;
         //   currentCandidate.AddNewContact(currentCandidate.ContactModel);
            return View(currentCandidate);
        }


        

        [HttpPost]
        public ActionResult AddNewContact(CandidateInformation currentCandidate)
        {
            currentCandidate.AddNewContact(currentCandidate.ContactModel);
            return View("CandidateProfile",currentCandidate);
        }

        [HttpPost]
        public ActionResult AddNewSkill(CandidateInformation currentCandidate)
        {
            currentCandidate.AddNewSkill(currentCandidate.NewSkill);
            return View("CandidateProfile", currentCandidate);
        }
     /*   public ActionResult AddContactInformation()
        {
            return View(new List<CandidateContactModel>() { new CandidateContactModel() });
        }

        //[HttpPost]
        //public ActionResult CandidateProfile(CandidateContactModel currentCandidate)
        //{
        //    var es = ModelState.Values;

        //    var candInfo = new CandidateInformation();
        //    candInfo.ContactModel = new CandidateContactModel { NewContactData = "modelState1", NewContactType = "ModelStateType" };
        //    return View(candInfo);
        //}

        [HttpPost]
        public ActionResult CandidateProfileUpdate(CandidateInformation candidat)
        {
            var es = ModelState.Values;
            return View();
        }

        [HttpPut]
        public ActionResult CandidateContactUpdate(CandidateInformation candidat)
        {
            return View(candidat);
        }

        [HttpPost]
        public ActionResult AddNewContactToCandidate(CandidateContactModel contact)
        {
            //currentCandidate.AddNewContact(contact);
            return PartialView(contact);
        }

        //public ActionResult ContactA()
        //{
        //    return View();
        //}
        [ChildActionOnly]
        [HttpPost]
        public ActionResult DeleteContactInformation(string s1, string s2)
        {
            return View();
        }

        public ActionResult ContactA(Contact cs)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ContactA(string contactV1)
        {
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult Contacts()
        {
            // Contact cs = new Contact();
            return PartialView();
        }

        [ChildActionOnly]
        [HttpPost]
        public PartialViewResult Contacts(Contact ct)
        {
            // Contact cs = new Contact();
            return PartialView();
        }*/
    }
}