using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Frontend.Controllers
{
    public class ReservacionUsuarioController : Controller
    {
        private ReservacionHelper helper;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionViewModel model)
        {
            try
            {
                string token = HttpContext.Session.GetString("token");
                helper = new ReservacionHelper(token);
                helper.Create(model);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                throw;
            }
        }


        public ActionResult ErrorReservacion(){
            return View();
        } 

    }
}
