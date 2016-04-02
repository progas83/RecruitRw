using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RecruitRW.Models;

namespace RecruitRW.Controllers
{
    public class CandidatesController : Controller
    {
        private RecruitContext db = new RecruitContext();

        // GET: Candidates
        public ActionResult Index()
        {
           IEnumerable<Candidate> candidates = db.Candidates.Include(c => c.Adress).ToList();

            return View(candidates);
        }

        // GET: Candidates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidate candidate = db.Candidates.Find(id);
            if (candidate == null)
            {
                return HttpNotFound();
            }
            return View(candidate);
        }

        // GET: Candidates/Create
        public ActionResult Create()
        {
            // ViewBag.Id = new SelectList(db.Adresses, "CandidateId", "City");
            Candidate candidate = new Candidate();
            candidate.Adress = new Adress();
            candidate.Skills = new List<Skill>();
            candidate.RegistrationDate = DateTime.UtcNow.Date;
            return View(candidate);
        }

        public PartialViewResult _GetSkills(Candidate candidate)
        {
            if (candidate.Skills == null)
                candidate.Skills = new List<Skill>();
            //List<Skill> skills = new List<Skill>();
            //skills.Add(new Skill { SkillName = "ASP", SkillValue = 10 });
            //if(Id!=0)
            //{
            //    List<Skill> skills1 = db.Candidates.Include("Skills").FirstOrDefault(item => item.Id == Id).Skills.ToList();
            //    if (skills1 != null)
            //        skills = skills1;
            //}
            return PartialView("_Skills", candidate.Skills);
        }

        public PartialViewResult _AddSkill(Skill s)
        {
           
            return PartialView("_SkillAdd", s);
        }

        public PartialViewResult _AddNewSkill(Candidate candidate, Skill s)
        {
            candidate.Skills.Add(s);

            return PartialView("_Skills", candidate.Skills);
           // return PartialView("_SkillAdd", s);
        }

        [ChildActionOnly()]
        public PartialViewResult _AdressPartial(Adress adress)
        {
            return PartialView("_Adress", adress);
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Id,FirstName,SecondName,RegistrationDate,ConversationDate,Adress")] Candidate candidate,Adress adress)
        public ActionResult Create(Candidate candidate,Adress adress,IEnumerable<Skill> skill)
        {
            if (ModelState.IsValid)
            {
                db.Candidates.Add(candidate);
                adress.Candidate = candidate;
                db.Adresses.Add(adress);
                if(skill!=null)
                    foreach(Skill sk in skill)
                    {
                        sk.Candidate = candidate;
                        db.Skills.Add(sk);
                    }
              //  skill.Candidate = candidate;
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Adresses, "CandidateId", "City", candidate.Id);
            return View(candidate);
        }

        // GET: Candidates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidate candidate = db.Candidates.Find(id);
            if (candidate == null)
            {
                return HttpNotFound();
            }
         //  Adress adress =  new Adress { City = "ZP" };
         //   adress.Candidate = candidate;

          //  db.Adresses.Add(adress);
           // db.SaveChanges();
            //candidate.Adress = 
            ViewBag.Id = new SelectList(db.Adresses, "CandidateId", "City", candidate.Id);
            return View(candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,SecondName,RegistrationDate,ConversationDate")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Adresses, "CandidateId", "City", candidate.Id);
            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candidate candidate = db.Candidates.Find(id);
            if (candidate == null)
            {
                return HttpNotFound();
            }
            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candidate candidate = db.Candidates.Find(id);
            db.Candidates.Remove(candidate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
