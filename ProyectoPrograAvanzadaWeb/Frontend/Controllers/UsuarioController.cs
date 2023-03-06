using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class UsuarioController : Controller
    {
        //Agregar los helper de membresia y rol
        private UsuarioHelper usuarioHelper;

        public UsuarioController() {
            // Completar con lo de las mebresias y roles
            usuarioHelper = new UsuarioHelper();
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            List<UsuarioViewModel> usuarios = usuarioHelper.GetAll();

            return View(usuarios);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            usuarioHelper = new UsuarioHelper();
            UsuarioViewModel usuario = usuarioHelper.Get(id);

            return View(usuario);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            // Completar con lo de las mebresias y roles
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            try
            {
                usuarioHelper = new UsuarioHelper();
                usuarioHelper.Create(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            // Completar con lo de las mebresias y roles
            usuarioHelper = new UsuarioHelper();
            UsuarioViewModel usuario = usuarioHelper.Get(id);

            return View(usuario);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            try
            {
                UsuarioHelper orderHelper = new UsuarioHelper();
                usuario = orderHelper.Update(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            usuarioHelper = new UsuarioHelper();
            UsuarioViewModel usuario = usuarioHelper.Get(id);

            return View(usuario);
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UsuarioViewModel usuario)
        {
            try
            {
                usuarioHelper = new UsuarioHelper();
                usuarioHelper.Delete(usuario.UsrId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
