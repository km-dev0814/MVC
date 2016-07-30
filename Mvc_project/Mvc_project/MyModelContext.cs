using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_project
{
    public class MyModelContext : DbContext
    {
        public DbSet<SiteMenu> SiteMenus { get; set; }
    }
}