using LIB_manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LIB_manage.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        private stucontext db = new stucontext();
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(student stu)
        {
            if(UserValid(stu.ID,stu.Password)==true)
            {
                //student stud = db.student.Where(X => X.ID == stu.ID).SingleOrDefault();
                List<book> books = db.Book.ToList();
                return RedirectToAction(List);
            }
            else
            {
                ModelState.AddModelError("","Please Cheak Your Username and Password");
                return RedirectToAction(Index);
            }
    

            
        }
        public bool UserValid(String UName, String Password)
        {
            bool uvalid = false;
            int ucount = db.student.Count(x=>x.ID==UName && x.Password==Password);
            if(ucount==1)
            {
                uvalid = true;
            }
            return uvalid;
        }
       /* public ActionResult userCheak(book bk)
        {
            if(Request.IsAuthenticated)
            {
                return View(bk);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }*/
    
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,Password")]student stu)
        {
            if (ModelState.IsValid)
            {
                db.student.Add(stu);
                db.SaveChanges();
            }
            return View(stu);
        }
        public ActionResult List()
        {
            List<student>  ListofStudents = db.student.ToList();
            return View(ListofStudents);
        }
        public ActionResult Details(string id)
        {
            student stu = db.student.SingleOrDefault(x=>x.ID==id);
            return View(stu);
        }
    }
}