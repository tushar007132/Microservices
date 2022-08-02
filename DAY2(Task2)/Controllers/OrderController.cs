using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Task2.Controllers
{
    public class OrderController : Controller
    {
        //private testdbEntities db = new testdbEntities();
        private AssignmentDBEntities db = new AssignmentDBEntities();

        // GET: Order
        public ActionResult Index()
        {
            
            List<Order> oList = db.Orders.ToList();
            return View(oList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId, CustomerName, OrderDate, OrderAmount")] Order sample)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(sample);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sample);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order sample = db.Orders.Find(id);
            if (sample == null)
            {
                return HttpNotFound();
            }
            return View(sample);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId, CustomerName, OrderDate, OrderAmount")] Order sample)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sample).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sample);
        }

    }
}