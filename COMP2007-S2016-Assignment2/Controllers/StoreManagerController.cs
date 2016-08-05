using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Assignment2.Models;

namespace COMP2007_S2016_Assignment2.Controllers
{
    public class StoreManagerController : Controller
    {
        private RestaurantStoreContext db = new RestaurantStoreContext();


        // GET: MenuManager
        public ActionResult Index()
        {
            var fooditems = db.FoodItems.Include(a => a.FoodType);
            return View(fooditems.ToList());
        }

        // GET: MenuManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem fooditem = db.FoodItems.Find(id);
            if (fooditem == null)
            {
                return HttpNotFound();
            }
            return View(fooditem);
        }


        // GET: MenuManager/Create
        public ActionResult Create()
        {

            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name");
            return View();
        }


        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FoodItems,FoodTypeId,ShortDescriptionId,DetailedDescriptionId,Title,Price,FoodItemUrl,ShortDescription,DetailedDescription")] FoodItem fooditem)
        {
            if (ModelState.IsValid)
            {
                db.FoodItems.Add(fooditem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name", fooditem.FoodTypeId);
            return View(fooditem);
        }






        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem fooditem = db.FoodItems.Find(id);
            if (fooditem == null)
            {
                return HttpNotFound();
            }

            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name", fooditem.FoodTypeId);
            return View(fooditem);
        }



        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FoodItemId,FoodTypeId,ShortDescriptionId,DetailedDescriptionId,Title,Price,FoodItemUrl,ShortDescription,DetailedDescription")] FoodItem fooditem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fooditem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name", fooditem.FoodTypeId);

            return View(fooditem);
        }













        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem fooditem = db.FoodItems.Find(id);
            if (fooditem == null)
            {
                return HttpNotFound();
            }
            return View(fooditem);
        }







        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodItem fooditem = db.FoodItems.Find(id);
            db.FoodItems.Remove(fooditem);
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
