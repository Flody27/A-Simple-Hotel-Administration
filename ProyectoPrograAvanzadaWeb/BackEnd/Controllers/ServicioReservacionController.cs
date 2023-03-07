using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioReservacionController : Controller
    {
        private IServReservacionDAL ServReservacionDAL;

        #region Constructor
        public ServicioReservacionController()
        {
            ServReservacionDAL = new ServReservacionDALImpl(new Entities.Entities.HotelContext());
        }
        #endregion

        #region Consultar
        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<ServiciosReservacione> serviciosReservacion = ServReservacionDAL.GetAll();

            return new JsonResult(serviciosReservacion);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            ServiciosReservacione serviciosReservacion;
            serviciosReservacion = ServReservacionDAL.Get(id);

            return new JsonResult(serviciosReservacion);
        }
        #endregion

        #region Agregar
        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] ServiciosReservacione serviciosReservacion)
        {
            ServReservacionDAL.Add(serviciosReservacion);
            return new JsonResult(serviciosReservacion);
        }
        #endregion

        #region Modificar
        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] ServiciosReservacione serviciosReservacion)
        {
            ServReservacionDAL.Update(serviciosReservacion);
            return new JsonResult(serviciosReservacion);
        }
        #endregion

        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            ServiciosReservacione serviciosReservacion = new ServiciosReservacione { SrId = id };
            ServReservacionDAL.Remove(serviciosReservacion);

            return new JsonResult(serviciosReservacion);
        }

        #endregion
    }
}

