using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WikiReloaded.Models
{

    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }

    public class UserDBContext : DbContext
    {
        public UserDBContext() : base("DBConnectionString") { }
        public DbSet<User> Users { get; set; }
    }

}