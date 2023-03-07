using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private IRoleDAL roleDAL;

        #region Constructor
        public RoleController ()
        {
            roleDAL = new RoleDALImpl(new Entities.Entities.HotelContext());
        }
        #endregion

        #region Consultar
        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Role> roles = roleDAL.GetAll();

            return new JsonResult(roles);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Role role;
            role = roleDAL.Get(id);

            return new JsonResult(role);
        }
        #endregion

        #region Agregar
        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] Role role)
        {
            roleDAL.Add(role);
            return new JsonResult(role);
        }
        #endregion

        #region Modificar
        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Role role)
        {
            roleDAL.Update(role);
            return new JsonResult(role);
        }
        #endregion

        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Role role = new Role { RolId = id };
            roleDAL.Remove(role);

            return new JsonResult(role);
        }

        #endregion
    }
}

