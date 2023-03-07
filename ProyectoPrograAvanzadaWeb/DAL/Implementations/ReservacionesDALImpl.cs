﻿using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ReservacionesDALImpl : IReservacionesDAL
    {

        HotelContext context;
        private UnidadDeTrabajo<Reservacione> unit;

        public ReservacionesDALImpl()
        {
            context = new HotelContext();

        }

        public ReservacionesDALImpl(HotelContext _Context)
        {
            context = _Context;

        }
        public bool Add(Reservacione entity)
        {
            try
            {
                using (unit = new UnidadDeTrabajo<Reservacione>(context))
                {
                    unit.genericDAL.Add(entity);
                    unit.Complete();
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public void AddRange(IEnumerable<Reservacione> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservacione> Find(Expression<Func<Reservacione, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Reservacione Get(int id)
        {
            Reservacione reservacion = null;
            using (unit = new UnidadDeTrabajo<Reservacione>(context))
            {
                reservacion = unit.genericDAL.Get(id);
            }
            return reservacion;
        }

        public IEnumerable<Reservacione> GetAll()
        {
            IEnumerable<Reservacione> reservaciones = null;
            using (unit = new UnidadDeTrabajo<Reservacione>(context))
            {
                reservaciones = unit.genericDAL.GetAll();
            }
            return reservaciones;
        }

        public bool Remove(Reservacione entity)
        {
            bool result = false;
            try
            {
                using (unit = new UnidadDeTrabajo<Reservacione>(context))
                {
                    unit.genericDAL.Remove(entity);
                    result = unit.Complete();
                }
            }
            catch (Exception) { result = false; }

            return result;
        }

        public void RemoveRange(IEnumerable<Reservacione> entities)
        {
            throw new NotImplementedException();
        }

        public Reservacione SingleOrDefault(Expression<Func<Reservacione, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Reservacione entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Reservacione> unit = new UnidadDeTrabajo<Reservacione>(context))
                {
                    unit.genericDAL.Update(entity);
                    result = unit.Complete();
                }

            }
            catch (Exception) { return false; }

            return result;
        }
    }
}
