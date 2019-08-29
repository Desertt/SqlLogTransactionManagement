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

        [HttpGet]  /* Bu metod sunucudan veri almak için kullanılır.*/
        public ActionResult AddOrEdit(int id=0)
        {
            return View(new Employee());

        }

        [HttpPost] /*Bu metod ile sunucuya veri yazdırabilirsiniz. Bu metodla istek parametreleri hem URL içinde hem de mesaj gövdesinde gönderilebilir. */
        public ActionResult AddOrEdit()
        {

            return View();
        }

    }
}