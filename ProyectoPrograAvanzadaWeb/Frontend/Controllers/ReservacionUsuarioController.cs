using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class ReservacionUsuarioController : Controller
    {
        private ReservacionHelper helper;

        public ReservacionUsuarioController()
        {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionViewModel model)
        {
            try
            {
                model.RsvUsrId = 1;
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
