using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_project
{
    [Table("Orders")]
    public class SiteMenu
    {
        [Key]
        public int ID { get; set; }
        public string OrderMenu { get; set; }
        public string NavURL { get; set; }
        public int ParentMenuID { get; set; }
    }
}