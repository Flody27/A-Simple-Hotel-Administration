using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class HabitacioneController : Controller
    {
        // GET: HabitacioneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HabitacioneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HabitacioneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HabitacioneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HabitacioneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HabitacioneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HabitacioneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HabitacioneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
