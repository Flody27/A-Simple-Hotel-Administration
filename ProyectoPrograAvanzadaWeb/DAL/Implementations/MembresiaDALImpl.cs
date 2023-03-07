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
    public class MembresiaDALImpl : IMembresiaDAL
    {
        HotelContext context;


        public MembresiaDALImpl()
        {
            context = new HotelContext();

        }

        public MembresiaDALImpl(HotelContext _Context)
        {
            context = _Context;

        }

        public bool Add(Membresia entity)
        {
            try
            {
                using (UnidadDeTrabajo<Membresia> unidad = new UnidadDeTrabajo<Membresia>(context))
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

        public void AddRange(IEnumerable<Membresia> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Membresia> Find(Expression<Func<Membresia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Membresia Get(int id)
        {
            Membresia membresias;
            using (UnidadDeTrabajo<Membresia> unidad = new UnidadDeTrabajo<Membresia>(context))
            {

                membresias = unidad.genericDAL.Get(id);
            }
            return membresias;

        }

        public IEnumerable<Membresia> GetAll()
        {
            try
            {
                IEnumerable<Membresia> membresias;
                using (UnidadDeTrabajo<Membresia> unidad = new UnidadDeTrabajo<Membresia>(context))
                {
                    membresias = unidad.genericDAL.GetAll();
                }
                return membresias;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Membresia entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Membresia> unidad = new UnidadDeTrabajo<Membresia>(context))
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

        public void RemoveRange(IEnumerable<Membresia> entities)
        {
            throw new NotImplementedException();
        }

        public Membresia SingleOrDefault(Expression<Func<Membresia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Membresia entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Membresia> unidad = new UnidadDeTrabajo<Membresia>(context))
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
