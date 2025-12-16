using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // Calculates the monthly insurance quote based on business rules
        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m; // base

            // Calculate age
            var today = DateTime.Today;
            int age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth.Date > today.AddYears(-age)) age--;

            // Age rules
            if (age <= 18)
            {
                quote += 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                quote += 50m;
            }
            else // 26+
            {
                quote += 25m;
            }

            // Car year rules
            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            }
            if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            // Porsche rules
            if (!string.IsNullOrEmpty(insuree.CarMake) &&
                insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25m;

                if (!string.IsNullOrEmpty(insuree.CarModel) &&
                    insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25m;
                }
            }

            // Speeding tickets
            quote += insuree.SpeedingTickets * 10m;

            // DUI (25% increase)
            if (insuree.DUI)
            {
                quote *= 1.25m;
            }

            // Coverage type (treat "Full" as full coverage)
            if (!string.IsNullOrWhiteSpace(insuree.CoverageType) &&
                insuree.CoverageType.Trim().ToLower().Contains("full"))
            {
                quote *= 1.5m;
            }

            return Math.Round(quote, 2);
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Automatically calculate quote based on user input
                insuree.Quote = CalculateQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Recalculate quote whenever the insuree is edited
                insuree.Quote = CalculateQuote(insuree);

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Admin
        // Displays all quotes for an administrator
        public ActionResult Admin()
        {
            var insurees = db.Insurees.ToList();
            return View(insurees);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

