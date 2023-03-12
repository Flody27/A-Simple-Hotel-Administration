using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HabitacionController : Controller
    {
        private HabitacionHelper helper;

        public HabitacionController()
        {
            helper = new HabitacionHelper();
        }

        // GET: HabitacionController
        public ActionResult Index()
        {
            List<HabitacionViewModel> habitaciones = helper.GetAll();

            return View(habitaciones);
        }

        // GET: HabitacionController/Details/5
        public ActionResult Details(int id)
        {
            HabitacionViewModel habitacion = helper.Get(id);
            return View(habitacion);
        }

        // GET: HabitacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HabitacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HabitacionViewModel payload)
        {
            try
            {
                helper.Create(payload);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HabitacionController/Edit/5
        public ActionResult Edit(int id)
        {
            HabitacionViewModel habitacion = helper.Get(id);
            return View(habitacion);
        }

        // POST: HabitacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HabitacionViewModel payload)
        {
            try
            {
                helper.Update(payload);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HabitacionController/Delete/5
        public ActionResult Delete(int id)
        {
            HabitacionViewModel habitacion = helper.Get(id);
            return View(habitacion);
        }

        // POST: HabitacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(HabitacionViewModel payload)
        {
            try
            {
                helper.Delete(payload.HabId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
