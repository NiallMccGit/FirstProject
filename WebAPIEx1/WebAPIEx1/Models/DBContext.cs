using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIEx1.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DBContext() : base("DefaultConnection")
        {

        }
        public static DBContext Create()
        {
            return new DBContext();
        }
    }
}