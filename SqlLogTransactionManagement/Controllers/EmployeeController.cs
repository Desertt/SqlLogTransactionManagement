using SqlLogTransactionManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SqlLogTransactionManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {

                List<Employee> empList = db.Employee.ToList<Employee>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);

            }
        }
    }
}