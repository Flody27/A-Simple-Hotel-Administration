using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ServicioDALImpl : IServicioDAL
    {
        HotelContext context;


        public ServicioDALImpl()
        {
            context = new HotelContext();

        }

        public ServicioDALImpl(HotelContext _Context)
        {
            context = _Context;

        }

        public bool Add(Servicio entity)
        {
            try
            {
                using (UnidadDeTrabajo<Servicio> unidad = new UnidadDeTrabajo<Servicio>(context))
                {
                    unidad.genericDAL.Add(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void AddRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Servicio> Find(Expression<Func<Servicio, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Servicio Get(int id)
        {
            Servicio Servicios;
            using (UnidadDeTrabajo<Servicio> unidad = new UnidadDeTrabajo<Servicio>(context))
            {

                Servicios = unidad.genericDAL.Get(id);
            }
            return Servicios;

        }

        public IEnumerable<Servicio> GetAll()
        {
            try
            {
                IEnumerable<Servicio> Servicios;
                using (UnidadDeTrabajo<Servicio> unidad = new UnidadDeTrabajo<Servicio>(context))
                {
                    Servicios = unidad.genericDAL.GetAll();
                }
                return Servicios;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Servicio entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Servicio> unidad = new UnidadDeTrabajo<Servicio>(context))
                {
                    unidad.genericDAL.Remove(entity);
                    result = unidad.Complete();
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        public void RemoveRange(IEnumerable<Servicio> entities)
        {
            throw new NotImplementedException();
        }

        public Servicio SingleOrDefault(Expression<Func<Servicio, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Servicio entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Servicio> unidad = new UnidadDeTrabajo<Servicio>(context))
                {
                    unidad.genericDAL.Update(entity);
                    result = unidad.Complete();
                }

            }
            catch (Exception)
            {

                return false;
            }

            return result;
        }
    }
}
