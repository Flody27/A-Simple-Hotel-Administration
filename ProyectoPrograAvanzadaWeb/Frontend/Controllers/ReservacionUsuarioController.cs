using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Frontend.Controllers
{
    public class ReservacionUsuarioController : Controller
    {
        private ReservacionHelper helper;

        public ReservacionUsuarioController() { 
            helper = new ReservacionHelper();
        }

        // GET: ReservacionUsuarioController
        public ActionResult Index(HabitacionViewModel habitacion)
        {
            ViewData["NumeroHab"] = habitacion.HabNumPuerta;
            ViewData["PrecioHab"] = habitacion.HabPrecioPorNoche;
            ViewData["BañosHab"] = habitacion.HabCantBannos;
            ViewData["camasoHab"] = habitacion.HabCantCamas;
            ViewData["IDHab"] = habitacion.HabId;
            return View();
        }

        public ActionResult UsuarioReservacion()
        {
            return View();
        }

        // GET: ReservacionUsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //// GET: ReservacionUsuarioController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: ReservacionUsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionViewModel model)
        {
            try
            {
                helper.Create(model);
                return RedirectToAction("Index","Home");
            }
            catch
            {
                throw;
            }
        }

        // GET: ReservacionUsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservacionUsuarioController/Edit/5
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

        // GET: ReservacionUsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservacionUsuarioController/Delete/5
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
