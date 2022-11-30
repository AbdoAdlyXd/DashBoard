using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.BL.Models;
using Template.BL.Repository;

namespace Template.Controllers
{
    public class DepartmentController : Controller
    {


        DepartmentRep department = new DepartmentRep();

        public IActionResult Index()
        {
            var data = department.Get();

            return View(data);
        }
        public IActionResult Details(int id)
        {
            var data = department.getById(id);
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    department.create(model);
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                // Log Exception
                return View(model);
            }

        }

        public IActionResult Edit(int id)
        {
            var data = department.getById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(DepartmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    department.update(model);
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                // Log Exception
                return View(model);
            }

        }


        public IActionResult Delete(int id)
        {
            var data = department.getById(id);
            return View(data);
        }

        [HttpPost]
        //[ActionName("Delete")]
        public IActionResult Delete(DepartmentVM model)
        {
            try
            {

                department.Delete(model.Id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Log Exception
                return View(model);
            }

        }
    }
}
