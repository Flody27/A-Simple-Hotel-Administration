using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class ServReservacionController : Controller
    {
        private ServReservacionHelper helper;

        public ServReservacionController()
        {
            helper = new ServReservacionHelper();
        }

        // GET: ServReservacionController
        public ActionResult Index()
        {
            List<ServReservacionViewModel> servReservs = helper.GetAll();

            return View(servReservs);
        }

        // GET: ServReservacionController/Details/5
        public ActionResult Details(int id)
        {
            ServReservacionViewModel servReserv = helper.Get(id);
            return View(servReserv);
        }

        // GET: ServReservacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServReservacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServReservacionViewModel payload)
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

        // GET: ServReservacionController/Edit/5
        public ActionResult Edit(int id)
        {
            ServReservacionViewModel servReserv = helper.Get(id);
            return View(servReserv);
        }

        // POST: ServReservacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServReservacionViewModel payload)
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

        // GET: ServReservacionController/Delete/5
        public ActionResult Delete(int id)
        {
            ServReservacionViewModel servReserv = helper.Get(id);
            return View(servReserv);
        }

        // POST: ServReservacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ServReservacionViewModel payload)
        {
            try
            {
                helper.Delete(payload.SrSvcId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
