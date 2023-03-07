using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private IServicioDAL ServicioDAL;

        #region Constructor
        public ServiciosController()
        {
            ServicioDAL = new ServicioDALImpl(new Entities.Entities.HotelContext());
        }
        #endregion

        #region consultar
        // GET: api/<ServiciosController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Servicio> servicios = ServicioDAL.GetAll();

            return new JsonResult(servicios);
        }

        // GET api/<ServiciosController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Servicio servicios;
            servicios = ServicioDAL.Get(id);

            return new JsonResult(servicios);
        }
        #endregion

        #region Agregar

        // POST api/<ServiciosController>
        [HttpPost]
        public JsonResult Post([FromBody] Servicio servicios)
        {
            ServicioDAL.Add(servicios);
            return new JsonResult(servicios);
        }
        #endregion

        #region Modificar
        // PUT api/<ServiciosController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Servicio servicios)
        {
            ServicioDAL.Update(servicios);
            return new JsonResult(servicios);
        }
        #endregion

        #region Eliminar
        // DELETE api/<ServiciosController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Servicio servicios = new Servicio { SvcId = id };
            ServicioDAL.Remove(servicios);

            return new JsonResult(servicios);
        }
        #endregion
    }
}
