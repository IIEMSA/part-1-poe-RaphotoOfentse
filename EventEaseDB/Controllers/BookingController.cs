using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using EventEaseDB.Models;

namespace EventEaseDB.Controllers
{
    public class BookingController : Controller
    {
        private EventEaseDBConsole db = new EventEaseDBConsole();
        /*
        // GET: Booking
        public ActionResult Index()
        {
            return View(db.Bookings.ToList());
        }
        
        /*
        public ActionResult Index()
        {
            try
            {
                var bookings = db.Bookings.ToList();
                return View(bookings);
            }
            catch (Exception ex)
            {
                /*
                // Log the exception to debug further
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Inner Exception: " + ex.InnerException?.Message);

                // Optionally, return an error view
                return View("Error");
                

                // Log the error message to the console or use a logging framework
                Console.WriteLine("Error: " + ex.Message);
                ViewBag.ErrorMessage = "Error: " + ex.Message;
                return View("Error"); // You can create a custom error vie
            }
        }
        */
        //new table
        // GET: Booking/Details/5

        // GET: Event
        public ActionResult Index()
        {
            return View(db.Bookings.ToList());
          
        }
        /*
        public ActionResult Index()
        {
            var bookings = db.Bookings.ToList();

            if (bookings == null || bookings.Count == 0)
            {
                ViewBag.ErrorMessage = "No bookings found.";
                return View("Error"); // Create an error view to display a user-friendly message
            }

            return View(bookings);
        }

        */
public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking @booking = db.Bookings.Find(id);
            if (@booking == null)
            {
                return HttpNotFound();
            }
            return View(@booking);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingID,BookingDate,CustomerName,CustomerEmail,EventName,NumberOfGuests")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Bookings.Add(booking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(booking);
        }

        // GET: Booking/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Booking/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingID,BookingDate,CustomerName,CustomerEmail,EventName,NumberOfGuests")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(booking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Booking/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
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
