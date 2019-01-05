using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WikiReloaded.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public string category { get; set; }
    }
}