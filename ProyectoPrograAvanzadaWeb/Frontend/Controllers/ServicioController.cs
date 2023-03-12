using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class ServicioController : Controller
    {
        private ServicioHelper helper;

        public ServicioController()
        {
            helper = new ServicioHelper();
        }

        // GET: ServicioController
        public ActionResult Index()
        {
            List<ServicioViewModel> servicios = helper.GetAll();

            return View(servicios);
        }

        // GET: ServicioController/Details/5
        public ActionResult Details(int id)
        {
            ServicioViewModel servicio = helper.Get(id);
            return View(servicio);
        }

        // GET: ServicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServicioViewModel payload)
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

        // GET: ServicioController/Edit/5
        public ActionResult Edit(int id)
        {
            ServicioViewModel servicio = helper.Get(id);
            return View(servicio);
        }

        // POST: ServicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServicioViewModel payload)
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

        // GET: ServicioController/Delete/5
        public ActionResult Delete(int id)
        {
            ServicioViewModel servicio = helper.Get(id);
            return View(servicio);
        }

        // POST: ServicioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ServicioViewModel payload)
        {
            try
            {
                helper.Delete(payload.SvcId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
