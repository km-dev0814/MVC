using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc_project;

namespace Mvc_project.Controllers
{
    public class OrdersController : Controller
    {
        private MyModelContext db = new MyModelContext();

        public ActionResult Orders()
        {
            return RedirectToAction("simple", "Treeview");
        }


        // GET: Orders
        //public ActionResult Index()
        //{
        //    return View(db.SiteMenus.ToList());
        //}

        //// GET: Orders/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SiteMenu siteMenu = db.SiteMenus.Find(id);
        //    if (siteMenu == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(siteMenu);
        //}

        //// GET: Orders/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Orders/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,OrderMenu,NavURL,ParentMenuID")] SiteMenu siteMenu)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.SiteMenus.Add(siteMenu);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(siteMenu);
        //}

        //// GET: Orders/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SiteMenu siteMenu = db.SiteMenus.Find(id);
        //    if (siteMenu == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(siteMenu);
        //}

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OrderMenu,NavURL,ParentMenuID")] SiteMenu siteMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(siteMenu);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteMenu siteMenu = db.SiteMenus.Find(id);
            if (siteMenu == null)
            {
                return HttpNotFound();
            }
            return View(siteMenu);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SiteMenu siteMenu = db.SiteMenus.Find(id);
            db.SiteMenus.Remove(siteMenu);
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
