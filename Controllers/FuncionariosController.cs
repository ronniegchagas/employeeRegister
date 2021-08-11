using employeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace employeeRegister.Controllers
{
    public class FuncionariosController : Controller
    {
        private EmployeeContext db = new EmployeeContext();
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Cadastrar([Bind(Include = "Id,Name,Address,BirthDate,Salary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(employee);
        }

        public async Task<ActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = await db.Employees.FindAsync(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Editar([Bind(Include = "Id,Name,Address,BirthDate,Salary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(employee);
        }

        // GET: Funcionários/Delete/5
        public async Task<ActionResult> Deletar(int id)
        {
            try
            {
                Employee employee = await db.Employees.FindAsync(id);
                db.Employees.Remove(employee);
                await db.SaveChangesAsync();

                ViewBag.type = "bg-green-200";
                ViewBag.msg = "Funcionário deletado com sucesso.";

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                ViewBag.type = "bg-red-200";
                ViewBag.msg = "Ocorreu um erro ao deletar.";

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
