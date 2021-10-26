using Student_CRUD.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_CRUD.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbobj = new db_testEntities();
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Tbl_student model)
        {
            
                Tbl_student obj = new Tbl_student();
                obj.FirstName = model.FirstName;
                obj.LastName = model.LastName;
                obj.Email = model.Email;
                obj.Mobile = obj.Mobile;
                obj.Description = model.Description;
                dbobj.Tbl_student.Add(obj);
                dbobj.SaveChanges();               
            
            return View("Student");
            //hi hello
        }
    }
}