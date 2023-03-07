using BackEnd.Models;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioDAL usuarioDAL;

        private new UsuarioModel Convertir(Usuario entity)
        {
            return new UsuarioModel
            {
               UsrId = entity.UsrId,
               UsrNombre = entity.UsrNombre,
               UsrApellido = entity.UsrApellido,
               UsrEmail = entity.UsrEmail,
               UsrPassword = entity.UsrPassword,
               UsrRolId = entity.UsrRolId,
               UsrMbrId = entity.UsrMbrId
            };
        }

        private new Usuario Convertir(UsuarioModel model)
        {
            return new Usuario
            {
                UsrId = model.UsrId,
                UsrNombre = model.UsrNombre,
                UsrApellido = model.UsrApellido,
                UsrEmail = model.UsrEmail,
                UsrPassword = model.UsrPassword,
                UsrRolId = model.UsrRolId,
                UsrMbrId = model.UsrMbrId
            };
        }

        public UsuarioController() {
            usuarioDAL = new UsuarioDALImpl(new HotelContext());
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Usuario> usuarios = usuarioDAL.GetAll();

            List<UsuarioModel> lista = new List<UsuarioModel>();

            foreach (var usuario in usuarios)
            {
                lista.Add(Convertir(usuario));
            }

            return new JsonResult(lista);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Usuario usuario;
            usuario = usuarioDAL.Get(id);

            return new JsonResult(Convertir(usuario));
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public JsonResult Post([FromBody]UsuarioModel usuario)
        {
            Usuario entity = Convertir(usuario);
            usuarioDAL.Add(entity);
            return new JsonResult(Convertir(entity));
        }

        // PUT api/<UsuarioController>
        [HttpPut]
        public JsonResult Put([FromBody]UsuarioModel usuario)
        {
            usuarioDAL.Update(Convertir(usuario));
            return new JsonResult(Convertir(usuario));
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Usuario usuario = new Usuario { UsrId = id };
            usuarioDAL.Remove(usuario);

            return new JsonResult(Convertir(usuario));
        }
    }
}
