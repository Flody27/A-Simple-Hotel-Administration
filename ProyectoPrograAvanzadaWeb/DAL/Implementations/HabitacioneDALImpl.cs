using DAL.Interfaces;
using Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;


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

                habitaciones = unidad.genericDAL.Get(id);
            }
            return habitaciones;

        }



        public sp_BuscarHabitacionesDisponibles BuscarHabitacion(BuscarHabitacionesDisponibles entity)
        {
            try
            {
                using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Hotel;Integrated Security=True;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("BuscarHabitacionesDisponibles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Cant_camas", entity.CantCamas);
                        cmd.Parameters.AddWithValue("@Entrada", entity.Entrada);
                        cmd.Parameters.AddWithValue("@Salida", entity.Salida);

                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                return new sp_BuscarHabitacionesDisponibles
                                {
                                    HabId = (int)reader[0],
                                    HabNumPuerta = (int)reader[1],
                                    HabCantCamas = (int)reader[2],
                                    HabCantBannos = (int)reader[3],
                                    HabPrecioPorNoche = (double)reader[4],
                                    HabActiva = (bool)reader[5],

                                };
                            }
                        }

                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
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
