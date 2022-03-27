using CRUDDEMO.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDEMO.Controllers
{
    public class StudentController : Controller
    {
        private readonly AplicationContextDb _db;

        public StudentController(AplicationContextDb db)
        {
            _db = db;
        }        
        public IActionResult Index()
        {
            //var data = _db.tblStudent.ToList();
            var data = (from a in _db.tblStudent
                        join b in _db.tblCountry on a.country equals b.c_id
                        select new
                       JoinBindtblStud
                        {
                            id = a.id,
                            name = a.name,
                            age = a.age,
                            standard = a.standard,
                            country_name = b.c_name}).ToList();
            return View(data);
        }       
        public IActionResult Create(int id)
        {
            Student st = new Student();
            ViewBag.BT = "Save";
            if(id > 0)
            {
                var data = (from a in _db.tblStudent where a.id == id select a).ToList();
                st.id = data[0].id;
                st.name = data[0].name;
                st.age = data[0].age;
                st.standard = data[0].standard;
                st.country = data[0].country;
                ViewBag.BT = "Update";
            }
            ViewBag.country = _db.tblCountry.ToList();
            ViewBag.state = _db.tblState.ToList();
            return View(st);        
        } 

        [HttpPost]
        public IActionResult Create(Student sts)
        {
            if(sts.id==0)
            {
                _db.tblStudent.Add(sts);
            }
            else
            {
                _db.Entry(sts).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }            
            _db.SaveChanges();
            return RedirectToAction("Index");         
        }

        public IActionResult Delete(int id)
        {
            var del = _db.tblStudent.Find(id);
            _db.tblStudent.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
