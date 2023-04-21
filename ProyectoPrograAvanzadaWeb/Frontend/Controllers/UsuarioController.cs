using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioHelper usuarioHelper;
        private MembresiaHelper membresiaHelper;
        private RolHelper rolHelper;

        public UsuarioController() {
            usuarioHelper = new UsuarioHelper();
        }

        #region Index
        // GET: UsuarioController
        public ActionResult Index()
        {
            List<UsuarioViewModel> usuarios = usuarioHelper.GetAll();

            return View(usuarios);
        }
        #endregion

        #region Details
        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            usuarioHelper = new UsuarioHelper();
			UsuarioViewModel usuario = usuarioHelper.Get(id);

            return View(usuario);
        }
        #endregion

        #region Create
        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            rolHelper = new RolHelper();
            membresiaHelper = new MembresiaHelper();
			UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Roles = rolHelper.GetAll();
            usuario.Membresias = membresiaHelper.GetAll();

            return View(usuario);
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
        #endregion

        #region Edit
        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            usuarioHelper = new UsuarioHelper();
            rolHelper = new RolHelper();
            membresiaHelper = new MembresiaHelper();
			UsuarioViewModel usuario = usuarioHelper.Get(id);
            usuario.Roles = rolHelper.GetAll();
            usuario.Membresias = membresiaHelper.GetAll();

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
        #endregion

        #region Delete
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
                usuarioHelper.Delete(usuario.UsrId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } 
        #endregion
    }
}
