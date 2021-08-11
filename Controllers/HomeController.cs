using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using employeeRegister.Models;

namespace employeeRegister.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();
        public async Task<ActionResult> Index()
        {
            return View(await db.Employees.ToListAsync());
        }
    }
}