using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacioneController : Controller
    {
        private IHabitacioneDAL habitacioneDAL;

        #region Constructor
        public HabitacioneController ()
        {
            habitacioneDAL = new HabitacioneDALImpl(new Entities.Entities.HotelContext());
        }
        #endregion

        #region Consultar
        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Habitacione> habitaciones = habitacioneDAL.GetAll();

            return new JsonResult(habitaciones);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Habitacione habitacion;
            habitacion = habitacioneDAL.Get(id);

            return new JsonResult(habitacion);
        }
        #endregion

        #region Agregar
        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] Habitacione habitacion)
        {
            habitacioneDAL.Add(habitacion);
            return new JsonResult(habitacion);
        }
        #endregion

        #region MOdificar
        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Habitacione habitacion)
        {
            habitacioneDAL.Update(habitacion);
            return new JsonResult(habitacion);
        }
        #endregion

        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Habitacione habitacion = new Habitacione { HabId = id };
            habitacioneDAL.Remove(habitacion);

            return new JsonResult(habitacion);
        }

        #endregion
    }
}

