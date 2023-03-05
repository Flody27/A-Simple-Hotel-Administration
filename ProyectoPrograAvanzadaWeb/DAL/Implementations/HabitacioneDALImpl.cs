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
    public class HabitacioneDALImpl : IHabitacioneDAL
    {
        HotelContext context;


        public HabitacioneDALImpl()
        {
            context = new HotelContext();

        }

        public HabitacioneDALImpl(HotelContext _Context)
        {
            context = _Context;

        }

        public bool Add(Habitacione entity)
        {
            try
            {
                using (UnidadDeTrabajo<Habitacione> unidad = new UnidadDeTrabajo<Habitacione>(context))
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

        public void AddRange(IEnumerable<Habitacione> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Habitacione> Find(Expression<Func<Habitacione, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Habitacione Get(int id)
        {
            Habitacione habitaciones;
            using (UnidadDeTrabajo<Habitacione> unidad = new UnidadDeTrabajo<Habitacione>(context))
            {
               
                habitaciones= unidad.genericDAL.Get(id);
            }
            return habitaciones;

        }

        public IEnumerable<Habitacione> GetAll()
        {
            try
            {
                IEnumerable<Habitacione> habitaciones;
                using (UnidadDeTrabajo<Habitacione> unidad = new UnidadDeTrabajo<Habitacione>(context))
                {
                    habitaciones = unidad.genericDAL.GetAll();
                }
                return habitaciones;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Habitacione entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Habitacione> unidad = new UnidadDeTrabajo<Habitacione>(context))
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

        public void RemoveRange(IEnumerable<Habitacione> entities)
        {
            throw new NotImplementedException();
        }

        public Habitacione SingleOrDefault(Expression<Func<Habitacione, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Habitacione entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Habitacione> unidad = new UnidadDeTrabajo<Habitacione>(context))
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
