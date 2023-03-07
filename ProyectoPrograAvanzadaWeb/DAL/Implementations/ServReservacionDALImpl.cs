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
    public class ServReservacionDALImpl : IServReservacionDAL
    {
        HotelContext context;


        public ServReservacionDALImpl()
        {
            context = new HotelContext();

        }

        public ServReservacionDALImpl(HotelContext _Context)
        {
            context = _Context;

        }

        public bool Add(ServiciosReservacione entity)
        {
            try
            {
                using (UnidadDeTrabajo<ServiciosReservacione> unidad = new UnidadDeTrabajo<ServiciosReservacione>(context))
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

        public void AddRange(IEnumerable<ServiciosReservacione> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServiciosReservacione> Find(Expression<Func<ServiciosReservacione, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ServiciosReservacione Get(int id)
        {
            ServiciosReservacione serviciosReservacion;
            using (UnidadDeTrabajo<ServiciosReservacione> unidad = new UnidadDeTrabajo<ServiciosReservacione>(context))
            {

                serviciosReservacion = unidad.genericDAL.Get(id);
            }
            return serviciosReservacion;

        }

        public IEnumerable<ServiciosReservacione> GetAll()
        {
            try
            {
                IEnumerable<ServiciosReservacione> serviciosReservacion;
                using (UnidadDeTrabajo<ServiciosReservacione> unidad = new UnidadDeTrabajo<ServiciosReservacione>(context))
                {
                    serviciosReservacion = unidad.genericDAL.GetAll();
                }
                return serviciosReservacion;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(ServiciosReservacione entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ServiciosReservacione> unidad = new UnidadDeTrabajo<ServiciosReservacione>(context))
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

        public void RemoveRange(IEnumerable<ServiciosReservacione> entities)
        {
            throw new NotImplementedException();
        }

        public ServiciosReservacione SingleOrDefault(Expression<Func<ServiciosReservacione, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ServiciosReservacione entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ServiciosReservacione> unidad = new UnidadDeTrabajo<ServiciosReservacione>(context))
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
