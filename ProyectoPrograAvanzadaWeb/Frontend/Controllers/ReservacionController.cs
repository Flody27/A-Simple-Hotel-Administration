using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class ReservacionController : Controller
    {

        private ReservacionHelper helper;
        private UsuarioHelper usuarioHelper;
        private HabitacionHelper habitacionHelper;

        public ReservacionController()
        {
            helper = new ReservacionHelper();
        }


        // GET: ReservacionController
        public ActionResult Index()
        {
            List<ReservacionViewModel> reservaciones = helper.GetAll();

            return View(reservaciones);
        }

        // GET: ReservacionController/Details/5
        public ActionResult Details(int id)
        {
            ReservacionViewModel reservacion = helper.Get(id);
            return View(reservacion);
        }

        // GET: ReservacionController/Create
        public ActionResult Create()
        {
            habitacionHelper = new HabitacionHelper();
            usuarioHelper = new UsuarioHelper();
            ReservacionViewModel reservacion = new ReservacionViewModel();
            reservacion.Habitaciones = habitacionHelper.GetAll();
            reservacion.Usuarios = usuarioHelper.GetAll();

            return View(reservacion);
        }

        // POST: ReservacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionViewModel payload)
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

        // GET: ReservacionController/Edit/5
        public ActionResult Edit(int id)
        {
            habitacionHelper = new HabitacionHelper();
            usuarioHelper = new UsuarioHelper();
            helper = new ReservacionHelper();
            ReservacionViewModel reservacion = helper.Get(id);
            reservacion.Usuarios = usuarioHelper.GetAll();
            reservacion.Habitaciones = habitacionHelper.GetAll();


            return View(reservacion);
        }

        // POST: ReservacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservacionViewModel payload)
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

        // GET: ReservacionController/Delete/5
        public ActionResult Delete(int id)
        {
            ReservacionViewModel reservacion = helper.Get(id);
            return View(reservacion);
        }

        // POST: ReservacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReservacionViewModel payload)
        {
            try
            {
                helper.Delete(payload.RsvId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
