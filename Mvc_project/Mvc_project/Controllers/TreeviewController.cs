using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_project.Controllers
{
    public class TreeviewController : Controller
    {
        // GET: Treeview
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Simple()
        {
            List<SiteMenu> all = new List<SiteMenu>();
            MyModelContext dc = new MyModelContext();
            all = dc.SiteMenus.OrderBy(a => a.ParentMenuID).ToList();

            return View(all);
        }
    }
}