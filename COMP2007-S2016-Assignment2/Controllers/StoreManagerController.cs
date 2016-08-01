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


/* File Name: COMP2007_S2016_Assignment2
 * Author: Yandong Wang  200277628
 * File Description: Create a website that allow customer to view the cuisines.
 * WebSite Name: Garden Restaurant
 */

namespace COMP2007_S2016_Assignment2.Controllers
{
    public class StoreManagerController : Controller
    {
        private RestaurantStoreContext db = new RestaurantStoreContext();

        // GET: StoreManager
        public ActionResult Index()
        {
            var submenus = db.SubMenus.Include(a => a.ShortDescription).Include(a => a.FoodType);
            return View(submenus.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubMenu submenu = db.SubMenus.Find(id);
            if (submenu == null)
            {
                return HttpNotFound();
            }
            return View(submenu);
        }



        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.ShortDescriptionId = new SelectList(db.ShortDescriptions, "ShortDescriptionId", "Flavour");
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name");
            return View();
        }


        // POST: StoreManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubMenuId,FoodTypeId,ShortDescriptionId,Title,Price,SubMenuUrl")] SubMenu submenu)
        {
            if (ModelState.IsValid)
            {
                db.SubMenus.Add(submenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ShortDescriptionId = new SelectList(db.ShortDescriptions, "ShortDescriptionId", "Flavour", submenu.ShortDescriptionId);
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name", submenu.FoodTypeId);
            return View(submenu);
        }


        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubMenu submenu = db.SubMenus.Find(id);
            if (submenu == null)
            {
                return HttpNotFound();
            }
            ViewBag.ShortDescriptionId = new SelectList(db.ShortDescriptions, "ShortDescriptionId", "Flavour", submenu.ShortDescriptionId);
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name", submenu.SubMenuId);
            return View(submenu);
        }

        // POST: StoreManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubMenuId,FoodTypeId,ShortDescriptionId,Title,Price,SubMenuUrl")] SubMenu submenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(submenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ShortDescriptionId = new SelectList(db.ShortDescriptions, "ShortDescriptionId", "Flavour", submenu.ShortDescriptionId);
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeId", "Name", submenu.FoodTypeId);
            return View(submenu);
        }



        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubMenu submenu = db.SubMenus.Find(id);
            if (submenu == null)
            {
                return HttpNotFound();
            }
            return View(submenu);
        }



        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubMenu submenu = db.SubMenus.Find(id);
            db.SubMenus.Remove(submenu);
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
