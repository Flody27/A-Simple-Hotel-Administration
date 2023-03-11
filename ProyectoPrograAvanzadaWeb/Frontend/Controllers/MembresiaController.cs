using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class MembresiaController : Controller
    {

        private MembresiaHelper helper;

        public MembresiaController()
        {
            helper = new MembresiaHelper();
        }


        // GET: MembresiaController
        public ActionResult Index()
        {
            List<MembresiaViewModel> membresia = helper.GetAll();

            return View(membresia);
        }

        // GET: MembresiaController/Details/5
        public ActionResult Details(int id)
        {
            MembresiaViewModel membresia = helper.Get(id);
            return View(membresia);
        }

        // GET: MembresiaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembresiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MembresiaViewModel payload)
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

        // GET: MembresiaController/Edit/5
        public ActionResult Edit(int id)
        {
            MembresiaViewModel membresia = helper.Get(id);
            return View(membresia);
        }

        // POST: MembresiaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MembresiaViewModel payload)
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

        // GET: MembresiaController/Delete/5
        public ActionResult Delete(int id)
        {
            MembresiaViewModel membresia = helper.Get(id);
            return View(membresia);
        }

        // POST: MembresiaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(MembresiaViewModel payload)
        {
            try
            {
                helper.Delete(payload.MbrId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
