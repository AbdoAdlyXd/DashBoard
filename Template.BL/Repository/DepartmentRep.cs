using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.BL.InterFace;
using Template.BL.Models;
using Template.DAL.Database;
using Template.DAL.Entity;

namespace Template.BL.Repository
{
    public class DepartmentRep : IDepartmentRep
    {
        TemplateContext db = new TemplateContext();

        public IEnumerable<DepartmentVM> Get()
        {
            var data = db.Departments.Select(a => new DepartmentVM { Id = a.Id, Name = a.Name, salary = a.salary });
            return data;
        }

        public DepartmentVM getById(int Id)
        {
            var data = db.Departments.Where(a => a.Id == Id).Select(a => new DepartmentVM { Id = a.Id, Name = a.Name, salary = a.salary }).FirstOrDefault();
            return data;
        }

        public void create(DepartmentVM model)
        {
            Departments d = new Departments();

            d.Id = model.Id;
            d.Name = model.Name;
            d.salary = model.salary;


            db.Departments.Add(d);
            db.SaveChanges();
        }

        public void update(DepartmentVM model)
        {
            var oldData = db.Departments.Find(model.Id);

            oldData.Name = model.Name;
            oldData.salary = model.salary;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var oldData = db.Departments.Find(id);
            db.Departments.Remove(oldData);
            db.SaveChanges();
        }


   

       
    }
}
