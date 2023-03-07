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
    public class RoleDALImpl : IRoleDAL
    {
        HotelContext context;


        public RoleDALImpl()
        {
            context = new HotelContext();

        }

        public RoleDALImpl(HotelContext _Context)
        {
            context = _Context;

        }

        public bool Add(Role entity)
        {
            try
            {
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(context))
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

        public void AddRange(IEnumerable<Role> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> Find(Expression<Func<Role, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Role Get(int id)
        {
            Role roles;
            using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(context))
            {

                roles = unidad.genericDAL.Get(id);
            }
            return roles;

        }

        public IEnumerable<Role> GetAll()
        {
            try
            {
                IEnumerable<Role> roles;
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(context))
                {
                    roles = unidad.genericDAL.GetAll();
                }
                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Role entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(context))
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

        public void RemoveRange(IEnumerable<Role> entities)
        {
            throw new NotImplementedException();
        }

        public Role SingleOrDefault(Expression<Func<Role, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Role entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Role> unidad = new UnidadDeTrabajo<Role>(context))
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
