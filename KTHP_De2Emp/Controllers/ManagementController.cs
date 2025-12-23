using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KTHP_De2Emp.Models;

namespace KTHP_De2Emp.Controllers
{
    public class ManagementController : Controller
    {
        private Model1 db = new Model1();

        [ChildActionOnly]
        public PartialViewResult GetListDepart()
        {
            return PartialView(db.Departments.ToList());
        }
        [Route("GetEmployeeDepart/{id}")]
        public ActionResult GetEmployeeDepart(int id)
        {
            var list = db.Employees.Where(e => e.deptid == id);
            return View(list.ToList());
        }
        // GET: Management
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Department);
            return View(employees.ToList());
        }

        // GET: Management/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Management/Create
        public ActionResult Create()
        {
            ViewBag.deptid = new SelectList(db.Departments, "deptid", "deptname");
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "eid,name,age,addr,salary,image,deptid")] Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return Json(new { msg = "Thêm thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { msg ="Có lỗi xảy ra" +ex.Message });
            }

        }

        // GET: Management/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.deptid = new SelectList(db.Departments, "deptid", "deptname", employee.deptid);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { msg = "Sửa thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { msg = "Có lỗi xảy ra" +ex.Message});
            }
        }

        // GET: Management/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Management/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
