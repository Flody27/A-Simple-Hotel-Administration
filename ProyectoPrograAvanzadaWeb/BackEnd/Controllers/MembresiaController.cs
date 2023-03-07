using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembresiaController : Controller
    {
        private IMembresiaDAL membresiaDAL;

        #region Constructor
        public MembresiaController ()
        {
            membresiaDAL = new MembresiaDALImpl(new Entities.Entities.HotelContext());
        }
        #endregion

        #region Consultar
        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Membresia> membresias = membresiaDAL.GetAll();

            return new JsonResult(membresias);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Membresia membresia;
            membresia = membresiaDAL.Get(id);

            return new JsonResult(membresia);
        }
        #endregion

        #region Agregar
        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] Membresia membresia)
        {
            membresiaDAL.Add(membresia);
            return new JsonResult(membresia);
        }
        #endregion

        #region MOdificar
        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Membresia membresia)
        {
            membresiaDAL.Update(membresia);
            return new JsonResult(membresia);
        }
        #endregion

        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Membresia membresia = new Membresia{ MbrId = id };
            membresiaDAL.Remove(membresia);

            return new JsonResult(membresia);
        }

        #endregion
    }
}

