using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class RolController : Controller
    {

        private RolHelper helper;

        public RolController()
        {
            helper = new RolHelper();
        }


        // GET: RolController
        public ActionResult Index()
        {
            List<RolViewModel> roles = helper.GetAll();

            return View(roles);
        }

        // GET: RolController/Details/5
        public ActionResult Details(int id)
        {
            RolViewModel roles = helper.Get(id);
            return View(roles);
        }

        // GET: RolController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RolViewModel payload)
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

        // GET: RolController/Edit/5
        public ActionResult Edit(int id)
        {
            RolViewModel roles = helper.Get(id);
            return View(roles);
        }

        // POST: RolController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RolViewModel payload)
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

        // GET: RolController/Delete/5
        public ActionResult Delete(int id)
        {
            RolViewModel roles = helper.Get(id);
            return View(roles);
        }

        // POST: RolController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(RolViewModel payload)
        {
            try
            {
                helper.Delete(payload.RolId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
