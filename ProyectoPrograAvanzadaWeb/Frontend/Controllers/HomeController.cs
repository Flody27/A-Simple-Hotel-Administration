using Frontend.Helpers;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ConsultaHabitacionHelper consultaHelper;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("ingresar")]
        public IActionResult Login()
        {
            return View();  
        }

        [HttpPost("ingresar")]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                SecurityHelper securityHelper = new SecurityHelper();
                TokenModel tokenModel = securityHelper.Login(usuario);
                HttpContext.Session.SetString("token", tokenModel.Token);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }

        }


        [HttpGet("registrarse")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("registrarse")]
        public IActionResult Register(LoginViewModel usuario)
        {
            try
            {
                SecurityHelper securityHelper = new SecurityHelper();
                TokenModel tokenModel = securityHelper.Register(usuario);
                HttpContext.Session.SetString("token", tokenModel.Token);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Consulta(BuscarHabitaconViewModel consulta) {
            consultaHelper = new ConsultaHabitacionHelper();
            HabitacionViewModel habitacion = consultaHelper.consultar(consulta);

            if (habitacion == null)
            {
                return RedirectToAction("ErrorReservacion", "ReservacionUsuario");
            }
            return RedirectToAction("Index", "ReservacionUsuario", habitacion);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}