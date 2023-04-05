using DAL.Implementations;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaHabitacionController : Controller
    {
        private HabitacioneDALImpl dal = new HabitacioneDALImpl();

        // GET: api/<ConsultaHabitacionController>
        [HttpPost]
        public JsonResult consultar([FromBody] BuscarHabitacionesDisponibles consulta)
        {
            sp_BuscarHabitacionesDisponibles habitacion = dal.BuscarHabitacion(consulta);
            return new JsonResult(habitacion);
        }

    }
}
