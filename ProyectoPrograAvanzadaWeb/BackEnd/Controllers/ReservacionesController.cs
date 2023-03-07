﻿using Microsoft.AspNetCore.Mvc;
using DAL;
using Entities.Entities;
using DAL.Interfaces;
using DAL.Implementations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionesController : ControllerBase
    {

        private IReservacionesDAL dal;

        public ReservacionesController()
        {
            dal = new ReservacionesDALImpl(new Entities.Entities.HotelContext());
        }

        #region Convertir
        /*        private PersonaModel Convertir(Persona entity)
                {
                    return new PersonaModel
                    {
                        PersonaId = entity.PersonaId,
                        Cedula = entity.Cedula,
                        Nombre = entity.Nombre
                    };
                }


                private Persona Convertir(PersonaModel model)
                {
                    return new Persona
                    {
                        PersonaId = model.PersonaId,
                        Cedula = model.Cedula,
                        Nombre = model.Nombre
                    };
                }*/
        #endregion

        // GET: api/<ReservacionesController>
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                IEnumerable<Reservacione> reservaciones = dal.GetAll();
                List<Reservacione> lista = new List<Reservacione>();

                foreach (var reservacion in reservaciones)
                {
                    lista.Add(reservacion);
                }
                return new JsonResult(lista);
            }
            catch (Exception e)
            {
                return new JsonResult(null);
            }
        }

        // GET api/<ReservacionesController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            try
            {
                Reservacione reservacion = dal.Get(id);
                return new JsonResult(reservacion);
            }
            catch (Exception e)
            {
                return new JsonResult("No se pudo encontrar una reservacion con el ID ingresado.");
            }
        }

        // POST api/<ReservacionesController>
        [HttpPost]
        public JsonResult Post([FromBody] Reservacione reservacion)
        {
            try
            {
                /*Persona entity = Convertir(persona);*/
                dal.Add(reservacion);
                return new JsonResult(reservacion);
            }
            catch (Exception e)
            {
                return new JsonResult("No se pudo ingresar nueva reservacion.");
            }
        }

        // PUT api/<ReservacionesController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] Reservacione reservacion)
        {
            try
            {
/*                Persona entity = Convertir(persona);
*/                dal.Update(reservacion);
                return new JsonResult(reservacion);
            }
            catch (Exception e)
            {
                return new JsonResult("Error en actualizar reservacion.");
            }
        }

        // DELETE api/<ReservacionesController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            try
            {
                Reservacione reservacion = new Reservacione { RsvId = id };
                dal.Remove(reservacion);

                return new JsonResult(reservacion);
            }
            catch (Exception e)
            {
                return new JsonResult("Error en eliminar reservacion.");
            }
        }
    }
}
