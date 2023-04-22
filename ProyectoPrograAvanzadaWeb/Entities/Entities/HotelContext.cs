using System;
using System.Collections.Generic;
using Entities.Authentication;
using Entities.Utilities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Entities
{
    public partial class HotelContext : IdentityDbContext<ApplicationUser>
    {
        public HotelContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<HotelContext>();
            optionsBuilder.UseSqlServer(Utilities.Util.ConnectionString);
        }

        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Habitacione> Habitaciones { get; set; } = null!;
        public virtual DbSet<Membresia> Membresias { get; set; } = null!;
        public virtual DbSet<Reservacione> Reservaciones { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<ServiciosReservacione> ServiciosReservaciones { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        //public virtual DbSet<sp_BuscarHabitacionesDisponibles> Sp_BuscarHabitacionesDisponibles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Util.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habitacione>(entity =>
            {
                entity.HasKey(e => e.HabId)
                    .HasName("PK__Habitaci__B36CE3BEB9C8C6D3");

                entity.Property(e => e.HabId).HasColumnName("HAB_ID");

                entity.Property(e => e.HabActiva).HasColumnName("HAB_Activa");

                entity.Property(e => e.HabCantBannos).HasColumnName("HAB_CantBannos");

                entity.Property(e => e.HabCantCamas).HasColumnName("HAB_CantCamas");

                entity.Property(e => e.HabNumPuerta).HasColumnName("HAB_NumPuerta");

                entity.Property(e => e.HabPrecioPorNoche).HasColumnName("HAB_PrecioPorNoche");
            });

            modelBuilder.Entity<Membresia>(entity =>
            {
                entity.HasKey(e => e.MbrId)
                    .HasName("PK__Membresi__DF834F513E461D82");

                entity.Property(e => e.MbrId).HasColumnName("MBR_ID");

                entity.Property(e => e.MbrNombre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MBR_Nombre");
            });

            modelBuilder.Entity<Reservacione>(entity =>
            {
                entity.HasKey(e => e.RsvId)
                    .HasName("PK__Reservac__27B36B70B568C35F");

                entity.Property(e => e.RsvId).HasColumnName("RSV_ID");

                entity.Property(e => e.RsvFechaEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("RSV_FechaEntrada");

                entity.Property(e => e.RsvFechaSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("RSV_FechaSalida");

                entity.Property(e => e.RsvHabId).HasColumnName("RSV_HAB_ID");

                entity.Property(e => e.RsvPrecioFinal).HasColumnName("RSV_PrecioFinal");

                entity.Property(e => e.RsvUsrId).HasColumnName("RSV_USR_ID");

                entity.HasOne(d => d.RsvHab)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.RsvHabId)
                    .HasConstraintName("FK__Reservaci__RSV_H__32E0915F");

                entity.HasOne(d => d.RsvUsr)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.RsvUsrId)
                    .HasConstraintName("FK__Reservaci__RSV_U__75A278F5");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("PK__Roles__2A76B76AFDABA5DC");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.RolDescripcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROL_Descripcion");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.SvcId)
                    .HasName("PK__Servicio__B3376A32C0549015");

                entity.Property(e => e.SvcId).HasColumnName("SVC_ID");

                entity.Property(e => e.SvcDescripcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SVC_Descripcion");

                entity.Property(e => e.SvcPrecio).HasColumnName("SVC_Precio");
            });

            modelBuilder.Entity<ServiciosReservacione>(entity =>
            {
                entity.HasKey(e => e.SrId)
                    .HasName("PK__Servicio__1D8D1001C0605D07");

                entity.ToTable("Servicios_Reservaciones");

                entity.Property(e => e.SrId).HasColumnName("SR_ID");

                entity.Property(e => e.SrRsvId).HasColumnName("SR_RSV_ID");

                entity.Property(e => e.SrSvcId).HasColumnName("SR_SVC_ID");

                entity.HasOne(d => d.SrRsv)
                    .WithMany(p => p.ServiciosReservaciones)
                    .HasForeignKey(d => d.SrRsvId)
                    .HasConstraintName("FK__Servicios__SR_RS__33D4B598");

                entity.HasOne(d => d.SrSvc)
                    .WithMany(p => p.ServiciosReservaciones)
                    .HasForeignKey(d => d.SrSvcId)
                    .HasConstraintName("FK__Servicios__SR_SV__34C8D9D1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsrId)
                    .HasName("PK__Usuarios__91DE2276BAD33B54");

                entity.Property(e => e.UsrId).HasColumnName("USR_ID");

                entity.Property(e => e.UsrApellido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USR_Apellido");

                entity.Property(e => e.UsrEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USR_Email");

                entity.Property(e => e.UsrMbrId).HasColumnName("USR_MBR_ID");

                entity.Property(e => e.UsrNombre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USR_Nombre");

                entity.Property(e => e.UsrPassword)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USR_Password");

                entity.Property(e => e.UsrRolId).HasColumnName("USR_ROL_ID");

                entity.HasOne(d => d.UsrMbr)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.UsrMbrId)
                    .HasConstraintName("FK__Usuarios__USR_MB__30F848ED");

                entity.HasOne(d => d.UsrRol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.UsrRolId)
                    .HasConstraintName("FK__Usuarios__USR_RO__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);

            /*Esto es para un error que se presenta al hacer el add-migration identity*/
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
