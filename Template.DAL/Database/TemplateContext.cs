using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Entity;

namespace Template.DAL.Database
{
    public class TemplateContext : DbContext
    {  
        public DbSet<Departments>Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =DESKTOP-R4LBP1Q\\SQLEXPRESS;database=TemplateDB;integrated security=true");
        }
    }
}
